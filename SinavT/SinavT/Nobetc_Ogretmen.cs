using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Batl.DAL;
using System.Data.OleDb;
using Batl.Info;

namespace SinavT
{
    public partial class Nobetc_Ogretmen : Form
    {
        SabitTarihDB sabitTarih = new SabitTarihDB();
        SabitMudurYardimcilerDB sabitMudurYardimciler = new SabitMudurYardimcilerDB();
        SabitOgretmenDB sabitOgretmen = new SabitOgretmenDB();
        NobetciOgretmenDB nobetciOgretmen = new NobetciOgretmenDB();
        NobetciOgretmenInfo nobetciOgretmenBilgi = new NobetciOgretmenInfo();
        string kayitDurumu = "";
        int kayitNo = -1;

        public Nobetc_Ogretmen()
        { InitializeComponent(); }

        private void buttonCks_Click(object sender, EventArgs e)
        { this.Close(); }

        private void KayitlariGoster()
        {
            try
            {
                lstTarih.DataSource = sabitTarih.TarihleriGetir();
                lstTarih.ValueMember = "id";
                lstTarih.DisplayMember = "tarih";
                lstMudurYardimcisi.DataSource = sabitMudurYardimciler.KayitlariGetir();
                lstMudurYardimcisi.ValueMember = "id";
                lstMudurYardimcisi.DisplayMember = "adi";
                lstOgretmenler.DataSource = sabitOgretmen.KayitlariGetir();
                lstOgretmenler.ValueMember = "id";
                lstOgretmenler.DisplayMember = "adi";
            }
            catch (Exception)
            { }
        }

        private void NobetcileriGetir()
        {
            txtNobetciOgretmen.Clear();
            txtNobetciMudurYardimcisi.Clear();
            kayitDurumu = "Ekle";
            kayitNo = -1;
            try
            {
                OleDbDataReader ogretmenler = nobetciOgretmen.SeciliTarihKayitlariniGetir(lstTarih.Text);
                while (ogretmenler.Read())
                {
                    kayitDurumu = "Duzenle";
                    txtNobetciMudurYardimcisi.Text = ogretmenler["MudurYardimcisiAdi"].ToString();
                    txtNobetciMudurYardimcisi.Tag = ogretmenler["mudurYardimcisiId"].ToString();
                    txtNobetciOgretmen.Text = ogretmenler["OgretmenAdi"].ToString();
                    txtNobetciOgretmen.Tag = ogretmenler["ogretmenId"].ToString();
                    kayitNo = Convert.ToInt32(ogretmenler["NobetciOgretmenId"]);
                }
                ogretmenler.Close();
            }
            catch (Exception)
            { }
        }

        private void Nobetc_Ogretmen_Load(object sender, EventArgs e)
        {
            KayitlariGoster();
            NobetcileriGetir();
        }

        private void lstMudurYardimcisi_DoubleClick(object sender, EventArgs e)
        {
            txtNobetciMudurYardimcisi.Text = lstMudurYardimcisi.Text;
            txtNobetciMudurYardimcisi.Tag = lstMudurYardimcisi.SelectedValue.ToString();
        }

        private void lstOgretmenler_DoubleClick(object sender, EventArgs e)
        { 
            txtNobetciOgretmen.Text = lstOgretmenler.Text;
            txtNobetciOgretmen.Tag = lstOgretmenler.SelectedValue.ToString();
        }

        private void lstTarih_Click(object sender, EventArgs e)
        { NobetcileriGetir(); }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstTarih.Items.Count > 0)
            {
                if (kayitDurumu == "Ekle")
                {
                    nobetciOgretmenBilgi.MudurYardimcisi = Convert.ToInt32(txtNobetciMudurYardimcisi.Tag);
                    nobetciOgretmenBilgi.Ogretmen = Convert.ToInt32(txtNobetciOgretmen.Tag);
                    nobetciOgretmenBilgi.Tarih = Convert.ToInt32(lstTarih.SelectedValue);
                    nobetciOgretmen.KayitEkle(nobetciOgretmenBilgi);
                }
                if (kayitDurumu == "Duzenle")
                {
                    nobetciOgretmenBilgi.Id = kayitNo;
                    nobetciOgretmenBilgi.MudurYardimcisi = Convert.ToInt32(txtNobetciMudurYardimcisi.Tag);
                    nobetciOgretmenBilgi.Ogretmen = Convert.ToInt32(txtNobetciOgretmen.Tag);
                    nobetciOgretmen.KayitDegistir(nobetciOgretmenBilgi);
                }
            }
        }
    }
}
