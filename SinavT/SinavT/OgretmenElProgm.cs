using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Batl.DAL;

namespace SinavT
{
    public partial class OgretmenElProgm : Form
    {
        DersDagitimOgretmenDB dersDagitimOgretmen = new DersDagitimOgretmenDB();
        DersDagitimDB dersDagitim = new DersDagitimDB();

        public static int OgretmenIdNumara;
        public OgretmenElProgm()
        { InitializeComponent(); }

        private void buttonCks_Click(object sender, EventArgs e)
        { this.Close(); }

        private void OgretmenKayitlariniGoster()
        {
            lstOgretmenler.DataSource = null;
            try
            {
                lstOgretmenler.DataSource = dersDagitimOgretmen.KayitlariGetir();
                lstOgretmenler.ValueMember = "OgretmenId";
                lstOgretmenler.DisplayMember = "OgretmenAdi";
            }
            catch (Exception)
            { }
        }

        private void DersKayitlariniGoster()
        {
            dtGridDersler.DataSource = null;
            try
            {
                if (lstOgretmenler.Items.Count > 0)
                {
                    OgretmenIdNumara = Convert.ToInt32(lstOgretmenler.SelectedValue);
                    dtGridDersler.DataSource = dersDagitim.SeciliDersleriGetir(Convert.ToInt32(lstOgretmenler.SelectedValue));
                    dtGridDersler.AutoGenerateColumns = false;
                    if (dtGridDersler.Rows.Count == 0)
                    {
                        OgretmenKayitlariniGoster();
                        DersKayitlariniGoster();
                    }
                }
                //  dataGridViewOgrnci.DataSource = sabitOgrenci.KayitlariGetir();
            }
            catch (Exception)
            { }
        }

        private void OgretmenElProgm_Load(object sender, EventArgs e)
        {
            OgretmenKayitlariniGoster();
            DersKayitlariniGoster();
        }

        private void lstOgretmenler_Click(object sender, EventArgs e)
        {
            DersKayitlariniGoster();
        }

        private void buttonRpr_Click(object sender, EventArgs e)
        {
            OgretmenElProgramiRapor FormOgretmenElProgramiRapor = new OgretmenElProgramiRapor();
            FormOgretmenElProgramiRapor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


    }
}
