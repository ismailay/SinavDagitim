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
    public partial class SinavIlanCizelgsi : Form
    {
        SabitOkulDB sabitOkul = new SabitOkulDB();
        public SinavIlanCizelgsi()
        {
            InitializeComponent();
        }

        private void buttonCks_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SinavIlanCizelgsi_Load(object sender, EventArgs e)
        {
            if (sabitOkul.KayitlariGetir().Rows.Count > 0)
            {
                txtBaslik.Text = sabitOkul.KayitlariGetir().Rows[0]["raporBaslik1"].ToString() + "\r\n" + sabitOkul.KayitlariGetir().Rows[0]["raporBaslik2"].ToString() + "\r\n" + sabitOkul.KayitlariGetir().Rows[0]["okulAdi1"].ToString() + "\r\n" + sabitOkul.KayitlariGetir().Rows[0]["okulAdi2"].ToString() + "\r\n" + sabitOkul.KayitlariGetir().Rows[0]["raporBaslik3"].ToString();
                txtDipNot.Text = sabitOkul.KayitlariGetir().Rows[0]["dipNot"].ToString();
            }
        }

        private void buttonRpr_Click(object sender, EventArgs e)
        {
            SinavIlanCizelgsiRapor Form_SinavIlanCizelgsiRapor = new SinavIlanCizelgsiRapor();
            Form_SinavIlanCizelgsiRapor.ShowDialog();
        }
    }
}
