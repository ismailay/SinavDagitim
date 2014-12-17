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

namespace SinavT
{
    public partial class GorevDagilimKomisyon : Form
    {
        DersDagitimDB dersDagitim = new DersDagitimDB();
        DersDagitimOgretmenDB dersDagitimOgretmen = new DersDagitimOgretmenDB();
        DersDagitimOgretmenInfo dersDagitimOgretmenBilgi = new DersDagitimOgretmenInfo();

        public GorevDagilimKomisyon()
        { InitializeComponent(); }

        private void dtGridOgretmen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GorevDagilimiElle.dersDagitimOgretmenBilgi.OgretmenId = -1;
                this.Close();
            }
        }

        private void GorevDagilimKomisyon_Load(object sender, EventArgs e)
        {
            dtGridOgretmen.DataSource = dersDagitim.OgretmenleriGetir(GorevDagilimiElle.seciliTarih, GorevDagilimiElle.seciliSaat);
            lstKomisyon.DataSource = dersDagitim.KomisyonGetir(GorevDagilimiElle.seciliDersId);
            lstKomisyon.ValueMember = "dersDagitimOgretmenId";
            lstKomisyon.DisplayMember = "OgretmenAdi";
        }

        private void lstKomisyon_KeyUp(object sender, KeyEventArgs e)
        { dtGridOgretmen_KeyUp(sender, e); }

        private void GorevDagilimKomisyon_KeyUp(object sender, KeyEventArgs e)
        { dtGridOgretmen_KeyUp(sender, e); }

        private void dtGridOgretmen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGridOgretmen.Rows[dtGridOgretmen.CurrentCellAddress.Y].Cells["OgretmenId"].Value != null)
            {
                dersDagitimOgretmenBilgi.OgretmenId = Convert.ToInt32(dtGridOgretmen.Rows[dtGridOgretmen.CurrentCellAddress.Y].Cells["OgretmenId"].Value);
                dersDagitimOgretmenBilgi.DersDagitimId = GorevDagilimiElle.seciliDersId;
                dersDagitimOgretmenBilgi.GorevTuru = "Komisyon";
                dersDagitimOgretmen.KayitEkle(dersDagitimOgretmenBilgi);
                GorevDagilimKomisyon_Load(sender, e);
            }
        }

        private void lstKomisyon_DoubleClick(object sender, EventArgs e)
        {
            if (lstKomisyon.SelectedIndex.ToString() != null)
            {
                dersDagitimOgretmen.KayitSil(Convert.ToInt32(lstKomisyon.SelectedValue));
                GorevDagilimKomisyon_Load(sender, e);
            }
        }

        private void buttonCks_Click(object sender, EventArgs e)
        {
            GorevDagilimiElle.dersDagitimOgretmenBilgi.OgretmenId = -1;
            this.Close();
        }
    }
}
