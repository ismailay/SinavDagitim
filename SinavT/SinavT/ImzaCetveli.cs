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
    public partial class ImzaCetveli : Form
    {
        SabitTarihDB sabitTarih = new SabitTarihDB();
        DersDagitimOgretmenDB dersDagitimOgretmen = new DersDagitimOgretmenDB();
        public static int tarihIdNumarasi;
        public static string tarihAdi;

        public ImzaCetveli()
        { InitializeComponent(); }

        private void buttonCks_Click(object sender, EventArgs e)
        { this.Close(); }

        private void TarihleriGoster()
        {
            lstTarih.DataSource = sabitTarih.KayitlariGetir();
            lstTarih.ValueMember = "id";
            lstTarih.DisplayMember = "tarih";
        }

        private void OgretmenKayitlariniGoster()
        {
            dtGridOgretmenler.DataSource = null;
            try
            {
                if (lstTarih.Items.Count > 0)
                {
                    tarihIdNumarasi = Convert.ToInt32(lstTarih.SelectedValue);
                    tarihAdi = lstTarih.Text;
                    dtGridOgretmenler.DataSource = dersDagitimOgretmen.ImzaCetveliIcinKayitlariGetir(Convert.ToInt32(lstTarih.SelectedValue));
                    dtGridOgretmenler.AutoGenerateColumns = false;
                }
            }
            catch (Exception)
            { }
        }

        private void ImzaCetveli_Load(object sender, EventArgs e)
        {
            TarihleriGoster();
            OgretmenKayitlariniGoster();
        }

        private void lstTarih_Click(object sender, EventArgs e)
        {
            OgretmenKayitlariniGoster();
        }

        private void buttonRpr_Click(object sender, EventArgs e)
        {
            ImzaCetveliRapor form_ImzaCetveliRapor = new ImzaCetveliRapor();
            form_ImzaCetveliRapor.ShowDialog();
        }
    }
}
