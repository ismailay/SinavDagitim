using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Batl.DAL;
using Batl.Info;
using System.Data.OleDb;

namespace SinavT
{
    public partial class SinavDegsklik : Form
    {
        DersDagitimDB dersDagitim = new DersDagitimDB();
        DersDagitimInfo dersDagitimBilgi = new DersDagitimInfo();
        SabitTarihDB sabitTarih = new SabitTarihDB();
        SabitSaatDB sabitSaat = new SabitSaatDB();
        SabitSinavSekliDB sabitSinavSekli = new SabitSinavSekliDB();
        SabitOkulDB sabitOkul = new SabitOkulDB();
        SabitOkulInfo sabitOkulBilgi = new SabitOkulInfo();

        public SinavDegsklik()
        { InitializeComponent(); }

        private void buttonCks_Click(object sender, EventArgs e)
        { this.Close(); }

        private void DersKayitlariniGoster()
        {
            dtGridDersler.DataSource = dersDagitim.KayitlariSinavDegistirIcinGetir();
            // dtGridDersler.AutoGenerateColumns = false;
            if (dtGridDersler.Rows.Count > 0)
            {
                cmbTarih.DataSource = sabitTarih.KayitlariGetir();
                cmbTarih.ValueMember = "id";
                cmbTarih.DisplayMember = "tarih";
                cmbSaat.DataSource = sabitSaat.KayitlariGetir();
                cmbSaat.ValueMember = "id";
                cmbSaat.DisplayMember = "saat";
                cmbSinavSekli.DataSource = sabitSinavSekli.KayitlariGetir();
                cmbSinavSekli.ValueMember = "id";
                cmbSinavSekli.DisplayMember = "adi";
                cmbSaat.SelectedIndex = 0;
                btnDuzenle.Enabled = true;
                sabitOkulBilgi = sabitOkul.KayitGetir(Convert.ToInt32(sabitOkul.KayitlariGetir().Rows[0][0]));
                cmbOturum.Items.Clear();
                for (int i = 0; i < Convert.ToInt32(sabitOkulBilgi.MaksimumSaat); i++)
                    cmbOturum.Items.Add(i + 1);
                cmbOturum.SelectedIndex = 0;
            }
        }

