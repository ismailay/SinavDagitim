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
    public partial class Ogretmen : Form
    {
        SabitOgretmenDB sabitOgretmen = new SabitOgretmenDB();
        SabitOgretmenInfo SabitOgretmenBilgi = new SabitOgretmenInfo();
        string kayitDurumu = "";
        public Ogretmen()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        { this.Close(); }


        private void Kayitlari_Goster()
        {
            try
            {
                dataGridViewOgtmn.AutoGenerateColumns = false;
                dataGridViewOgtmn.DataSource = sabitOgretmen.KayitlariGetir();
            }
            catch (Exception)
            {
            }

        }
        private void aktif()
        {
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            btnEkle.Enabled = false;
            dataGridViewOgtmn.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            txtAdiSoyadi.Enabled = true;
            txtBolumu.Enabled = true;
        }

        private void pasif()
        {
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            btnEkle.Enabled = true;
            dataGridViewOgtmn.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            txtAdiSoyadi.Enabled = false;
            txtBolumu.Enabled = false;
            txtAdiSoyadi.Clear();
            txtBolumu.Clear();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SabitOgretmenBilgi.Id = Convert.ToInt32(dataGridViewOgtmn.Rows[dataGridViewOgtmn.CurrentCellAddress.Y].Cells["id"].Value);
                txtAdiSoyadi.Text = dataGridViewOgtmn.Rows[dataGridViewOgtmn.CurrentCellAddress.Y].Cells["adi"].Value.ToString();
                txtBolumu.Text = dataGridViewOgtmn.Rows[dataGridViewOgtmn.CurrentCellAddress.Y].Cells["bolum"].Value.ToString();
                kayitDurumu = "Duzenle";
                aktif();
            }
            catch (Exception)
            {
                MessageBox.Show("Düzenlenecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kayitDurumu = "Ekle";
            aktif();
            txtAdiSoyadi.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //  try
            {
                SabitOgretmenBilgi.Adi = txtAdiSoyadi.Text;
                SabitOgretmenBilgi.Bolum = txtBolumu.Text;
                SabitOgretmenBilgi.Grup = "";
                if (kayitDurumu == "Ekle")
                {
                    SabitOgretmenBilgi.EskiGozcuGorevi = 0;
                    SabitOgretmenBilgi.EskiKomisyonGorevi = 0;
                    SabitOgretmenBilgi.YeniGozcuGorevi = 0;
                    SabitOgretmenBilgi.YeniKomisyonGorevi = 0;
                    sabitOgretmen.KayitEkle(SabitOgretmenBilgi);
                }
                if (kayitDurumu == "Duzenle")
                {

                    SabitOgretmenBilgi.EskiGozcuGorevi = Convert.ToInt32(dataGridViewOgtmn.Rows[dataGridViewOgtmn.CurrentCellAddress.Y].Cells["EskiGozcuGorevi"].Value);
                    SabitOgretmenBilgi.EskiKomisyonGorevi = Convert.ToInt32(dataGridViewOgtmn.Rows[dataGridViewOgtmn.CurrentCellAddress.Y].Cells["EskiKomisyonGorevi"].Value);
                    SabitOgretmenBilgi.YeniGozcuGorevi = Convert.ToInt32(dataGridViewOgtmn.Rows[dataGridViewOgtmn.CurrentCellAddress.Y].Cells["YeniGozcuGorevi"].Value);
                    SabitOgretmenBilgi.YeniKomisyonGorevi = Convert.ToInt32(dataGridViewOgtmn.Rows[dataGridViewOgtmn.CurrentCellAddress.Y].Cells["YeniKomisyonGorevi"].Value);
                    sabitOgretmen.KayitDegistir(SabitOgretmenBilgi);
                }
                pasif();
                Kayitlari_Goster();

            }
            //  catch (Exception)
            { }

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        { pasif(); }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridViewOgtmn.Rows[dataGridViewOgtmn.CurrentCellAddress.Y].Cells["id"].Value);
                DialogResult cevap = MessageBox.Show("Silmek istiyor musunuz?", "Dikkat !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (cevap == DialogResult.Yes)
                {
                    sabitOgretmen.KayitSil(id);
                    Kayitlari_Goster();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ogretmen_Load(object sender, EventArgs e)
        { Kayitlari_Goster(); }
    }
}
