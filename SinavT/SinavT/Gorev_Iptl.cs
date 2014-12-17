using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Batl.DAL;

namespace SinavT
{
    public partial class Gorev_Iptl : Form
    {
        DersDagitimOgretmenDB dersDagitimOgretmen = new DersDagitimOgretmenDB();
        DersDagitimDB dersDagitim = new DersDagitimDB();

        public Gorev_Iptl()
        { InitializeComponent(); }

        private void buttonCks_Click(object sender, EventArgs e)
        { this.Close(); }

        private void OgretmenKayitlariniGoster()
        {
            lstOgretmen.DataSource = null;
            try
            {
                lstOgretmen.DataSource = dersDagitimOgretmen.KayitlariGetir();
                lstOgretmen.ValueMember = "OgretmenId";
                lstOgretmen.DisplayMember = "OgretmenAdi";
            }
            catch (Exception)
            { }
        }

        private void DersKayitlariniGoster()
        {
            dtGridDersler.DataSource = null;
            try
            {
                if (lstOgretmen.Items.Count > 0)
                {
                    dtGridDersler.DataSource = dersDagitim.SeciliDersleriGetir(Convert.ToInt32(lstOgretmen.SelectedValue));
                    dtGridDersler.AutoGenerateColumns = false;
                    if (dtGridDersler.Rows.Count == 0)
                    {
                        OgretmenKayitlariniGoster();
                        DersKayitlariniGoster();
                    }
                }
                //  dataGridViewOgrnci.DataSource = sabitOgrenci.KayitlariGetir();
            }
            catch (Exception)
            { }
        }
        private void Gorev_Iptl_Load(object sender, EventArgs e)
        {
            OgretmenKayitlariniGoster();
            DersKayitlariniGoster();
        }

        private void lstOgretmen_Click(object sender, EventArgs e)
        {
            DersKayitlariniGoster();
        }

        private void btnSinavGoreviniSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["id"].Value);
                DialogResult cevap = MessageBox.Show("Silmek istiyor musunuz?", "Dikkat !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (cevap == DialogResult.Yes)
                {
                    dersDagitimOgretmen.KayitSil(id);
                    DersKayitlariniGoster();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTumGorevleriSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstOgretmen.Items.Count > 0)
                {
                    int id = Convert.ToInt32(lstOgretmen.SelectedValue);
                    DialogResult cevap = MessageBox.Show(lstOgretmen.Text + " ait Kayıdı Silmek istiyor musunuz?", "Dikkat !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    if (cevap == DialogResult.Yes)
                    {
                        dersDagitimOgretmen.OgretmeninTumKayitlariniSil(id);
                        OgretmenKayitlariniGoster();
                        DersKayitlariniGoster();
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
