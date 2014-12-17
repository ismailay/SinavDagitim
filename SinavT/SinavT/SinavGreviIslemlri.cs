using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Batl.DAL;

namespace SinavT
{
    public partial class SinavGreviIslemlri : Form
    {
        SabitOgretmenDB sabitOgretmen = new SabitOgretmenDB();
        public SinavGreviIslemlri()
        { InitializeComponent(); }
        private void aktif()
        {
            btnDuzenle.Enabled = false;
            dtGridOgretmenler.Enabled = false;
            buttonCks.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            groupBox1.Enabled = true;

        }

        private void pasif()
        {
            btnDuzenle.Enabled = true;
            dtGridOgretmenler.Enabled = true;
            buttonCks.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void YeniVerileriDuzenle()
        {
            OleDbDataReader bilgi1 = sabitOgretmen.KayitlariTekTekGetir();
            while (bilgi1.Read())
            {
                int OgretmenID = Convert.ToInt32(bilgi1["id"]);
                int OgrYeniKomisyonGorevi = 0;
                int OgrYeniGozcuGorevi = 0;
                DataTable dt = new DataTable();
                dt = sabitOgretmen.OgretmenGorevSayisi(OgretmenID, "Komisyon");
                if (dt.Rows.Count > 0)
                    OgrYeniKomisyonGorevi = Convert.ToInt32(dt.Rows[0][0]);
                dt = sabitOgretmen.OgretmenGorevSayisi(OgretmenID, "Gözcü");
                if (dt.Rows.Count > 0)
                    OgrYeniGozcuGorevi = Convert.ToInt32(dt.Rows[0][0]);
                sabitOgretmen.KayitDegistirYeniGorev(OgrYeniKomisyonGorevi, OgrYeniGozcuGorevi, OgretmenID);
            }
            bilgi1.Close();
        }

        private void KayitlariGoster()
        {
            dtGridOgretmenler.DataSource = sabitOgretmen.KayitlariGetir();
            if (dtGridOgretmenler.Rows.Count > 0)
            {
                txtEskiKomisyon.Text = dtGridOgretmenler.Rows[0].Cells["eskiKomisyonGorevi"].Value.ToString();
                txtEskiGozcu.Text = dtGridOgretmenler.Rows[0].Cells["eskiGozcuGorevi"].Value.ToString();
            }
        }

        private void SinavGreviIslemlri_Load(object sender, EventArgs e)
        {
            YeniVerileriDuzenle();
            KayitlariGoster();
        }

        private void dtGridOgretmenler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >0)
            {
                txtEskiKomisyon.Text = dtGridOgretmenler.Rows[e.RowIndex].Cells["eskiKomisyonGorevi"].Value.ToString();
                txtEskiGozcu.Text = dtGridOgretmenler.Rows[e.RowIndex].Cells["eskiGozcuGorevi"].Value.ToString();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dtGridOgretmenler.Rows.Count > 0)
            {
                aktif();
                txtEskiKomisyon.Focus();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            pasif();
            int komisyonGorevSayisi = Convert.ToInt32(txtEskiKomisyon.Text);
            int gozcuGorevSayisi = Convert.ToInt32(txtEskiGozcu.Text);
            int OgretmenID = Convert.ToInt32(dtGridOgretmenler.Rows[dtGridOgretmenler.CurrentCellAddress.Y].Cells["id"].Value);
            sabitOgretmen.KayitDegistirEskiGorev(komisyonGorevSayisi, gozcuGorevSayisi, OgretmenID);
            KayitlariGoster();

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        { pasif(); }

        private void buttonCks_Click(object sender, EventArgs e)
        { this.Close(); }

        private void txtEskiKomisyon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) == true || e.KeyChar == Convert.ToByte(Keys.Back)))
                e.KeyChar = '\0';
        }

        private void txtEskiGozcu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) == true || e.KeyChar == Convert.ToByte(Keys.Back)))
                e.KeyChar = '\0';
        }

        private void txtEskiKomisyon_Enter(object sender, EventArgs e)
        { txtEskiKomisyon.SelectAll(); }

        private void txtEskiGozcu_Enter(object sender, EventArgs e)
        { txtEskiGozcu.SelectAll(); }

        private void txtEskiKomisyon_Click(object sender, EventArgs e)
        { txtEskiKomisyon.SelectAll(); }

        private void txtEskiGozcu_Click(object sender, EventArgs e)
        { txtEskiGozcu.SelectAll(); }

    }
}
