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
    public partial class UcretCizelgesiRapor : Form
    {
        SabitOkulDB sabitBilgiler = new SabitOkulDB();
        UcretDB ucret = new UcretDB();
        public UcretCizelgesiRapor()
        {
            InitializeComponent();
        }

        private void UcretCizelgesiRapor_Load(object sender, EventArgs e)
        {
            UcretCizelgesiRaporTasarim rapor = new UcretCizelgesiRaporTasarim();
            DataTable tablo1 = new DataTable("ucret");
            DataTable tablo2 = new DataTable("SabitBilgiler");
            tablo1 = ucret.KayitlariGetir();
            tablo2 = sabitBilgiler.RaporIcinKayitlariGetir();
            rapor.Database.Tables["ucret"].SetDataSource((DataTable)tablo1);
            rapor.Database.Tables["SabitBilgiler"].SetDataSource((DataTable)tablo2);
            cryRptViewerUcretCizelgesi.ReportSource = rapor;
        }
    }
}
