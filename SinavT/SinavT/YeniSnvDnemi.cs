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
using System.IO;
using System.Collections;

namespace SinavT
{
    public partial class YeniSnvDnemi : Form
    {
        SabitOkulDB sabitOkul = new SabitOkulDB();
        SabitOgretmenDB sabitOgretmen = new SabitOgretmenDB();
        SabitMudurYardimcilerDB sabitMudurYardimcilari = new SabitMudurYardimcilerDB();
        SabitSinavSekliDB sabitSinavSekli = new SabitSinavSekliDB();
        SabitSaatDB sabitSaat = new SabitSaatDB();
        SabitDersDB sabitDers = new SabitDersDB();
        SabitOgrenciDB sabitOgrenci = new SabitOgrenciDB();
        SabitSinifDB sabitSinif = new SabitSinifDB();
        SabitBolumDB sabitBolum = new SabitBolumDB();
        SabitDersGrupDB sabitDersGrubu = new SabitDersGrupDB();
        SabitTarihDB sabitTarih = new SabitTarihDB();

        DataTable dtOkul = new DataTable();
        DataTable dtOgretmen = new DataTable();
        DataTable dtMudurYrd = new DataTable();
        DataTable dtSinavTuru = new DataTable();
        DataTable dtSaat = new DataTable();
        DataTable dtOgrenci = new DataTable();
        DataTable dtSinif = new DataTable();
        DataTable dtDers = new DataTable();
        DataTable dtBolum = new DataTable();
        DataTable dtDersGrubu = new DataTable();

        SabitOkulInfo sabitOkulBilgi = new SabitOkulInfo();
        SabitMudurYardimcilarInfo sabitMudurYardimcilariBilgi = new SabitMudurYardimcilarInfo();
        SabitSinavSekliInfo sabitSinavSekliBilgi = new SabitSinavSekliInfo();
        SabitSaatInfo sabitSaatBilgi = new SabitSaatInfo();
        SabitOgretmenInfo sabitOgretmenBilgi = new SabitOgretmenInfo();
        SabitBolumInfo sabitBolumBilgi = new SabitBolumInfo();
        SabitDersGrupInfo sabitDersGrubuBilgi = new SabitDersGrupInfo();
        SabitDersInfo sabitDersBilgi = new SabitDersInfo();
        SabitSinifInfo sabitSinifBilgi = new SabitSinifInfo();
        SabitOgrenciInfo sabitOgrenciBilgi = new SabitOgrenciInfo();


        string DosyaAdi;

        public YeniSnvDnemi()
        { InitializeComponent(); }
        private void SinavDonemi()
        {
            cmbDonem1.Items.Clear();
            cmbDonem2.Items.Clear();
            cmbSinavSuresi.Items.Clear();
            int yil = Convert.ToInt32(DateTime.Now.Year);
            cmbDonem1.Items.Add((yil - 1).ToString());
            cmbDonem1.Items.Add(yil.ToString());
            cmbDonem2.Items.Add(yil.ToString());
            cmbDonem2.Items.Add((yil + 1).ToString());
            cmbDonem1.SelectedIndex = 0;
            cmbDonem2.SelectedIndex = 0;
            //sinav süresi
            for (int i = 1; i < 60; i++)
                cmbSinavSuresi.Items.Add(i);
            cmbSinavSuresi.SelectedIndex = 0;
            dtpckrBaslangicTarihi.Value = DateTime.Now.Date;
        }

        private void OncekiBilgileriKontrolEt()
        {
            if (sabitOkul.KayitlariGetir().Rows.Count == 0)
            {
                chckOkul.Enabled = false;
                button1_Cikis.Enabled = false;
            }
            else chckOkul.Enabled = true;

            if (sabitOgretmen.KayitlariGetir().Rows.Count > 0) chckOgretmen.Enabled = true;
            if (sabitMudurYardimcilari.KayitlariGetir().Rows.Count > 0) chckMudurYrd.Enabled = true;
            if (sabitSinavSekli.KayitlariGetir().Rows.Count > 0) chckSinavTuru.Enabled = true;
            if (sabitSaat.KayitlariGetir().Rows.Count > 0) chckSaat.Enabled = true;
            if (sabitOgrenci.KayitlariGetir().Rows.Count > 0) chckOgrenci.Enabled = true;
            if (sabitDers.KayitlariGetir().Rows.Count > 0) chckDers.Enabled = true;
        }


        private void YeniSnvDnemi_Load(object sender, EventArgs e)
        {
            SinavDonemi();
            if (File.Exists("App_Data\\sinav.mdb"))
                OncekiBilgileriKontrolEt();
        }