        private void combolariDoldur()
        {
            if (dtGridDersler.Rows.Count > 0)
            {
                cmbTarih.SelectedValue = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["TarihId"].Value);
                cmbSaat.SelectedValue = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["SaatId"].Value);
                cmbSinavTuru.Text = dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["SinavTuru"].Value.ToString();
                cmbSinavSekli.SelectedValue = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["sabitSinavSekliId"].Value);
                cmbOturum.Text = dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["Oturum"].Value.ToString();
            }
        }
        private void SinavDegsklik_Load(object sender, EventArgs e)
        {
            DersKayitlariniGoster();
            combolariDoldur();
        }

        private void dtGridDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            combolariDoldur();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (rdBtnTarih.Checked)
            {
                cmbTarih.DataSource = null;
                cmbTarih.Items.Clear();
                int oturum = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["Oturum"].Value);
                int saatId = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["SaatId"].Value);
                bool ekle = true;
                OleDbDataReader sabitTarihler = sabitTarih.KayitlariTekTekGetir();
                while (sabitTarihler.Read())
                {
                    ekle = true;
                    OleDbDataReader tarihler = dersDagitim.SinavDegisiklikIcinTarihleriGetir(oturum, saatId);
                    while (tarihler.Read())
                        if (sabitTarihler["tarih"].ToString() == tarihler["tarih"].ToString()) ekle = false;
                    tarihler.Close();
                    if (ekle == true) cmbTarih.Items.Add(sabitTarihler["tarih"]);

                }
                sabitTarihler.Close();
                cmbTarih.Items.Add(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["Tarih"].Value).ToString();
                cmbTarih.Text = dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["Tarih"].Value.ToString();
                cmbTarih.Enabled = true;
            }
            if (rdBtnSaat.Checked)
            {
                cmbSaat.DataSource = null;
                cmbSaat.Items.Clear();
                int oturum = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["Oturum"].Value);
                int tarihId = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["TarihId"].Value);
                bool ekle = true;
                OleDbDataReader sabitSaatler = sabitSaat.KayitlariTekTekGetir();
                while (sabitSaatler.Read())
                {
                    ekle = true;
                    OleDbDataReader saatler = dersDagitim.SinavDegisiklikIcinSaatleriGetir(oturum, tarihId);
                    while (saatler.Read())
                        if (sabitSaatler["saat"].ToString() == saatler["saat"].ToString()) ekle = false;
                    saatler.Close();
                    if (ekle == true) cmbSaat.Items.Add(sabitSaatler["saat"]);

                }
                sabitSaatler.Close();
                cmbSaat.Items.Add(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["Saat"].Value).ToString();
                cmbSaat.Text = dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["Saat"].Value.ToString();
                cmbSaat.Enabled = true;
            }
            if (rdBtnOturum.Checked)
            {
                sabitOkulBilgi = sabitOkul.KayitGetir(Convert.ToInt32(sabitOkul.KayitlariGetir().Rows[0][0]));
                cmbOturum.Items.Clear();
                int tarihId = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["TarihId"].Value);
                int saatId = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["SaatId"].Value);
                bool ekle = true;
                for (int i = 1; i <= Convert.ToInt32(sabitOkulBilgi.MaksimumSaat); i++)
                {
                    ekle = true;
                    OleDbDataReader oturumlar = dersDagitim.SinavDegisiklikIcinOturumlariGetir(tarihId, saatId);
                    while (oturumlar.Read())
                    {
                        if (i == Convert.ToInt32(oturumlar["oturum"])) ekle = false;
                    }
                    oturumlar.Close();
                    if (ekle == true) cmbOturum.Items.Add(i);
                }
                cmbOturum.Items.Add(Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["Oturum"].Value));
                cmbOturum.Text = dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["Oturum"].Value.ToString();
                cmbOturum.Enabled = true;

            }
            rdBtnTarih.Enabled = false;
            rdBtnSaat.Enabled = false;
            rdBtnOturum.Enabled = false;
            cmbSinavTuru.Enabled = true;
            cmbSinavSekli.Enabled = true;

            btnDuzenle.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            buttonCks.Enabled = false;
            dtGridDersler.Enabled = false;
        }
        private void pasifet()
        {
            rdBtnTarih.Enabled = true;
            rdBtnSaat.Enabled = true;
            rdBtnOturum.Enabled = true;
            cmbTarih.Enabled = false;
            cmbSaat.Enabled = false;
            cmbOturum.Enabled = false;
            cmbSinavTuru.Enabled = false;
            cmbSinavSekli.Enabled = false;
            btnDuzenle.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            buttonCks.Enabled = true;
            dtGridDersler.Enabled = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            dersDagitimBilgi.Id = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["DersDagitimId"].Value);
            dersDagitimBilgi.DersId = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["DersId"].Value);
            dersDagitimBilgi.TarihId = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["TarihId"].Value);
            dersDagitimBilgi.SaatId = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["SaatId"].Value);
            dersDagitimBilgi.Oturum = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["Oturum"].Value);
            dersDagitimBilgi.Turu = cmbSinavTuru.Text;
            dersDagitimBilgi.Sekli = Convert.ToInt32(cmbSinavSekli.SelectedValue);
            if (rdBtnTarih.Checked)
            {
                int id = Convert.ToInt32(sabitTarih.KayitBul(cmbTarih.Text).Rows[0]["id"]);
                if (id > 0) dersDagitimBilgi.TarihId = id;
            }
            if (rdBtnSaat.Checked)
            {
                int id = Convert.ToInt32(sabitSaat.KayitBul(cmbSaat.Text).Rows[0]["id"]);
                if (id > 0) dersDagitimBilgi.SaatId = Convert.ToInt32(id);
            }
            if (rdBtnOturum.Checked)
            {
                dersDagitimBilgi.Oturum = Convert.ToInt32(cmbOturum.Text);
            }
            dersDagitim.KayitDegistir(dersDagitimBilgi);
            DersKayitlariniGoster();
            pasifet();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            pasifet();
        }
    }
}
