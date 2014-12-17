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
    public partial class SinifBilgileri : Form
    {
        SabitSinifDB sabitSinif = new SabitSinifDB();
        SabitSinifInfo SabitSinifBilgi = new SabitSinifInfo();
        SabitBolumDB sabitBolum = new SabitBolumDB();
        SabitBolumInfo SabitBolumBilgi = new SabitBolumInfo();
        SabitDersGrupDB SabitDersGrup = new SabitDersGrupDB();
        SabitDersGrupInfo SabitDersGrupBilgi = new SabitDersGrupInfo();
        SabitSinavSekliDB SabitSinavSekli = new SabitSinavSekliDB();
        SabitSinavSekliInfo SabitSinavSekliBilgi = new SabitSinavSekliInfo();

        string kayitDurumu = "";
        string tablo = "Sinif";
        public SinifBilgileri()
        {
            InitializeComponent();
        }
        private void Kayitlari_Goster()
        {
            try
            {
                dataGridSnfBlglrSnfAdi.DataSource = sabitSinif.KayitlariGetir();
                dataGridSnfBlglrSnfBlm.DataSource = sabitBolum.KayitlariGetir();
                dataGridView1.DataSource = SabitDersGrup.KayitlariGetir();
                dtGridViewSinavTuru.DataSource = SabitSinavSekli.KayitlariGetir();
            }
            catch (Exception)
            { }

        }
        private void aktif(string a)
        {
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            btnEkle.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            dataGridSnfBlglrSnfBlm.Enabled = false;
            dataGridSnfBlglrSnfAdi.Enabled = false;
            dtGridViewSinavTuru.Enabled = false;
            dataGridView1.Enabled = false;
            if (a == "Bolum")
            {
                txtBolumAdi.Enabled = true;
                txtSinifAdi.Enabled = false;
                txtSeviyeAdi.Enabled = false;
                txtSinavTuru.Enabled = false;
            }
            if (a == "Sinif")
            {
                txtBolumAdi.Enabled = false;
                txtSinifAdi.Enabled = true;
                txtSeviyeAdi.Enabled = false;
                txtSinavTuru.Enabled = false;
            }
            if (a == "Seviye")
            {
                txtBolumAdi.Enabled = false;
                txtSinifAdi.Enabled = false;
                txtSeviyeAdi.Enabled = true;
                txtSinavTuru.Enabled = false;
            }
            if (a == "Turu")
            {
                txtBolumAdi.Enabled = false;
                txtSinifAdi.Enabled = false;
                txtSeviyeAdi.Enabled = false;
                txtSinavTuru.Enabled = true;
            }



        }

        private void pasif(string a)
        {
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            btnEkle.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            dataGridSnfBlglrSnfBlm.Enabled = true;
            dataGridSnfBlglrSnfAdi.Enabled = true;
            dtGridViewSinavTuru.Enabled = true;
            dataGridView1.Enabled = true;
            txtBolumAdi.Enabled = false;
            txtSinifAdi.Enabled = false;
            txtSeviyeAdi.Enabled = false;
            txtSinavTuru.Enabled = false;
            txtBolumAdi.Clear();
            txtSinifAdi.Clear();
            txtSeviyeAdi.Clear();
            txtSinavTuru.Clear();
        }
        private void SinifBilgileri_Load(object sender, EventArgs e)
        {
            pasif(tablo);
            Kayitlari_Goster();
            dataGridSnfBlglrSnfAdi.Focus();
            dataGridSnfBlglrSnfBlm.ClearSelection();
            dataGridView1.ClearSelection();
            dtGridViewSinavTuru.ClearSelection();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kayitDurumu = "Ekle";
            aktif(tablo);
            if (tablo == "Bolum") txtBolumAdi.Focus();
            if (tablo == "Sinif") txtSinifAdi.Focus();
            if (tablo == "Seviye") txtSeviyeAdi.Focus();
            if (tablo == "Turu") txtSinavTuru.Focus();
        }

        private void dataGridSnfBlglrSnfAdi_Click(object sender, EventArgs e)
        {
            tablo = "Sinif";
            dataGridSnfBlglrSnfBlm.ClearSelection();
            dataGridView1.ClearSelection();
            dtGridViewSinavTuru.ClearSelection();
        }

        private void dataGridSnfBlglrSnfBlm_Click(object sender, EventArgs e)
        {
            tablo = "Bolum";
            dataGridSnfBlglrSnfAdi.ClearSelection();
            dataGridView1.ClearSelection();
            dtGridViewSinavTuru.ClearSelection();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            tablo = "Seviye";
            dataGridSnfBlglrSnfAdi.ClearSelection();
            dataGridSnfBlglrSnfBlm.ClearSelection();
            dtGridViewSinavTuru.ClearSelection();
        }

        private void dtGridViewSinavTuru_Click(object sender, EventArgs e)
        {
            tablo = "Turu";
            dataGridSnfBlglrSnfAdi.ClearSelection();
            dataGridSnfBlglrSnfBlm.ClearSelection();
            dataGridView1.ClearSelection();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablo == "Bolum")
                {
                    SabitBolumBilgi.Ad = txtBolumAdi.Text;
                    if (kayitDurumu == "Ekle")
                    { sabitBolum.KayitEkle(SabitBolumBilgi); }
                    if (kayitDurumu == "Duzenle")
                    { sabitBolum.KayitDegistir(SabitBolumBilgi); }
                }
                if (tablo == "Sinif")
                {
                    SabitSinifBilgi.Adi = txtSinifAdi.Text;
                    if (kayitDurumu == "Ekle")
                    { sabitSinif.KayitEkle(SabitSinifBilgi); }
                    if (kayitDurumu == "Duzenle")
                    { sabitSinif.KayitDegistir(SabitSinifBilgi); }
                }
                if (tablo == "Seviye")
                {
                    SabitDersGrupBilgi.Grup = txtSeviyeAdi.Text;
                    if (kayitDurumu == "Ekle")
                    { SabitDersGrup.KayitEkle(SabitDersGrupBilgi); }
                    if (kayitDurumu == "Duzenle")
                    { SabitDersGrup.KayitDegistir(SabitDersGrupBilgi); }
                }
                if (tablo == "Turu")
                {
                    SabitSinavSekliBilgi.Adi = txtSinavTuru.Text;
                    if (kayitDurumu == "Ekle")
                    { SabitSinavSekli.KayitEkle(SabitSinavSekliBilgi); }
                    if (kayitDurumu == "Duzenle")
                    { SabitSinavSekli.KayitDegistir(SabitSinavSekliBilgi); }
                }
                pasif(tablo);
                Kayitlari_Goster();
            }
            catch (Exception)
            {


            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            pasif(tablo);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Silmek istiyor musunuz?", "Dikkat !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (tablo == "Bolum")
                {
                    int id = Convert.ToInt32(dataGridSnfBlglrSnfBlm.Rows[dataGridSnfBlglrSnfBlm.CurrentCellAddress.Y].Cells["bolumId"].Value);
                    if (cevap == DialogResult.Yes)
                    {
                        sabitBolum.KayitSil(id);
                        Kayitlari_Goster();
                    }
                }

                if (tablo == "Sinif")
                {
                    int id = Convert.ToInt32(dataGridSnfBlglrSnfAdi.Rows[dataGridSnfBlglrSnfAdi.CurrentCellAddress.Y].Cells["sinifId"].Value);
                    if (cevap == DialogResult.Yes)
                    {
                        sabitSinif.KayitSil(id);
                        Kayitlari_Goster();
                    }
                }
                if (tablo == "Seviye")
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells["seviyeId"].Value);
                    if (cevap == DialogResult.Yes)
                    {
                        SabitDersGrup.KayitSil(id);
                        Kayitlari_Goster();
                    }
                }
                if (tablo == "Turu")
                {
                    int id = Convert.ToInt32(dtGridViewSinavTuru.Rows[dtGridViewSinavTuru.CurrentCellAddress.Y].Cells["TurId"].Value);
                    if (cevap == DialogResult.Yes)
                    {
                        SabitSinavSekli.KayitSil(id);
                        Kayitlari_Goster();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablo == "Bolum")
                {
                    SabitBolumBilgi.Id = Convert.ToInt32(dataGridSnfBlglrSnfBlm.Rows[dataGridSnfBlglrSnfBlm.CurrentCellAddress.Y].Cells["bolumId"].Value);
                    txtBolumAdi.Text = dataGridSnfBlglrSnfBlm.Rows[dataGridSnfBlglrSnfBlm.CurrentCellAddress.Y].Cells["bolumAdi"].Value.ToString();
                }
                if (tablo == "Sinif")
                {
                    SabitSinifBilgi.Id = Convert.ToInt32(dataGridSnfBlglrSnfAdi.Rows[dataGridSnfBlglrSnfAdi.CurrentCellAddress.Y].Cells["sinifId"].Value);
                    txtSinifAdi.Text = dataGridSnfBlglrSnfAdi.Rows[dataGridSnfBlglrSnfAdi.CurrentCellAddress.Y].Cells["sinifAdi"].Value.ToString();
                }
                if (tablo == "Seviye")
                {
                    SabitDersGrupBilgi.Id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells["seviyeId"].Value);
                    txtSeviyeAdi.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells["seviyeAdi"].Value.ToString();
                }
                if (tablo == "Turu")
                {
                    SabitSinavSekliBilgi.Id = Convert.ToInt32(dtGridViewSinavTuru.Rows[dtGridViewSinavTuru.CurrentCellAddress.Y].Cells["TurId"].Value);
                    txtSinavTuru.Text = dtGridViewSinavTuru.Rows[dtGridViewSinavTuru.CurrentCellAddress.Y].Cells["TurAdi"].Value.ToString();
                }
                kayitDurumu = "Duzenle";
                aktif(tablo);
            }
            catch (Exception)
            {

                MessageBox.Show("Düzenlenecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCks_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