        private void button1_Cikis_Click(object sender, EventArgs e)
        { this.Close(); }

        private void cmbDonem1_SelectedValueChanged(object sender, EventArgs e)
        { cmbDonem2.SelectedIndex = cmbDonem1.SelectedIndex; }

        private void cmbSinavSuresi_SelectedIndexChanged(object sender, EventArgs e)
        { lblBitisTarihi.Text = dtpckrBaslangicTarihi.Value.Date.AddDays(Convert.ToDouble(cmbSinavSuresi.Text) - 1).Date.ToString(); }

        private void dtpckrBaslangicTarihi_ValueChanged(object sender, EventArgs e)
        { cmbSinavSuresi_SelectedIndexChanged(sender, e); }

        private void lstSaat1_DoubleClick(object sender, EventArgs e)
        {
            if (lstSaat1.Items.Count > 0)
            {
                lstSaat2.Items.Add(lstSaat1.Text);
                lstSaat1.Items.RemoveAt(lstSaat1.SelectedIndex);
            }
        }

        private void lstSaat2_DoubleClick(object sender, EventArgs e)
        {
            if (lstSaat2.Items.Count > 0)
            {
                lstSaat1.Items.Add(lstSaat2.Text);
                lstSaat2.Items.RemoveAt(lstSaat2.SelectedIndex);
            }
        }

        private void YedekAl()
        {

            DosyaAdi = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString();
            if (File.Exists("App_Data\\sinav.mdb"))
            {
                File.Copy("App_Data\\sinav.mdb", "App_Data\\yedek\\" + DosyaAdi + ".mdb");
                //veri tabanın yedeğini datatable yükle
                dtOkul = sabitOkul.KayitlariGetir(); 
                if (chckOgretmen.Checked == true)
                { dtOgretmen = sabitOgretmen.KayitlariGetir(); }
                if (chckMudurYrd.Checked == true)
                { dtMudurYrd = sabitMudurYardimcilari.KayitlariGetir(); }
                if (chckSinavTuru.Checked == true)
                { dtSinavTuru = sabitSinavSekli.KayitlariGetir(); }
                if (chckSaat.Checked == true)
                { dtSaat = sabitSaat.KayitlariGetir(); }
                if (chckOgrenci.Checked == true)
                {
                    dtOgrenci = sabitOgrenci.KayitlariGetir();
                    dtSinif = sabitSinif.KayitlariGetir();
                }
                if (chckDers.Checked == true)
                {
                    dtDers = sabitDers.KayitlariGetir();
                    dtBolum = sabitBolum.KayitlariGetir();
                    dtDersGrubu = sabitDersGrubu.KayitlariGetir();
                }

                File.Delete("App_Data\\sinav.mdb");
                File.Copy("App_Data\\yedek\\bos.mdb", "App_Data\\sinav.mdb");
                
            }
            else
            {
                File.Copy("App_Data\\yedek\\bos.mdb", "App_Data\\sinav.mdb");
            }
        }

