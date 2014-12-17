using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Batl.Info;
using Batl.DAL;
using System.Data.OleDb;

namespace SinavT
{
    public partial class Saat : Form
    {
        SabitSaatDB sabitSaat = new SabitSaatDB();
        SabitSaatInfo sabitSaatBilgi = new SabitSaatInfo();
        ZamanInfo zamanBilgi = new ZamanInfo();
        public Saat()
        { InitializeComponent(); }

        private void buttonCks_Click(object sender, EventArgs e)
        { this.Close(); }
        private void Kayitlari_Goster()
        {
            try
            {
                dataGridSaat.DataSource = sabitSaat.KayitlariGetir();
                //Veri tabanına kaydedilmiş saatleri cmbSaat içirisinden sil
                OleDbDataReader saatlar = sabitSaat.KayitlariTekTekGetir();
                while (saatlar.Read())
                {
                    int silinecekKayitNo = cmbSaat.FindStringExact(saatlar[0].ToString());
                    if (silinecekKayitNo > -1) cmbSaat.Items.RemoveAt(silinecekKayitNo);
                }
                saatlar.Close();
                cmbSaat.SelectedIndex = 0;
            }
            catch (Exception)
            { }
        }

        private void aktif()
        {
            btnSil.Enabled = false;
            btnEkle.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            dataGridSaat.Enabled = false;
            cmbSaat.Enabled = true;
        }

        private void pasif()
        {
            btnSil.Enabled = true;
            btnEkle.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            dataGridSaat.Enabled = true;
            cmbSaat.Enabled = false;
        }

        private void Saat_Load(object sender, EventArgs e)
        { Kayitlari_Goster(); }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            aktif();
            cmbSaat.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                sabitSaatBilgi.Saat = cmbSaat.Text;
                sabitSaat.KayitEkle(sabitSaatBilgi);
                pasif();
                Kayitlari_Goster();
                zamanBilgi.ZamandaDegisiklikVarmi = true;

            }
            catch (Exception)
            { }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        { pasif(); }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridSaat.Rows[dataGridSaat.CurrentCellAddress.Y].Cells["Id"].Value);
                DialogResult cevap = MessageBox.Show("Silmek istiyor musunuz?", "Dikkat !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (cevap == DialogResult.Yes)
                {
                    sabitSaat.KayitSil(id);
                    Kayitlari_Goster();
                    zamanBilgi.ZamandaDegisiklikVarmi = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
