using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Batl.DAL;
using System.IO;

namespace SinavT
{
    public partial class AnaForm : Form
    {
        public void AcikKontrol(Form kontrol)
        {
            bool durum = false;
            foreach (Form mvu in this.MdiChildren)
            {

                if (mvu.Text == kontrol.Text)
                {
                    durum = true;
                    mvu.Activate();
                    mvu.WindowState = FormWindowState.Maximized;
                    MessageBox.Show(mvu.Text + " Formu Açık Durumda !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else mvu.Close();

            }
            if (durum == false)
            {
                kontrol.MdiParent = this;
                kontrol.Show();
                kontrol.Left = 0;
                kontrol.Top = 0;
                kontrol.WindowState = FormWindowState.Maximized;
            }
        }

        public AnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool dosyaDurumu = true;
            if (!File.Exists("App_Data\\sinav.mdb"))
                dosyaDurumu = false;
            else
            {
                SabitOkulDB sabitOkul = new SabitOkulDB();
                if (sabitOkul.KayitlariGetir().Rows.Count == 0)
                    dosyaDurumu = false;
            }
            if (dosyaDurumu == false)
            {
                menu.Enabled = false;
                YeniSnvDnemi Form_YeniSnvDonemi = new YeniSnvDnemi();
                AcikKontrol(Form_YeniSnvDonemi);
            }
            //zmlyci_trh_saat.Start();
        }

        // private void zmlyci_trh_saat_Tick(object sender, EventArgs e)
        // {
        //text_tarh_saat.Text = DateTime.Now.ToString();
        // }

        private void hakkndaMenItem_Click(object sender, EventArgs e)
        {
            Hakkinda Form_HakkindaForm = new Hakkinda();
            Form_HakkindaForm.ShowDialog();
        }

        private void cikisAltMenItem_Click(object sender, EventArgs e)
        { Close(); }

        private void yenSnavDnemiAltMenItem_Click(object sender, EventArgs e)
        {
            YeniSnvDnemi Form_YeniSnvDonemi = new YeniSnvDnemi();
            AcikKontrol(Form_YeniSnvDonemi);
        }

        private void sınavGrevislmAltMenItem_Click(object sender, EventArgs e)
        {
            SinavGreviIslemlri Form_SinavGreviIslemlri = new SinavGreviIslemlri();
            AcikKontrol(Form_SinavGreviIslemlri);
        }

        private void yedekAltMenItem_Click(object sender, EventArgs e)
        {
            YedkAlma Form_YedkAlma = new YedkAlma();
            AcikKontrol(Form_YedkAlma);
        }

        private void sabitBlglerAltMenItem_Click(object sender, EventArgs e)
        {
            SabitBlgler Form_SabitBlgler = new SabitBlgler();
            AcikKontrol(Form_SabitBlgler);
        }

        private void ogrtmenAltMenItem_Click(object sender, EventArgs e)
        {
            Ogretmen Form_Ogretmen = new Ogretmen();
            AcikKontrol(Form_Ogretmen);
        }

        private void dersAltMenItem_Click(object sender, EventArgs e)
        {
            Ders Form_Ders = new Ders();
            AcikKontrol(Form_Ders);
        }

        private void ogrnciAltMenItem_Click(object sender, EventArgs e)
        {
            Ogrnci Form_Ogrnci = new Ogrnci();
            AcikKontrol(Form_Ogrnci);
        }

        private void zamnCizlgeAltMenItem_Click(object sender, EventArgs e)
        {
            ZamanCizelgesi Form_ZamnCizelgsi = new ZamanCizelgesi();
            AcikKontrol(Form_ZamnCizelgsi);
        }

        private void grevDagtimAltMenItem_Click(object sender, EventArgs e)
        {
            GorevDagilimiElle Form_GorevDagilimiElle = new GorevDagilimiElle();
            AcikKontrol(Form_GorevDagilimiElle);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GorevDagilimiOtomatik Form_GorevDagilimiOtomatik = new GorevDagilimiOtomatik();
            AcikKontrol(Form_GorevDagilimiOtomatik);
        }

        private void nobtciOgrtmnAltMenItem_Click(object sender, EventArgs e)
        {
            Nobetc_Ogretmen Form_Nobetc_Ogretmen = new Nobetc_Ogretmen();
            AcikKontrol(Form_Nobetc_Ogretmen);
        }

        private void grevIptlAltMenItem_Click(object sender, EventArgs e)
        {
            Gorev_Iptl Form_Gorev_Iptl = new Gorev_Iptl();
            AcikKontrol(Form_Gorev_Iptl);
        }

        private void sinavIptlAltMenItem_Click(object sender, EventArgs e)
        {
            Sinav_Iptl Form_Sinav_Iptl = new Sinav_Iptl();
            AcikKontrol(Form_Sinav_Iptl);
        }

        private void sinvDegisklikAltMenItem_Click(object sender, EventArgs e)
        {
            SinavDegsklik Form_SinavDegsklik = new SinavDegsklik();
            AcikKontrol(Form_SinavDegsklik);
        }

        private void ogrtmenElProAltMenItem_Click(object sender, EventArgs e)
        {
            OgretmenElProgm Form_OgretmenElProgm = new OgretmenElProgm();
            AcikKontrol(Form_OgretmenElProgm);
        }

        private void sinvIlanAltMenItem_Click(object sender, EventArgs e)
        {
            SinavIlanCizelgsi Form_SinavIlanCizelgsi = new SinavIlanCizelgsi();
            AcikKontrol(Form_SinavIlanCizelgsi);
        }

        private void imzaCizgsAltMenItem_Click(object sender, EventArgs e)
        {
            ImzaCetveli Form_ImzaCetveli = new ImzaCetveli();
            AcikKontrol(Form_ImzaCetveli);
        }

        private void ucretCzgsiAltMenItem_Click(object sender, EventArgs e)
        {
            UcretCizelgesi Form_UcretCizelgesi = new UcretCizelgesi();
            Form_UcretCizelgesi.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SinifBilgileri Form_SinifBilgileri = new SinifBilgileri();
            AcikKontrol(Form_SinifBilgileri);
        }

        private void sinvaGrmesiGrknAltMenItem_Click(object sender, EventArgs e)
        {
            SinavaGirmesiGerekenlerRapor Form_SinavaGirmesiGerekenlerRapor = new SinavaGirmesiGerekenlerRapor();
            Form_SinavaGirmesiGerekenlerRapor.ShowDialog();
            /*
            MessageBox.Show("Sinava_Grmesi_Grken_Report", "Sınava Girmesi Gerekenler", MessageBoxButtons.OK, MessageBoxIcon.Information);
             * */
        }

        private void carsafLsteAltMenItem_Click(object sender, EventArgs e)
        {
            CarsafListe Form_CarsafListe = new CarsafListe();
            Form_CarsafListe.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OgrenciDersAtama Form_OgrenciDersAtama = new OgrenciDersAtama();
            AcikKontrol(Form_OgrenciDersAtama);
        }
    }
}
