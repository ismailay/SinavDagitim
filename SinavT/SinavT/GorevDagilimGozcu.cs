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
    public partial class GorevDagilimGozcu : Form
    {
        DersDagitimDB dersDagitim = new DersDagitimDB();
        DersDagitimOgretmenDB dersDagitimOgretmen = new DersDagitimOgretmenDB();
        DersDagitimOgretmenInfo dersDagitimOgretmenBilgi = new DersDagitimOgretmenInfo();

        public GorevDagilimGozcu()
        { InitializeComponent(); }

        private void dtGridOgretmen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GorevDagilimiElle.dersDagitimOgretmenBilgi.OgretmenId = -1;
                this.Close();
            }
        }

        private void GorevDagilimGozcu_Load(object sender, EventArgs e)
        {
            dtGridOgretmen.DataSource = dersDagitim.OgretmenleriGetir(GorevDagilimiElle.seciliTarih, GorevDagilimiElle.seciliSaat);
            lstGozetmen.DataSource = dersDagitim.GozcuGetir(GorevDagilimiElle.seciliDersId);
            lstGozetmen.ValueMember = "dersDagitimOgretmenId";
            lstGozetmen.DisplayMember = "OgretmenAdi";
        }

        private void lstGozetmen_KeyUp(object sender, KeyEventArgs e)
        { dtGridOgretmen_KeyUp(sender, e); }

        private void GorevDagilimGozcu_KeyUp(object sender, KeyEventArgs e)
        { dtGridOgretmen_KeyUp(sender, e); }

        private void dtGridOgretmen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGridOgretmen.Rows[dtGridOgretmen.CurrentCellAddress.Y].Cells["OgretmenId"].Value != null)
            {
                dersDagitimOgretmenBilgi.OgretmenId = Convert.ToInt32(dtGridOgretmen.Rows[dtGridOgretmen.CurrentCellAddress.Y].Cells["OgretmenId"].Value);
                dersDagitimOgretmenBilgi.DersDagitimId = GorevDagilimiElle.seciliDersId;
                dersDagitimOgretmenBilgi.GorevTuru = "Gözcü";
                dersDagitimOgretmen.KayitEkle(dersDagitimOgretmenBilgi);
                GorevDagilimGozcu_Load(sender, e);
            }
        }

        private void lstGozetmen_DoubleClick(object sender, EventArgs e)
        {
            if (lstGozetmen.SelectedIndex.ToString() != null)
            {
                dersDagitimOgretmen.KayitSil(Convert.ToInt32(lstGozetmen.SelectedValue));
                GorevDagilimGozcu_Load(sender, e);
            }
        }

        private void buttonCks_Click(object sender, EventArgs e)
        {
            GorevDagilimiElle.dersDagitimOgretmenBilgi.OgretmenId = -1;
            this.Close();
        }
    }
}
