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
using System.Collections;
using Batl.Info;

namespace SinavT
{
    public partial class UcretCizelgesi : Form
    {
        SabitTarihDB sabitTarih = new SabitTarihDB();
        DersDagitimOgretmenDB dersDagitimOgretmen = new DersDagitimOgretmenDB();
        UcretInfo ucretBilgi = new UcretInfo();
        UcretDB ucret = new UcretDB();
        SabitOkulDB sabitOkul = new SabitOkulDB();

        public UcretCizelgesi()
        { InitializeComponent(); }

        private void button2_Click(object sender, EventArgs e)
        { this.Close(); }

        private void lstAy_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void buttonCks_KeyUp(object sender, KeyEventArgs e)
        {
            lstAy_KeyUp(sender, e);
        }

        private void UcretCizelgesi_KeyUp(object sender, KeyEventArgs e)
        {
            lstAy_KeyUp(sender, e);
        }

        private void UcretCizelgesi_Load(object sender, EventArgs e)
        {
            lstAy.DataSource = sabitTarih.AyIsimleri();
            lstAy.ValueMember = "Numara";
            lstAy.DisplayMember = "Adi";
        }

        private void lstAy_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //kayitlari sil
                ucret.TumKayitlariSil();
                //komisyon ve gozculeri diziye at
                int[] komisyon = new int[31];
                int[] gozcu = new int[31];
                int numara = Convert.ToInt32(lstAy.SelectedValue);
                int GunNo;
                int tarId;
                int ogrId;
                string ogrAdi;
                string ogrBolum;
                string tarihAdi = lstAy.Text;
                int komisyonCarpan = Convert.ToInt32(sabitOkul.KayitlariGetir().Rows[0]["ucretKomisyon"]);
                int gozcuCarpan = Convert.ToInt32(sabitOkul.KayitlariGetir().Rows[0]["ucretGozcu"]);
                //sinavı olan öğretmen idleri
                OleDbDataReader bilgi1 = dersDagitimOgretmen.OgretmenleriGetirTekrarsiz();
                while (bilgi1.Read())
                {
                    //dizileri temizle
                    Array.Clear(komisyon, 0, 31);
                    Array.Clear(gozcu, 0, 31);
                    ogrId = (Convert.ToInt32(bilgi1["OgretmenId"]));
                    ogrAdi = bilgi1["adi"].ToString();
                    ogrBolum = bilgi1["bolum"].ToString();
                    //sinavı olan tarihler
                    OleDbDataReader bilgi2 = sabitTarih.UcretTablosuIcinTarihleriGetir(numara);
                    while (bilgi2.Read())
                    {
                        GunNo = Convert.ToDateTime(bilgi2["tarih"]).Day;
                        tarId = (Convert.ToInt32(bilgi2["id"]));
                        //komisyon sayisini getir
                        if (sabitTarih.UcretTablosuIcinGorevTurleriniGetir(numara, ogrId, tarId, "Komisyon").Rows.Count > 0)
                            komisyon[GunNo-1] = Convert.ToInt32(sabitTarih.UcretTablosuIcinGorevTurleriniGetir(numara, ogrId, tarId, "Komisyon").Rows[0][0].ToString()) * komisyonCarpan;
                        //gozcu sayisini getir
                        if (sabitTarih.UcretTablosuIcinGorevTurleriniGetir(numara, ogrId, tarId, "Gözcü").Rows.Count > 0)
                            gozcu[GunNo-1] = Convert.ToInt32(sabitTarih.UcretTablosuIcinGorevTurleriniGetir(numara, ogrId, tarId, "Gözcü").Rows[0][0].ToString()) * gozcuCarpan;
                    }
                    bilgi2.Close();

                    //verileri ucret tablosuna gonder
                    ucretBilgi.TarihAdi = tarihAdi.ToUpper();
                    ucretBilgi.Isim = ogrAdi;
                    ucretBilgi.Brans = ogrBolum;
                    ucretBilgi.K01 = komisyon[0];
                    ucretBilgi.K02 = komisyon[1];
                    ucretBilgi.K03 = komisyon[2];
                    ucretBilgi.K04 = komisyon[3];
                    ucretBilgi.K05 = komisyon[4];
                    ucretBilgi.K06 = komisyon[5];
                    ucretBilgi.K07 = komisyon[6];
                    ucretBilgi.K08 = komisyon[7];
                    ucretBilgi.K09 = komisyon[8];
                    ucretBilgi.K10 = komisyon[9];
                    ucretBilgi.K11 = komisyon[10];
                    ucretBilgi.K12 = komisyon[11];
                    ucretBilgi.K13 = komisyon[12];
                    ucretBilgi.K14 = komisyon[13];
                    ucretBilgi.K15 = komisyon[14];
                    ucretBilgi.K16 = komisyon[15];
                    ucretBilgi.K17 = komisyon[16];
                    ucretBilgi.K18 = komisyon[17];
                    ucretBilgi.K19 = komisyon[18];
                    ucretBilgi.K20 = komisyon[19];
                    ucretBilgi.K21 = komisyon[20];
                    ucretBilgi.K22 = komisyon[21];
                    ucretBilgi.K23 = komisyon[22];
                    ucretBilgi.K24 = komisyon[23];
                    ucretBilgi.K25 = komisyon[24];
                    ucretBilgi.K26 = komisyon[25];
                    ucretBilgi.K27 = komisyon[26];
                    ucretBilgi.K28 = komisyon[27];
                    ucretBilgi.K29 = komisyon[28];
                    ucretBilgi.K30 = komisyon[29];
                    ucretBilgi.K31 = komisyon[30];
                    ucretBilgi.G01 = gozcu[0];
                    ucretBilgi.G02 = gozcu[1];
                    ucretBilgi.G03 = gozcu[2];
                    ucretBilgi.G04 = gozcu[3];
                    ucretBilgi.G05 = gozcu[4];
                    ucretBilgi.G06 = gozcu[5];
                    ucretBilgi.G07 = gozcu[6];
                    ucretBilgi.G08 = gozcu[7];
                    ucretBilgi.G09 = gozcu[8];
                    ucretBilgi.G10 = gozcu[9];
                    ucretBilgi.G11 = gozcu[10];
                    ucretBilgi.G12 = gozcu[11];
                    ucretBilgi.G13 = gozcu[12];
                    ucretBilgi.G14 = gozcu[13];
                    ucretBilgi.G15 = gozcu[14];
                    ucretBilgi.G16 = gozcu[15];
                    ucretBilgi.G17 = gozcu[16];
                    ucretBilgi.G18 = gozcu[17];
                    ucretBilgi.G19 = gozcu[18];
                    ucretBilgi.G20 = gozcu[19];
                    ucretBilgi.G21 = gozcu[20];
                    ucretBilgi.G22 = gozcu[21];
                    ucretBilgi.G23 = gozcu[22];
                    ucretBilgi.G24 = gozcu[23];
                    ucretBilgi.G25 = gozcu[24];
                    ucretBilgi.G26 = gozcu[25];
                    ucretBilgi.G27 = gozcu[26];
                    ucretBilgi.G28 = gozcu[27];
                    ucretBilgi.G29 = gozcu[28];
                    ucretBilgi.G30 = gozcu[29];
                    ucretBilgi.G31 = gozcu[30];
                    int toplam = 0;
                    foreach (var i in komisyon)
                    {
                        toplam += i;
                    }
                    ucretBilgi.KomisyonToplam = toplam;
                    ucretBilgi.KomisyonSayi = toplam / komisyonCarpan;
                    toplam = 0;
                    foreach (var i in gozcu)
                    {
                        toplam += i;
                    }
                    ucretBilgi.GozcuToplam = toplam;

                    ucretBilgi.GozcuSayi = toplam / komisyonCarpan;
                    ucret.KayitEkle(ucretBilgi);

                }
                bilgi1.Close();
                //rapor getir
                UcretCizelgesiRapor Form_UcretCizelgesiRapor = new UcretCizelgesiRapor();
                Form_UcretCizelgesiRapor.ShowDialog();
                this.Close();
            }
            catch (Exception)
            { }

        }
    }
}
