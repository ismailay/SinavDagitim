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
    public partial class ZamanCizelgesi : Form
    {
        SabitSaatDB sabitSaat = new SabitSaatDB();
        SabitTarihDB sabitTarih = new SabitTarihDB();
        ZamanDB zaman = new ZamanDB();
        ZamanInfo zamanBilgi = new ZamanInfo();
        DersDagitimDB dersDagitim = new DersDagitimDB();
        DersDagitimOgretmenDB dersDagitimOgretmen = new DersDagitimOgretmenDB();

        bool satirDurumu = false;
        // int kolonSayisi;
        // int satirSayisi;
        public ZamanCizelgesi()
        { InitializeComponent(); }

        private void Kayitlari_Goster()
        {
            //sütun eklemek
            OleDbDataReader saatlar = sabitSaat.KayitlariTekTekGetir();
            while (saatlar.Read())
            {
                DataGridViewTextBoxColumn saat = new DataGridViewTextBoxColumn();
                this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { saat });
                saat.SortMode = DataGridViewColumnSortMode.NotSortable;
                saat.HeaderText = saatlar["saat"].ToString();
            }

            saatlar.Close();

            //satır ekleme
            int say = 0;
            OleDbDataReader satirlar = sabitTarih.KayitlariTekTekGetir();
            while (satirlar.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[say].HeaderCell.Value = satirlar["tarih"].ToString();
                say += 1;
            }
            satirlar.Close();
            

        }

        private void ZamanCizelgesi_Load(object sender, EventArgs e)
        {
            Kayitlari_Goster();
        }

        private void ZamanCizelgesi_Activated(object sender, EventArgs e)
        {
            //form load olurken satır başlığı değiştiremedim.
            //bunun yerine satirDurum kontrol aracı ile kontrol ediyorum.
            if (satirDurumu == false)
            {
                int rowNumber = 0;
                //Satır başlıklarına tarih değerlerini ekl
                OleDbDataReader tarihler = sabitTarih.KayitlariTekTekGetir();
                while (tarihler.Read())
                {
                    dataGridView1.Rows[rowNumber].HeaderCell.Value = tarihler["Tarih"].ToString();
                    rowNumber += 1;
                }
                dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                satirDurumu = true;

                //Kapalı hücrelere 1 değerini yaz
                OleDbDataReader zamanlar = zaman.KayitlariTekTekGetir();
                while (zamanlar.Read())
                {
                    foreach (DataGridViewRow SatirNo in dataGridView1.Rows)
                        foreach (DataGridViewColumn SutunNo in dataGridView1.Columns)
                            if (zamanlar["gtarih"].ToString() == SatirNo.HeaderCell.Value.ToString() && zamanlar["gsaat"].ToString() == SutunNo.HeaderCell.Value.ToString())
                                if (zamanlar["durum"].ToString() == "1")
                                    //hücreleri renklendir
                                    SatirNo.Cells[SutunNo.Index].Style.BackColor = Color.Red;
                }
                zamanlar.Close();
                //datagrid ilk kaydın rengine göre seçim rengini belirle
                if (dataGridView1.Rows.Count > 0)
                {
                    if (dataGridView1.Rows[0].Cells[0].Style.BackColor == Color.Red)
                        dataGridView1.Rows[0].Cells[0].Style.SelectionBackColor = Color.Red;
                    else
                        dataGridView1.Rows[0].Cells[0].Style.SelectionBackColor = Color.White;
                }
            }
        }

        private void buttonCks_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKydt_Click(object sender, EventArgs e)
        {
            //  zaman.KayitlariSil();
            foreach (DataGridViewRow satir in dataGridView1.Rows)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    string tarih = satir.HeaderCell.Value.ToString();
                    string saat = dataGridView1.Columns[i].HeaderCell.Value.ToString();
                    zamanBilgi.Tarih = zamanBilgi.GTarih = tarih;
                    zamanBilgi.GSaat = saat;
                    zamanBilgi.SatirSayisi = satir.Index.ToString();
                    zamanBilgi.SutunSayisi = i.ToString();
                    zamanBilgi.Durum = "1";
                    if (zaman.KayitBul(tarih, saat).Rows.Count <= 0)
                    {
                        if (satir.Cells[i].Style.BackColor == Color.Red)
                            zaman.KayitEkle(zamanBilgi);
                    }
                    else
                    {
                        zamanBilgi.Id = Convert.ToInt32(zaman.KayitBul(tarih, saat).Rows[0][0]);
                        if (satir.Cells[i].Style.BackColor == Color.Red)
                            zaman.KayitDuzenle(zamanBilgi);
                        else
                            zaman.KayitlariSil(zamanBilgi.Id);
                    }


                }

            }

            //Kapatılan yerlerdeki ders kayıtlarını siliniyor
            MessageBox.Show("Kapatılan tarih ve saate önceden aktarılmış dersler ve öğretmenler siliniyor");
            foreach (DataGridViewRow satirNo in dataGridView1.Rows)
                foreach (DataGridViewColumn sutunNo in dataGridView1.Columns)
                    if (satirNo.Cells[sutunNo.Index].Style.BackColor == Color.Red)
                    {
                        OleDbDataReader dersler = dersDagitim.DersleriBul(satirNo.HeaderCell.Value.ToString(), sutunNo.HeaderCell.Value.ToString());
                        while (dersler.Read())
                            dersDagitim.KayitSil(Convert.ToInt32(dersler["id"]));
                    }
            //******bitti********

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Red)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.White;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.Red;
                }
        }

    }
}
