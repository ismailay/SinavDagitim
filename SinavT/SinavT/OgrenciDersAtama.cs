using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Batl.DAL;
using Batl.Info;

namespace SinavT
{
    public partial class OgrenciDersAtama : Form
    {
        SabitOgrenciDB sabitOgrenci = new SabitOgrenciDB();
        OgrenciDersDB ogrenciDers = new OgrenciDersDB();
        SabitBolumDB sabitBolum = new SabitBolumDB();
        SabitDersDB sabitDers = new SabitDersDB();
        SabitDersGrupDB sabitDersGrup = new SabitDersGrupDB();
        OgrenciDersInfo ogrenciDersBilgi = new OgrenciDersInfo();
        bool silmeDurumu = false;

        public OgrenciDersAtama()
        { InitializeComponent(); }

        private void buttonCks_Click(object sender, EventArgs e)
        { this.Close(); }

        private void Kayitlari_Goster()
        {
            try
            {
                lstSeviye.DataSource = sabitDersGrup.KayitlariGetir();
                lstSeviye.ValueMember = "id";
                lstSeviye.DisplayMember = "grup";
                lstBolum.DataSource = sabitBolum.KayitlariGetir();
                lstBolum.ValueMember = "id";
                lstBolum.DisplayMember = "ad";
                dataGridViewOgrnci.AutoGenerateColumns = false;
                dataGridViewOgrnci.DataSource = sabitOgrenci.KayitlariGetir();
                SilmeDurumunuGoster();
            }
            catch (Exception)
            { }
        }

        private void BolumSeviyeKayitlariGoster()
        {
            try
            {
                int bolumId, seviyeId;
                bolumId = Convert.ToInt32(lstBolum.SelectedValue);
                seviyeId = Convert.ToInt32(lstSeviye.SelectedValue);
                cmbDersAdi.Text = "";
                cmbDersAdi.DataSource = sabitDers.BolumSeviyeKayitlariniGetir(bolumId, seviyeId);
                cmbDersAdi.ValueMember = "dersid";
                cmbDersAdi.DisplayMember = "dersadi";
            }
            catch (Exception)
            { }
        }

        private void SilmeDurumunuGoster()
        {
            if (dataGridViewOgrnci.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewOgrnci.Rows[dataGridViewOgrnci.CurrentCellAddress.Y].Cells["id"].Value);
                dataGridViewSvye.DataSource = ogrenciDers.KayitlariGetir(id);
                if (Convert.ToInt32(dataGridViewSvye.RowCount.ToString()) > 0)
                {
                    silmeDurumu = true;
                    btnSil.Enabled = true;
                }
                else
                {
                    silmeDurumu = false;
                    btnSil.Enabled = false;
                }
            }
        }

        private void OgrenciDersAtama_Load(object sender, EventArgs e)
        {
            Kayitlari_Goster();
            BolumSeviyeKayitlariGoster();
        }

        private void dataGridViewOgrnci_Click(object sender, EventArgs e)
        { SilmeDurumunuGoster(); }

        private void lstSeviye_Click(object sender, EventArgs e)
        { BolumSeviyeKayitlariGoster(); }

        private void lstBolum_Click(object sender, EventArgs e)
        { BolumSeviyeKayitlariGoster(); }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ogrenciDersBilgi.Idx = Convert.ToInt32(dataGridViewOgrnci.Rows[dataGridViewOgrnci.CurrentCellAddress.Y].Cells["id"].Value);
                ogrenciDersBilgi.Ders = Convert.ToInt32(cmbDersAdi.SelectedValue);
                ogrenciDersBilgi.Adi = "";
                int a=Convert.ToInt32(ogrenciDers.KayitKontrol(ogrenciDersBilgi).Rows.Count);
                if ( a== 0)
                {
                    ogrenciDers.KayitEkle(ogrenciDersBilgi);
                    SilmeDurumunuGoster();
                }
            }
            catch (Exception)
            { }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (silmeDurumu == true)
                {
                    int id = Convert.ToInt32(dataGridViewSvye.Rows[dataGridViewSvye.CurrentCellAddress.Y].Cells["listeleId"].Value);
                    DialogResult cevap = MessageBox.Show("Silmek istiyor musunuz?", "Dikkat !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    if (cevap == DialogResult.Yes)
                    {
                        ogrenciDers.KayitSil(id);
                        SilmeDurumunuGoster();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
