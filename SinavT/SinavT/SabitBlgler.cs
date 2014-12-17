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
    public partial class SabitBlgler : Form
    {
        SabitOkulDB sabitOkul = new SabitOkulDB();
        SabitMudurYardimcilerDB sabitMdrYrd = new SabitMudurYardimcilerDB();
        SabitOkulInfo sabitOkulBilgi = new SabitOkulInfo();
        SabitMudurYardimcilarInfo SabitMudurYardimcilarBilgi = new SabitMudurYardimcilarInfo();
        ZamanDB zaman = new ZamanDB();
        ZamanInfo zamanBilgi = new ZamanInfo();
        SabitSaatDB sabitSaat = new SabitSaatDB();
        SabitTarihDB sabitTarih = new SabitTarihDB();
        SabitTarihInfo sabitTarihBilgi = new SabitTarihInfo();
        string kayitDurumu = "";
        public SabitBlgler()
        {
            InitializeComponent();
        }

        private void Kayitlari_Goster()
        {
            //   try
            {
                //Sekme 1 Bilgiler
                if (sabitOkul.KayitlariGetir().Rows.Count > 0)
                {
                    sabitOkulBilgi = sabitOkul.KayitGetir(Convert.ToInt32(sabitOkul.KayitlariGetir().Rows[0][0]));
                    txtOkulAdi1.Text = sabitOkulBilgi.OkulAdi1.ToString();
                    txtOkulAdi2.Text = sabitOkulBilgi.OkulAdi2.ToString();
                    txtIl.Text = sabitOkulBilgi.Il.ToString();
                    txtIlcesi.Text = sabitOkulBilgi.Ilce.ToString();
                    txtTelefonNumarasi.Text = sabitOkulBilgi.Tel.ToString();
                    txtOgretimYili.Text = sabitOkulBilgi.OgretimYili.ToString();
                    txtSinavDonemi.Text = sabitOkulBilgi.SinavDonemi.ToString();
                    dtpckrBaslangicTarihi.Value = sabitOkulBilgi.SinavBaslamaTarihi;
                    dtpckrBitisTarihi.Value = sabitOkulBilgi.SinavBitisTarihi;
                    txtGozculukGoreviSaatUcreti.Text = sabitOkulBilgi.UcretGozcu.ToString();
                    txtKomisyonGoreviSaatUcreti.Text = sabitOkulBilgi.UcretKomisyon.ToString();
                    txtGunlukMaksimumSinavSayisi.Text = sabitOkulBilgi.MaksimumSaat.ToString();
                    txtOgrencininGunlukGirebilecegiSinavSayisi.Text = sabitOkulBilgi.MaksimumOgrencininGirecegiSinav.ToString();
                    txtMudur.Text = sabitOkulBilgi.Mudur.ToString();
                    //Sekme 2 Bilgiler
                    txtSayi.Text = sabitOkulBilgi.Sayi.ToString();
                    txtKonu.Text = sabitOkulBilgi.Konu.ToString();
                    txtTarih.Text = sabitOkulBilgi.Tarih.ToString();
                    txtRapor1.Text = sabitOkulBilgi.RaporBaslik1.ToString();
                    txtRapor2.Text = sabitOkulBilgi.RaporBaslik2.ToString();
                    txtRapor3.Text = sabitOkulBilgi.RaporBaslik3.ToString();
                    txtDipnot.Text = sabitOkulBilgi.Dipnot.ToString();
                }
            }
            //       catch (Exception)
            { }
            try
            {
                //Sekme 3 Bilgiler
                dataGridMudurYardimcisi.DataSource = sabitMdrYrd.KayitlariGetir();
            }
            catch (Exception)
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        { this.Close(); }

        private void aktif()
        {
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            btnEkle.Enabled = false;
            dataGridMudurYardimcisi.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            txtAdiSoyadi.Enabled = true;
            txtUnvani.Enabled = true;
        }

        private void pasif()
        {
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            btnEkle.Enabled = true;
            dataGridMudurYardimcisi.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            txtAdiSoyadi.Enabled = false;
            txtUnvani.Enabled = false;
            txtAdiSoyadi.Clear();
            txtUnvani.Clear();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            //sabitMdrYrd.KayitSil(Convert.ToInt32(dataGridMudurYardimcisi.Rows[0].ToString()));
            try
            {
                int id = Convert.ToInt32(dataGridMudurYardimcisi.Rows[dataGridMudurYardimcisi.CurrentCellAddress.Y].Cells["id"].Value);
                DialogResult cevap = MessageBox.Show("Silmek istiyor musunuz?", "Dikkat !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (cevap == DialogResult.Yes)
                {
                    sabitMdrYrd.KayitSil(id);
                    dataGridMudurYardimcisi.DataSource = sabitMdrYrd.KayitlariGetir();
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
                SabitMudurYardimcilarBilgi.Id = Convert.ToInt32(dataGridMudurYardimcisi.Rows[dataGridMudurYardimcisi.CurrentCellAddress.Y].Cells["id"].Value);
                txtAdiSoyadi.Text = dataGridMudurYardimcisi.Rows[dataGridMudurYardimcisi.CurrentCellAddress.Y].Cells["adi"].Value.ToString();
                txtUnvani.Text = dataGridMudurYardimcisi.Rows[dataGridMudurYardimcisi.CurrentCellAddress.Y].Cells["unvan"].Value.ToString();
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
            SabitMudurYardimcilarBilgi.Adi = txtAdiSoyadi.Text;
            SabitMudurYardimcilarBilgi.Unvan = txtUnvani.Text;
            if (kayitDurumu == "Ekle")
            { sabitMdrYrd.KayitEkle(SabitMudurYardimcilarBilgi); }
            if (kayitDurumu == "Duzenle")
            { sabitMdrYrd.KayitDegis(SabitMudurYardimcilarBilgi); }
            pasif();
            dataGridMudurYardimcisi.DataSource = sabitMdrYrd.KayitlariGetir();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        { pasif(); }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (dtpckrBitisTarihi.Value <= dtpckrBaslangicTarihi.Value)
            {
                MessageBox.Show("Lütfen sinav bitiş tarihi büyük giriniz", "Uyarı !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // tarihte değişiklik varsa zaman isimli tabloyu sil
                if (dtpckrBaslangicTarihi.Value != sabitOkulBilgi.SinavBaslamaTarihi) zamanBilgi.ZamandaDegisiklikVarmi = true;
                if (dtpckrBitisTarihi.Value != sabitOkulBilgi.SinavBitisTarihi) zamanBilgi.ZamandaDegisiklikVarmi = true;
               
                // if (zamanBilgi.ZamandaDegisiklikVarmi == true) zaman.KayitlariSil();
                //
                string durum = "";
                if (sabitOkulBilgi.Id > 0) durum = "Duzenle"; else durum = "Ekle";
                sabitOkulBilgi.OkulAdi1 = txtOkulAdi1.Text;
                sabitOkulBilgi.OkulAdi2 = txtOkulAdi2.Text;
                sabitOkulBilgi.Il = txtIl.Text;
                sabitOkulBilgi.Ilce = txtIlcesi.Text;
                sabitOkulBilgi.Tel = txtTelefonNumarasi.Text;
                sabitOkulBilgi.OgretimYili = txtOgretimYili.Text;
                sabitOkulBilgi.SinavDonemi = txtSinavDonemi.Text;
                sabitOkulBilgi.SinavBaslamaTarihi = dtpckrBaslangicTarihi.Value;
                sabitOkulBilgi.SinavBitisTarihi = dtpckrBitisTarihi.Value;
                sabitOkulBilgi.UcretGozcu = txtGozculukGoreviSaatUcreti.Text;
                sabitOkulBilgi.UcretKomisyon = txtKomisyonGoreviSaatUcreti.Text;
                sabitOkulBilgi.RaporBaslik1 = txtRapor1.Text;
                sabitOkulBilgi.RaporBaslik2 = txtRapor2.Text;
                sabitOkulBilgi.RaporBaslik3 = txtRapor3.Text;
                sabitOkulBilgi.RaporBaslik4 = "";
                sabitOkulBilgi.Sayi = txtSayi.Text;
                sabitOkulBilgi.Konu = txtKonu.Text;
                sabitOkulBilgi.Tarih = txtTarih.Text;
                sabitOkulBilgi.Dipnot = txtDipnot.Text;
                sabitOkulBilgi.Mudur = txtMudur.Text;
                sabitOkulBilgi.MaksimumSaat = txtGunlukMaksimumSinavSayisi.Text;
                sabitOkulBilgi.MaksimumOgrencininGirecegiSinav = txtOgrencininGunlukGirebilecegiSinavSayisi.Text;
                //kullanılmayan alan
                sabitOkulBilgi.Uay = "";
                sabitOkulBilgi.Utarih = DateTime.Now;
                if (durum == "Ekle")
                    sabitOkul.KayitEkle(sabitOkulBilgi);
                else
                    sabitOkul.KayitDegistir(sabitOkulBilgi);
            }

            if (sabitSaat.KayitlariGetir().Rows.Count <= 0)
            { buttonOklSnvSnvTarh_Click(sender, e); }

            if (zamanBilgi.ZamandaDegisiklikVarmi == true)
            {
                DateTime baslangicTarihi = dtpckrBaslangicTarihi.Value;
                DateTime bitisTarihi = dtpckrBitisTarihi.Value;
                TimeSpan fark = bitisTarihi - baslangicTarihi;
                for (int i = 0; i <= Convert.ToInt32(fark.TotalDays); i++)
                {
                    string a = baslangicTarihi.AddDays(i).ToShortDateString();
                    if (sabitTarih.KayitBul(a).Rows.Count <= 0) sabitTarih.KayitEkle(a);
                }
                MessageBox.Show("Zaman tablosunda değişklik oldu düzenleyin", "Uyarı !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOklSnvSnvTarh_Click(object sender, EventArgs e)
        {
            Saat Form_Saat = new Saat();
            Form_Saat.ShowDialog();
        }

        private void SabitBlgler_Activated(object sender, EventArgs e)
        {
            Kayitlari_Goster();
        }

        private void SabitBlgler_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (zamanBilgi.ZamandaDegisiklikVarmi == true)
            {
                MessageBox.Show("Zaman tablosunda değişklik oldu düzenleyin", "Uyarı !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
