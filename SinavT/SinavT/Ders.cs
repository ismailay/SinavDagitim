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
    public partial class Ders : Form
    {
        SabitDersGrupDB sabitDersGrup = new SabitDersGrupDB();
        SabitBolumDB sabitBolum = new SabitBolumDB();
        SabitDersDB sabitDers = new SabitDersDB();
        SabitDersInfo SabitDersBilgi = new SabitDersInfo();
        string kayitDurumu = "";

        public Ders()
        {
            InitializeComponent();
        }

        private void buttonCks_Click(object sender, EventArgs e)
        { this.Close(); }
        private void Kayitlari_Goster()
        {
            try
            {
                cmbSinif.DataSource = sabitDersGrup.KayitlariGetir();
                cmbSinif.ValueMember = "id";
                cmbSinif.DisplayMember = "grup";
                cmbBolum.DataSource = sabitBolum.KayitlariGetir();
                cmbBolum.ValueMember = "id";
                cmbBolum.DisplayMember = "ad";

                dataGridDrsBlgri.AutoGenerateColumns = false;
                dataGridDrsBlgri.DataSource = sabitDers.KayitlariGetir();
                // dataGridDrsBlgri.Columns[0].Visible = false;

                /*DataGridViewComboBoxColumn ComboTextBolum = new DataGridViewComboBoxColumn();
                dataGridDrsBlgri.Columns.AddRange (ComboTextBolum);
                ComboTextBolum.HeaderText = "Bölüm";
                ComboTextBolum.DataPropertyName = "bolum";
                ComboTextBolum.DataSource = sabitBolum.KayitlariGetir();
                ComboTextBolum.DisplayMember = "ad";
                ComboTextBolum.ValueMember = "id";
                DataGridViewComboBoxColumn ComboTextSeviye = new DataGridViewComboBoxColumn();
                dataGridDrsBlgri.Columns.AddRange(ComboTextSeviye);
                ComboTextSeviye.HeaderText = "Sınıf Seviyesi";
                ComboTextSeviye.DataPropertyName = "seviye";
                ComboTextSeviye.DataSource = sabitDersGrup.KayitlariGetir();
                ComboTextSeviye.DisplayMember = "grup";
                ComboTextSeviye.ValueMember = "id";
                 */
            }
            catch (Exception)
            {            }

        }

        private void aktif()
        {
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            btnEkle.Enabled = false;
            dataGridDrsBlgri.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            cmbBolum.Enabled = true;
            cmbSinif.Enabled = true;
            txtKodu.Enabled = true;
            txtDersAdi.Enabled = true;
        }

        private void pasif()
        {
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            btnEkle.Enabled = true;
            dataGridDrsBlgri.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            cmbBolum.Enabled = false;
            cmbSinif.Enabled = false;
            txtKodu.Enabled = false;
            txtDersAdi.Enabled = false;
            txtKodu.Clear();
            txtDersAdi.Clear();
        }


        private void Ders_Load(object sender, EventArgs e)
        { Kayitlari_Goster(); }

        private void btnVazgec_Click(object sender, EventArgs e)
        { pasif(); }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SabitDersBilgi.Kodu = txtKodu.Text;
                SabitDersBilgi.Adi = txtDersAdi.Text;
                SabitDersBilgi.Seviye = Convert.ToInt32(cmbSinif.SelectedValue);
                SabitDersBilgi.Sure = "";
                SabitDersBilgi.Grup = "";
                SabitDersBilgi.Bolum = Convert.ToInt32(cmbBolum.SelectedValue);
                if (kayitDurumu == "Ekle")
                { sabitDers.KayitEkle(SabitDersBilgi); }
                if (kayitDurumu == "Duzenle")
                { sabitDers.KayitDegistir(SabitDersBilgi); }
                pasif();
                Kayitlari_Goster();

            }
            catch (Exception)
            { }

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SabitDersBilgi.Id = Convert.ToInt32(dataGridDrsBlgri.Rows[dataGridDrsBlgri.CurrentCellAddress.Y].Cells["id"].Value);
                txtKodu.Text = dataGridDrsBlgri.Rows[dataGridDrsBlgri.CurrentCellAddress.Y].Cells["kodu"].Value.ToString();
                txtDersAdi.Text = dataGridDrsBlgri.Rows[dataGridDrsBlgri.CurrentCellAddress.Y].Cells["adi"].Value.ToString();
                cmbSinif.SelectedValue = Convert.ToInt32(dataGridDrsBlgri.Rows[dataGridDrsBlgri.CurrentCellAddress.Y].Cells["seviye"].Value.ToString());
                cmbBolum.SelectedValue = Convert.ToInt32(dataGridDrsBlgri.Rows[dataGridDrsBlgri.CurrentCellAddress.Y].Cells["bolum"].Value.ToString());
                kayitDurumu = "Duzenle";
                aktif();
            }
            catch (Exception)
            {
                MessageBox.Show("Düzenlenecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridDrsBlgri.Rows[dataGridDrsBlgri.CurrentCellAddress.Y].Cells["id"].Value);
                DialogResult cevap = MessageBox.Show("Silmek istiyor musunuz?", "Dikkat !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (cevap == DialogResult.Yes)
                {
                    sabitDers.KayitSil(id);
                    Kayitlari_Goster();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kayitDurumu = "Ekle";
            aktif();
            cmbSinif.Focus();
        }
    }
}
