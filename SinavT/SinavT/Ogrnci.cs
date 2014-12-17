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

    public partial class Ogrnci : Form
    {
        SabitOgrenciDB sabitOgrenci = new SabitOgrenciDB();
        SabitSinifDB sabitSinif = new SabitSinifDB();
        SabitOgrenciInfo SabitOgrenciBilgi = new SabitOgrenciInfo();
        string kayitDurumu = "";

        private void Kayitlari_Goster()
        {
            try
            {
                cmbSinif.DataSource = sabitSinif.KayitlariGetir();
                cmbSinif.ValueMember = "id";
                cmbSinif.DisplayMember = "adi";
                dataGridViewOgrnci.AutoGenerateColumns = false;
                dataGridViewOgrnci.DataSource = sabitOgrenci.KayitlariGetir();
            }
            catch (Exception)
            { }

        }
        private void aktif()
        {
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            btnEkle.Enabled = false;
            dataGridViewOgrnci.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            cmbSinif.Enabled = true;
            txtAdiSoyadi.Enabled = true;
            txtNumara.Enabled = true;
        }

        private void pasif()
        {
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            btnEkle.Enabled = true;
            dataGridViewOgrnci.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            cmbSinif.Enabled = false;
            txtAdiSoyadi.Enabled = false;
            txtNumara.Enabled = false;
            txtAdiSoyadi.Clear();
            txtNumara.Clear();
        }
        public Ogrnci()
        {
            InitializeComponent();
        }

        private void buttonCks_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ogrnci_Load(object sender, EventArgs e)
        { Kayitlari_Goster(); }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SabitOgrenciBilgi.Id = Convert.ToInt32(dataGridViewOgrnci.Rows[dataGridViewOgrnci.CurrentCellAddress.Y].Cells["id"].Value);
                txtNumara.Text = dataGridViewOgrnci.Rows[dataGridViewOgrnci.CurrentCellAddress.Y].Cells["numara"].Value.ToString();
                txtAdiSoyadi.Text = dataGridViewOgrnci.Rows[dataGridViewOgrnci.CurrentCellAddress.Y].Cells["adsoyad"].Value.ToString();
                cmbSinif.SelectedValue = Convert.ToInt32(dataGridViewOgrnci.Rows[dataGridViewOgrnci.CurrentCellAddress.Y].Cells["sinifId"].Value.ToString());
                kayitDurumu = "Duzenle";
                aktif();
            }
            catch (Exception)
            {
                MessageBox.Show("Düzenlenecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridViewOgrnci.Rows[dataGridViewOgrnci.CurrentCellAddress.Y].Cells["id"].Value);
                DialogResult cevap = MessageBox.Show("Silmek istiyor musunuz?", "Dikkat !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (cevap == DialogResult.Yes)
                {
                    sabitOgrenci.KayitSil(id);
                    Kayitlari_Goster();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SabitOgrenciBilgi.Numara = txtNumara.Text;
                SabitOgrenciBilgi.Sinif = Convert.ToInt32(cmbSinif.SelectedValue);
                SabitOgrenciBilgi.Adsoyad = txtAdiSoyadi.Text;
                SabitOgrenciBilgi.Ders= "";
                SabitOgrenciBilgi.Notu = "";
                if (kayitDurumu == "Ekle")
                { sabitOgrenci.KayitEkle(SabitOgrenciBilgi); }
                if (kayitDurumu == "Duzenle")
                { sabitOgrenci.KayitDegistir(SabitOgrenciBilgi); }
                pasif();
                Kayitlari_Goster();

            }
            catch (Exception)
            { }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        { pasif(); }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kayitDurumu = "Ekle";
            aktif();
            txtNumara.Focus();
        }
    }
}
