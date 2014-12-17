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
    public partial class OgretmenElProgramiRapor : Form
    {
        DersDagitimDB dersDagitim = new DersDagitimDB();
        SabitOkulDB sabitBilgiler = new SabitOkulDB();

        public OgretmenElProgramiRapor()
        { InitializeComponent(); }

        private void OgretmenElProgramiRapor_Load(object sender, EventArgs e)
        {
            OgretmenElProgramiRaporTasarim rapor = new OgretmenElProgramiRaporTasarim();
            DataTable tablo1 = new DataTable("Dersler");
            DataTable tablo2 = new DataTable("SabitBilgiler");
            tablo1 = dersDagitim.OgretmenElPropgramiRapor(OgretmenElProgm.OgretmenIdNumara);
            tablo2 = sabitBilgiler.RaporIcinKayitlariGetir();
            rapor.Database.Tables["Dersler"].SetDataSource((DataTable)tablo1);
            rapor.Database.Tables["SabitBilgiler"].SetDataSource((DataTable)tablo2);
            cryRptViewerOgretmenElProgrami.ReportSource = rapor;
        }
    }
}
