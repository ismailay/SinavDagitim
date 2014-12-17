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
    public partial class Sinav_Iptl : Form
    {
        DersDagitimDB dersDagitim = new DersDagitimDB();
        DersDagitimOgretmenDB dersDagitimOgretmen = new DersDagitimOgretmenDB();

        public Sinav_Iptl()
        { InitializeComponent(); }

        private void buttonCks_Click(object sender, EventArgs e)
        { this.Close(); }

        private void OgretmenKayitlariniGoster()
        {
            dtGridOgretmenler.DataSource = null;
            try
            {
                int id = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["DersDagitimId"].Value);
                dtGridOgretmenler.DataSource = dersDagitim.SeciliDerseAitOgretmenleriGetir(id);
                dtGridOgretmenler.AutoGenerateColumns = false;
            }
            catch (Exception)
            { }
        }

        private void DersKayitlariniGoster()
        {
            try
            {
                dtGridDersler.DataSource = dersDagitim.KayitlariGetir();
                dtGridDersler.AutoGenerateColumns = false;
                //  dataGridViewOgrnci.DataSource = sabitOgrenci.KayitlariGetir();
            }
            catch (Exception)
            { }
        }

        private void Sinav_Iptl_Load(object sender, EventArgs e)
        {
            DersKayitlariniGoster();
            OgretmenKayitlariniGoster();

        }

        private void dtGridDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OgretmenKayitlariniGoster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["DersDagitimId"].Value);
                string dersAdi = dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["SabitDersAdi"].Value.ToString();
                DialogResult cevap = MessageBox.Show(dersAdi + " ait Kayıdı Silmek istiyor musunuz?", "Dikkat !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (cevap == DialogResult.Yes)
                {
                    dersDagitim.KayitSil(id);
                  //  dersDagitimOgretmen.DerseAitOgretmenleriSil(id);
                    DersKayitlariniGoster();
                    OgretmenKayitlariniGoster();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
