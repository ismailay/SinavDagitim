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
    public partial class GorevDagilimiDers : Form
    {
        DersDagitimDB dersDagitim = new DersDagitimDB();
        SabitSinavSekliDB sabitSinavSekli = new SabitSinavSekliDB();

        public GorevDagilimiDers()
        { InitializeComponent(); }

        private void GorevDagilimiDers_Load(object sender, EventArgs e)
        {
            //Eklenecek Dersleri Listele
            dtGridDersler.DataSource = dersDagitim.DersEklenecekleriGetir();
            cmbSinavTuru.SelectedIndex = 0;
            //Sınav şeklini listele
            cmbSinavSekli.DataSource = sabitSinavSekli.KayitlariGetir();
            cmbSinavSekli.ValueMember = "id";
            cmbSinavSekli.DisplayMember = "adi";
        }

        private void dtGridDersler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GorevDagilimiElle.dersDagitimBilgi.DersId = Convert.ToInt32(dtGridDersler.Rows[dtGridDersler.CurrentCellAddress.Y].Cells["DersId"].Value);
            this.Close();
        }

        private void dtGridDersler_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GorevDagilimiElle.dersDagitimBilgi.DersId = -1;
                this.Close();
            }
        }

        private void GorevDagilimiDers_KeyUp(object sender, KeyEventArgs e)
        {
            dtGridDersler_KeyUp(sender, e);
        }

        private void GorevDagilimiDers_FormClosing(object sender, FormClosingEventArgs e)
        {
            GorevDagilimiElle.sinavTuru = cmbSinavTuru.Text;
            GorevDagilimiElle.sinavSekli = Convert.ToInt32(cmbSinavSekli.SelectedValue);
        }

        private void cmbSinavSekli_KeyUp(object sender, KeyEventArgs e)
        {
            dtGridDersler_KeyUp(sender, e);
        }
    }
}
