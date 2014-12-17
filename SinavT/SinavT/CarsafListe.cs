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
using SinavT.Raporlar;

namespace SinavT
{
    public partial class CarsafListe : Form
    {
        DersDagitimDB dersDagitim = new DersDagitimDB();
        CarsafTabloDB carsafTablo = new CarsafTabloDB();
        SabitOkulDB sabitBilgiler = new SabitOkulDB();

        public CarsafListe()
        { InitializeComponent(); }

        private void CarsafListeTabloOlustur()
        {
            carsafTablo.TumKayitlariSil();
            OleDbDataReader dersler = dersDagitim.CarsafListeIcinKayitlariTekTekGetir();
            while (dersler.Read())
            {
                CarsafTabloInfo carsafTabloBilgi = new CarsafTabloInfo();
                carsafTabloBilgi.Tarih = dersler["Tarih"].ToString();
                carsafTabloBilgi.Saat = dersler["Saat"].ToString();
                carsafTabloBilgi.Oturum = dersler["Oturum"].ToString();
                carsafTabloBilgi.Ders = dersler["DersAdi"].ToString();
                carsafTabloBilgi.Sinif = dersler["Sinif"].ToString();
                carsafTabloBilgi.Sekli = dersler["Sekli"].ToString();
                carsafTabloBilgi.NobetciOgretmen = dersler["OgretmenAdi"].ToString();
                carsafTabloBilgi.NobetciMudurYardimcisi = dersler["MudurYardimciAdi"].ToString();
                carsafTabloBilgi.KomisyonUye = "";
                carsafTabloBilgi.GozcuUye = "";
                OleDbDataReader ogretmenler = dersDagitim.SeciliDerseAitOgretmenleriTekTekGetir(Convert.ToInt32(dersler["id"]));
                while (ogretmenler.Read())
                {
                    if (ogretmenler["gorevTuru"].ToString() == "Komisyon")
                        carsafTabloBilgi.KomisyonUye += " " + ogretmenler["sabitOgretmenAdi"].ToString() + ",";
                    else
                        carsafTabloBilgi.GozcuUye += " " + ogretmenler["sabitOgretmenAdi"].ToString() + ",";
                }
                ogretmenler.Close();
                //verileri CarsafTabloya Yaz
                carsafTablo.KayitEkle(carsafTabloBilgi);
            }
            dersler.Close();
        }

        private void RaporuGoster()
        {
            
            CarsafTabloRaporTasarim rapor = new CarsafTabloRaporTasarim();
            DataTable tablo1 = new DataTable("Dersler");
            DataTable tablo2 = new DataTable("SabitBilgiler");
            tablo1 = carsafTablo.KayitlariGetir();
            tablo2 = sabitBilgiler.RaporIcinKayitlariGetir();
            rapor.Database.Tables["Dersler"].SetDataSource((DataTable)tablo1);
            rapor.Database.Tables["SabitBilgiler"].SetDataSource((DataTable)tablo2);
            cryRptViewerCarsafListe.ReportSource = rapor;
        }

        private void CarsafListe_Load(object sender, EventArgs e)
        {
            CarsafListeTabloOlustur();
            RaporuGoster();
        }
    }
}
