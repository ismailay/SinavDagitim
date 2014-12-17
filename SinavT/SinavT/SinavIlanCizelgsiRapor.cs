using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SinavT.Raporlar;
using Batl.DAL;

namespace SinavT
{
    public partial class SinavIlanCizelgsiRapor : Form
    {
        SabitOkulDB sabitBilgiler = new SabitOkulDB();
        DersDagitimDB dersDagitim = new DersDagitimDB();
        public SinavIlanCizelgsiRapor()
        {
            InitializeComponent();
        }

        private void SinavIlanCizelgsiRapor_Load(object sender, EventArgs e)
        {
            SinavIlanCizelgesiRaporTasarim rapor = new SinavIlanCizelgesiRaporTasarim();
            DataTable tablo1 = new DataTable("Dersler");
            DataTable tablo2 = new DataTable("SabitBilgiler");
            tablo1 = dersDagitim.SinavIlanCizelgesiRapor();
            tablo2 = sabitBilgiler.RaporIcinKayitlariGetir();
            rapor.Database.Tables["Dersler"].SetDataSource((DataTable)tablo1);
            rapor.Database.Tables["SabitBilgiler"].SetDataSource((DataTable)tablo2);
            cryRptViewerSinavIlanCizelgsi.ReportSource = rapor;
        }
    }
}