        private void buttonDevam_Click(object sender, EventArgs e)
        {
            if (lstSaat2.Items.Count == 0 && chckSaat.Checked == false)
            {
                MessageBox.Show("Lütfen Sınav Saatlerini seçin...", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            YedekAl();
            //yedek al
            YedekDB yedek = new YedekDB();
            YedekInfo yedekBilgi = new YedekInfo();
            if (dtOkul.Rows.Count > 0)
            {
                yedekBilgi.Adi = "";
                yedekBilgi.BaslangicTarihi = Convert.ToDateTime(dtOkul.Rows[0]["sinavBaslamaTarihi"].ToString()).Date;
                yedekBilgi.BitisTarihi = Convert.ToDateTime(dtOkul.Rows[0]["sinavBitisTarihi"].ToString()).Date;
                yedekBilgi.DonemAdi = dtOkul.Rows[0]["sinavDonemi"].ToString();
                yedekBilgi.DonemYili = dtOkul.Rows[0]["ogretimYili"].ToString();
                yedekBilgi.DosyaAdi = DosyaAdi;
                yedekBilgi.KurumAdi = dtOkul.Rows[0]["okulAdi1"].ToString() + " " + dtOkul.Rows[0]["okulAdi2"].ToString();
                yedekBilgi.YedekSaat = DateTime.Now.ToShortTimeString();
                yedekBilgi.YedekTarihi = DateTime.Now.Date;
                yedek.KayitEkle(yedekBilgi);
            }
            //********

            if (chckOkul.Checked == true)
            {
                sabitOkulBilgi.OkulAdi1 = dtOkul.Rows[0]["OkulAdi1"].ToString();
                sabitOkulBilgi.OkulAdi2 = dtOkul.Rows[0]["OkulAdi2"].ToString();
                sabitOkulBilgi.Il = dtOkul.Rows[0]["il"].ToString();
                sabitOkulBilgi.Ilce = dtOkul.Rows[0]["ilce"].ToString();
                sabitOkulBilgi.Tel = dtOkul.Rows[0]["tel"].ToString();
                sabitOkulBilgi.OgretimYili = cmbDonem1.Text + "-" + cmbDonem2.Text;
                sabitOkulBilgi.SinavDonemi = dtOkul.Rows[0]["sinavDonemi"].ToString();
                sabitOkulBilgi.SinavBaslamaTarihi = dtpckrBaslangicTarihi.Value.Date;
                sabitOkulBilgi.SinavBitisTarihi = Convert.ToDateTime(lblBitisTarihi.Text).Date;
                sabitOkulBilgi.UcretGozcu = dtOkul.Rows[0]["ucretGozcu"].ToString();
                sabitOkulBilgi.UcretKomisyon = dtOkul.Rows[0]["ucretKomisyon"].ToString();
                sabitOkulBilgi.RaporBaslik1 = dtOkul.Rows[0]["raporBaslik1"].ToString();
                sabitOkulBilgi.RaporBaslik2 = dtOkul.Rows[0]["raporBaslik2"].ToString();
                sabitOkulBilgi.RaporBaslik3 = dtOkul.Rows[0]["raporBaslik3"].ToString();
                sabitOkulBilgi.RaporBaslik4 = dtOkul.Rows[0]["raporBaslik4"].ToString();
                sabitOkulBilgi.Sayi = dtOkul.Rows[0]["sayi"].ToString();
                sabitOkulBilgi.Konu = dtOkul.Rows[0]["konu"].ToString();
                sabitOkulBilgi.Tarih = dtOkul.Rows[0]["tarih"].ToString();
                sabitOkulBilgi.Dipnot = dtOkul.Rows[0]["dipnot"].ToString();
                sabitOkulBilgi.Mudur = dtOkul.Rows[0]["mudur"].ToString();
                sabitOkulBilgi.MaksimumSaat = dtOkul.Rows[0]["maksimumSaat"].ToString();
                sabitOkulBilgi.MaksimumOgrencininGirecegiSinav = dtOkul.Rows[0]["maksimumOgrencininGirecegiSinav"].ToString();
                //kullanılmayan alan
                sabitOkulBilgi.Uay = dtOkul.Rows[0]["Uay"].ToString();
                sabitOkulBilgi.Utarih = DateTime.Now;
                sabitOkul.KayitEkle(sabitOkulBilgi);
            }
            else
            {
                sabitOkulBilgi.OgretimYili = cmbDonem1.Text + "-" + cmbDonem2.Text;
                sabitOkulBilgi.SinavBaslamaTarihi = dtpckrBaslangicTarihi.Value.Date;
                sabitOkulBilgi.SinavBitisTarihi = Convert.ToDateTime(lblBitisTarihi.Text).Date;
                sabitOkul.KayitEkle(sabitOkulBilgi);
            }

            // tarih bölümünü ekle
            TimeSpan fark = sabitOkulBilgi.SinavBitisTarihi - sabitOkulBilgi.SinavBaslamaTarihi;
            for (int i = 0; i <= Convert.ToInt32(fark.TotalDays); i++)
            {
                string a = sabitOkulBilgi.SinavBaslamaTarihi.AddDays(i).ToShortDateString();
                sabitTarih.KayitEkle(a);
            }
            //***********************

            if (chckOgretmen.Checked == true)
            {
                foreach (DataRow dt in dtOgretmen.Rows)
                {
                    sabitOgretmenBilgi.Adi = dt["adi"].ToString();
                    sabitOgretmenBilgi.Bolum = dt["bolum"].ToString();
                    sabitOgretmenBilgi.Grup = dt["grup"].ToString();
                    sabitOgretmenBilgi.EskiKomisyonGorevi = Convert.ToInt32(dt["eskiKomisyonGorevi"]) + Convert.ToInt32(dt["yeniKomisyonGorevi"]);
                    sabitOgretmenBilgi.EskiGozcuGorevi = Convert.ToInt32(dt["eskiGozcuGorevi"]) + Convert.ToInt32(dt["yeniGozcuGorevi"]);
                    sabitOgretmenBilgi.YeniGozcuGorevi = 0;
                    sabitOgretmenBilgi.YeniKomisyonGorevi = 0;
                    sabitOgretmen.KayitEkle(sabitOgretmenBilgi);
                }
                dtOgretmen.Clear();
            }
            if (chckMudurYrd.Checked == true)
            {
                foreach (DataRow dt in dtMudurYrd.Rows)
                {
                    sabitMudurYardimcilariBilgi.Adi = dt["adi"].ToString();
                    sabitMudurYardimcilariBilgi.Unvan = dt["unvan"].ToString();
                    sabitMudurYardimcilari.KayitEkle(sabitMudurYardimcilariBilgi);
                }
                dtMudurYrd.Clear();
            }
            if (chckSinavTuru.Checked == true)
            {
                foreach (DataRow dt in dtSinavTuru.Rows)
                {
                    sabitSinavSekliBilgi.Adi = dt["adi"].ToString();
                    sabitSinavSekli.KayitEkle(sabitSinavSekliBilgi);
                }
                dtSinavTuru.Clear();
            }
            if (chckSaat.Checked == true)
            {
                foreach (DataRow dt in dtSaat.Rows)
                {
                    sabitSaatBilgi.Saat = dt["saat"].ToString();
                    sabitSaat.KayitEkle(sabitSaatBilgi);
                }
            }
            else
            {
                //satlari ekle
                for (int i = 0; i < lstSaat2.Items.Count; i++)
                {
                    sabitSaatBilgi.Saat = lstSaat2.Items[i].ToString();
                    sabitSaat.KayitEkle(sabitSaatBilgi);
                }
                dtSaat.Clear();
            }
            if (chckOgrenci.Checked == true)
            {
                int say = 0;
                string[] sinifDizi = new string[dtSinif.Rows.Count + 1];
                foreach (DataRow dt in dtSinif.Rows)
                {
                    say += 1;
                    sabitSinifBilgi.Adi = dt["adi"].ToString();
                    sinifDizi[say] = dt["id"].ToString();
                    sabitSinif.KayitEkle(sabitSinifBilgi);
                }
                dtSinif.Clear();
                foreach (DataRow dt in dtOgrenci.Rows)
                {
                    sabitOgrenciBilgi.Numara = dt["numara"].ToString();
                    sabitOgrenciBilgi.Sinif = Array.IndexOf(sinifDizi, dt["sinif"].ToString());
                    sabitOgrenciBilgi.Adsoyad = dt["adSoyad"].ToString();
                    sabitOgrenciBilgi.Ders = dt["ders"].ToString();
                    sabitOgrenciBilgi.Notu = dt["notu"].ToString();
                    sabitOgrenci.KayitEkle(sabitOgrenciBilgi);
                }
                dtOgrenci.Clear();
            }
            if (chckDers.Checked == true)
            {
                int say = 0;
                string[] bolumDizi = new string[dtBolum.Rows.Count + 1];
                string[] dersGrubuDizi = new string[dtDersGrubu.Rows.Count + 1];
                foreach (DataRow dt in dtBolum.Rows)
                {
                    say += 1;
                    sabitBolumBilgi.Ad = dt["ad"].ToString();
                    bolumDizi[say] = dt["id"].ToString();
                    sabitBolum.KayitEkle(sabitBolumBilgi);
                }
                dtBolum.Clear();
                say = 0;
                foreach (DataRow dt in dtDersGrubu.Rows)
                {
                    say += 1;
                    sabitDersGrubuBilgi.Grup = dt["grup"].ToString();
                    dersGrubuDizi[say] = dt["id"].ToString();
                    sabitDersGrubu.KayitEkle(sabitDersGrubuBilgi);
                }
                dtDersGrubu.Clear();
                foreach (DataRow dt in dtDers.Rows)
                {
                    sabitDersBilgi.Kodu = dt["kodu"].ToString();
                    sabitDersBilgi.Adi = dt["adi"].ToString();
                    sabitDersBilgi.Seviye = Array.IndexOf(dersGrubuDizi, dt["seviye"].ToString());
                    sabitDersBilgi.Sure = dt["sure"].ToString();
                    sabitDersBilgi.Grup = dt["sabitDers.grup"].ToString();
                    sabitDersBilgi.Bolum = Array.IndexOf(bolumDizi, dt["bolum"].ToString());
                    sabitDers.KayitEkle(sabitDersBilgi);
                }
                dtDers.Clear();
            }
            
            Application.OpenForms["AnaForm"].Controls["menu"].Enabled = true;
            this.Close();
        }
    }
}
