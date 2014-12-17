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
    public partial class GorevDagilimiElle : Form
    {
        SabitTarihDB sabitTarih = new SabitTarihDB();
        SabitSaatDB sabitSaat = new SabitSaatDB();

        SabitOkulDB sabitOkul = new SabitOkulDB();
        SabitOkulInfo sabitOkulBilgi = new SabitOkulInfo();
        ZamanDB zaman = new ZamanDB();
        ZamanInfo zamanBilgi = new ZamanInfo();
        DersDagitimDB dersDagitim = new DersDagitimDB();
        public static DersDagitimInfo dersDagitimBilgi = new DersDagitimInfo();
        public static DersDagitimOgretmenInfo dersDagitimOgretmenBilgi = new DersDagitimOgretmenInfo();

        int sonKonumSatir = 0, sonKonumSutun = 0;
        int[,] DersIdDizi = new int[100, 100];
        int[] TarihIdDizi = new int[100];
        int[] SaatIdDizi = new int[100];
        int[,] DersDagitimIdDizi = new int[100, 100];
        public static int seciliDersId;
        public static string seciliTarih;
        public static string seciliSaat;
        public static string sinavTuru;
        public static int sinavSekli;
        int satirIndex, sutunIndex;
        public GorevDagilimiElle()
        { InitializeComponent(); }

        private void DataGridiOlustur()
        {
          //  try
            {
                //sütun eklemek

                int say = 0;
                Array.Clear(SaatIdDizi, 0, SaatIdDizi.Length);
                OleDbDataReader saatlar = sabitSaat.KayitlariTekTekGetir();
                while (saatlar.Read())
                {
                    SaatIdDizi[say] = Convert.ToInt32(saatlar["id"]);
                    DataGridViewTextBoxColumn saat = new DataGridViewTextBoxColumn();
                    this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { saat });
                    saat.SortMode = DataGridViewColumnSortMode.NotSortable;
                    saat.HeaderText = saatlar["saat"].ToString();
                    say += 1;
                }
                saatlar.Close();

                //satır ekleme
                OleDbDataReader satirlar = sabitTarih.KayitlariTekTekGetir();
                say = 0;
                Array.Clear(TarihIdDizi, 0, TarihIdDizi.Length);
                while (satirlar.Read())
                {
                    TarihIdDizi[say] = Convert.ToInt32(satirlar["id"]);
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[say].HeaderCell.Value = satirlar["tarih"].ToString();
                    say += 1;
                }
                satirlar.Close();
                dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

                //Kapalı hücrelere 1 değerini yaz
                OleDbDataReader zamanlar = zaman.KayitlariTekTekGetir();
                while (zamanlar.Read())
                {
                    foreach (DataGridViewRow SatirNo in dataGridView1.Rows)
                        foreach (DataGridViewColumn SutunNo in dataGridView1.Columns)
                            if (zamanlar["gtarih"].ToString() == SatirNo.HeaderCell.Value.ToString() && zamanlar["gsaat"].ToString() == SutunNo.HeaderCell.Value.ToString())
                                if (zamanlar["durum"].ToString() == "1")
                                    SatirNo.Cells[SutunNo.Index].Style.BackColor = Color.Red;
                }
                zamanlar.Close();
                //oturum değerlerini doldur
                sabitOkulBilgi = sabitOkul.KayitGetir(Convert.ToInt32(sabitOkul.KayitlariGetir().Rows[0][0]));
                cmbOturum.Items.Clear();
                for (int i = 0; i < Convert.ToInt32(sabitOkulBilgi.MaksimumSaat); i++)
                    cmbOturum.Items.Add(i + 1);
                cmbOturum.SelectedIndex = 0;
                lblOturum.Text = cmbOturum.Text;
            }
         //   catch (Exception)
            { }
        }

        private void Kayitlari_Goster()
        {
            //etiketleri temizle
            lblSeviye.Text = "-";
            lblBolum.Text = "-";
            lblDers.Text = "-";
            lblTuru.Text = "-";
            lblSekli.Text = "-";
            //komisyon veya gözcü eklenemez
            lstKomisyon.Enabled = false;
            lstGozcu.Enabled = false;
            //komisyonu getir
            lstKomisyon.DataSource = dersDagitim.KomisyonGetir(0);
            lstKomisyon.ValueMember = "dersDagitimOgretmenId";
            lstKomisyon.DisplayMember = "OgretmenAdi";
            //gözcü getir
            lstGozcu.DataSource = dersDagitim.GozcuGetir(0);
            lstGozcu.ValueMember = "dersDagitimOgretmenId";
            lstGozcu.DisplayMember = "OgretmenAdi";
            //datagridi temizle
            foreach (DataGridViewRow SatirNo in dataGridView1.Rows)
                foreach (DataGridViewColumn SutunNo in dataGridView1.Columns)
                    if (dataGridView1.Rows[SatirNo.Index].Cells[SutunNo.Index].Style.BackColor != Color.Red)
                        dataGridView1.Rows[SatirNo.Index].Cells[SutunNo.Index].Value = null;
            //kayitları gridde göster
            OleDbDataReader sinavlar = dersDagitim.KayitlariTekTekGetir(Convert.ToInt32(lblOturum.Text));
            Array.Clear(DersIdDizi, 0, DersIdDizi.Length);
            Array.Clear(DersDagitimIdDizi, 0, DersDagitimIdDizi.Length);
            while (sinavlar.Read())
            {
                foreach (DataGridViewRow SatirNo in dataGridView1.Rows)
                    foreach (DataGridViewColumn SutunNo in dataGridView1.Columns)
                        if (sinavlar["tarih"].ToString() == SatirNo.HeaderCell.Value.ToString() && sinavlar["saat"].ToString() == SutunNo.HeaderCell.Value.ToString())
                            if (SatirNo.Cells[SutunNo.Index].Style.BackColor != Color.Red)
                            {
                                SatirNo.Cells[SutunNo.Index].Value = sinavlar["adi"].ToString();
                                //dataGridView1.Rows[Convert.ToInt32(sinavlar["satirSayisi"])].Cells[Convert.ToInt32(sinavlar["sutunSayisi"])].Value = sinavlar["adi"].ToString();
                                DersIdDizi[SatirNo.Index, SutunNo.Index] = Convert.ToInt32(sinavlar["DersId"]);
                                //DersIdDizi[Convert.ToInt32(sinavlar["satirSayisi"]), Convert.ToInt32(sinavlar["sutunSayisi"])] = Convert.ToInt32(sinavlar["DersId"]);
                                DersDagitimIdDizi[SatirNo.Index, SutunNo.Index] = Convert.ToInt32(sinavlar["DersDagitimId"]);
                                //DersDagitimIdDizi[Convert.ToInt32(sinavlar["satirSayisi"]), Convert.ToInt32(sinavlar["sutunSayisi"])] = Convert.ToInt32(sinavlar["DersDagitimId"]);
                            }
            }
            sinavlar.Close();
            dataGridView1.AutoResizeColumns();
            satirIndex = dataGridView1.CurrentCellAddress.Y;
            sutunIndex = dataGridView1.CurrentCellAddress.X;
            Etiketleri_Goster();
        }

        private void Etiketleri_Goster()
        {
            //gridteki ders seviye ve bolum bilgilerini getir
            if (DersDagitimIdDizi[satirIndex, sutunIndex].ToString() != null && DersDagitimIdDizi[satirIndex, sutunIndex] > 0)
            {
                OleDbDataReader dersler = dersDagitim.DersGetir(DersIdDizi[satirIndex, sutunIndex]);
                while (dersler.Read())
                {
                    lblSeviye.Text = dersler["DersGrup"].ToString();
                    lblBolum.Text = dersler["BolumAdi"].ToString();
                    lblDers.Text = dersler["DersAdi"].ToString();
                    lblTuru.Text = dersler["turu"].ToString();
                    lblSekli.Text = dersler["SinavSekli"].ToString();
                }
                dersler.Close();
                //komisyon ve gözcü eklenebilir
                lstKomisyon.Enabled = true;
                lstGozcu.Enabled = true;
                seciliDersId = DersDagitimIdDizi[satirIndex, sutunIndex];
                seciliTarih = dataGridView1.Rows[satirIndex].HeaderCell.Value.ToString();
                seciliSaat = dataGridView1.Columns[sutunIndex].HeaderCell.Value.ToString();
                //komisyonu getir
                lstKomisyon.DataSource = dersDagitim.KomisyonGetir(GorevDagilimiElle.seciliDersId);
                lstKomisyon.ValueMember = "dersDagitimOgretmenId";
                lstKomisyon.DisplayMember = "OgretmenAdi";
                //gozcu getir
                lstGozcu.DataSource = dersDagitim.GozcuGetir(GorevDagilimiElle.seciliDersId);
                lstGozcu.ValueMember = "dersDagitimOgretmenId";
                lstGozcu.DisplayMember = "OgretmenAdi";
            }
        }

        private void GorevDagilimiElle_Load(object sender, EventArgs e)
        {
            try
            {
                DataGridiOlustur();
                Kayitlari_Goster();
                //ilk hücrenin zemin rengine göre seçim rengini değiştir.
                dataGridView1.Rows[0].Cells[0].Style.SelectionBackColor = dataGridView1.Rows[0].Cells[0].Style.BackColor;
            }
            catch (Exception)
            { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //hücreye ders ekle
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.Red && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {

                GorevDagilimiDers Form_GorevDagilimiDers = new GorevDagilimiDers();
                Form_GorevDagilimiDers.ShowDialog();
                //ders seçilip seçilmediği kontrol ediliyor
                if (dersDagitimBilgi.DersId.ToString() != null && dersDagitimBilgi.DersId > 0)
                {
                    dersDagitimBilgi.TarihId = TarihIdDizi[e.RowIndex];
                    dersDagitimBilgi.SaatId = SaatIdDizi[e.ColumnIndex];
                    dersDagitimBilgi.Oturum = Convert.ToInt32(cmbOturum.Text);
                    dersDagitimBilgi.Turu = sinavTuru;
                    dersDagitimBilgi.Sekli = sinavSekli;
                    dersDagitim.KayitEkle(dersDagitimBilgi);
                    Kayitlari_Goster();
                }
            }
            else
                //gridte tıklandığında kırmızı bölge seçimini iptal et
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Red)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[sonKonumSatir].Cells[sonKonumSutun].Selected = true;
                }
                else
                {
                    satirIndex = e.RowIndex;
                    sutunIndex = e.ColumnIndex;
                    Etiketleri_Goster();
                }
        }

        private void buttonCks_Click(object sender, EventArgs e)
        { this.Close(); }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //gridten ayrılırken zaman durumunu kontrol et
            sonKonumSutun = e.ColumnIndex;
            sonKonumSatir = e.RowIndex;
            if (e.RowIndex < 0) sonKonumSatir = 0; else sonKonumSatir = e.RowIndex;
            if (e.ColumnIndex < 0) sonKonumSutun = 0; else sonKonumSutun = e.ColumnIndex;
        }

        private void cmbOturum_TextChanged(object sender, EventArgs e)
        {
            //oturum sayısı text kutusunda göster
            lblOturum.Text = cmbOturum.Text;
        }

        private void cmbOturum_SelectedValueChanged(object sender, EventArgs e)
        {
            //oturum değiştiğinde gritdeki bilgileri değiştir
            Kayitlari_Goster();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(DersDagitimIdDizi[dataGridView1.CurrentCellAddress.Y, dataGridView1.CurrentCellAddress.X]);
                DialogResult cevap = MessageBox.Show("Silmek istiyor musunuz?", "Dikkat !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (cevap == DialogResult.Yes)
                {
                    dersDagitim.KayitSil(id);
                    Kayitlari_Goster();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstKomisyon_DoubleClick(object sender, EventArgs e)
        {
            GorevDagilimKomisyon Form_GorevDagilimiKomisyon = new GorevDagilimKomisyon();
            Form_GorevDagilimiKomisyon.ShowDialog();
            Etiketleri_Goster();
        }

        private void lstGozcu_DoubleClick(object sender, EventArgs e)
        {
            GorevDagilimGozcu Form_GorevDagilimiGozcu = new GorevDagilimGozcu();
            Form_GorevDagilimiGozcu.ShowDialog();
            Etiketleri_Goster();
        }
    }
}