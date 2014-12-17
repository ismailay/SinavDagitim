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
    public partial class ImzaCetveliRapor : Form
    {
        SabitOkulDB sabitBilgiler = new SabitOkulDB();
        DersDagitimOgretmenDB dersDagitimOgretmen = new DersDagitimOgretmenDB();
        public ImzaCetveliRapor()
        {
            InitializeComponent();
        }

        private void ImzaCetveliRapor_Load(object sender, EventArgs e)
        {
            ImzaCetveliRaporTasarim rapor = new ImzaCetveliRaporTasarim();
            DataTable tablo1 = new DataTable("Dersler");
            DataTable tablo2 = new DataTable("SabitBilgiler");
            tablo1 = dersDagitimOgretmen.ImzaCetveliRaporIcinKayitlariGetir(ImzaCetveli.tarihIdNumarasi);
            tablo2 = sabitBilgiler.RaporIcinKayitlariGetir();
            rapor.Database.Tables["Dersler"].SetDataSource((DataTable)tablo1);
            rapor.Database.Tables["SabitBilgiler"].SetDataSource((DataTable)tablo2);
            cryRptViewerImzaCetveli.ReportSource = rapor;
        }
    }
}
