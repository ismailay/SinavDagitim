using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Batl.DAL;
using SinavT.Raporlar;

namespace SinavT
{
    public partial class SinavaGirmesiGerekenlerRapor : Form
    {
        SabitOkulDB sabitBilgiler = new SabitOkulDB();
        DersDagitimDB dersDagitim = new DersDagitimDB();
        public SinavaGirmesiGerekenlerRapor()
        { InitializeComponent(); }

        private void SinavaGirmesiGerekenlerRapor_Load(object sender, EventArgs e)
        {
            SinavaGirmesiGerekenlerRaporTasarim rapor = new SinavaGirmesiGerekenlerRaporTasarim();
            // CrystalReport1 rapor = new CrystalReport1();
            DataTable tablo1 = new DataTable("Ogrenciler");
            DataTable tablo2 = new DataTable("SabitBilgiler");
            tablo1 = dersDagitim.SinavaGirmesiGerekenlerRapor();
            tablo2 = sabitBilgiler.RaporIcinKayitlariGetir();
            rapor.Database.Tables["Ogrenciler"].SetDataSource((DataTable)tablo1);
            rapor.Database.Tables["SabitBilgiler"].SetDataSource((DataTable)tablo2);
            cryRptViewerSinavaGirmesiGerekenler.ReportSource = rapor;
        }
    }
}
