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
using System.IO;

namespace SinavT
{
    public partial class YedkAlma : Form
    {
        YedekDB yedek = new YedekDB();
        public YedkAlma()
        {
            InitializeComponent();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KayitlariGoster()
        {
            dtGridViewYedekler.DataSource = yedek.KayitlariGetir();
            if (dtGridViewYedekler.Rows.Count > 0)
            {
                buttonGeriAl.Enabled = true;
                buttonYedekSil.Enabled = true;
            }
            else
            {
                buttonGeriAl.Enabled = false;
                buttonYedekSil.Enabled = false;
            }
        }

        private void YedkAlma_Load(object sender, EventArgs e)
        { KayitlariGoster(); }

        private void buttonYedekAl_Click(object sender, EventArgs e)
        {
            //yedek al
            SabitOkulDB sabitOkul = new SabitOkulDB();
            DataTable dtOkul = new DataTable();
            dtOkul = sabitOkul.KayitlariGetir();
            YedekInfo yedekBilgi = new YedekInfo();
            string DosyaAdi = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString();
            if (File.Exists("App_Data\\sinav.mdb"))
            {
                if (dtOkul.Rows.Count > 0)
                {
                    yedekBilgi.Adi = txtYedekAdi.Text;
                    yedekBilgi.BaslangicTarihi = Convert.ToDateTime(dtOkul.Rows[0]["sinavBaslamaTarihi"].ToString()).Date;
                    yedekBilgi.BitisTarihi = Convert.ToDateTime(dtOkul.Rows[0]["sinavBitisTarihi"].ToString()).Date;
                    yedekBilgi.DonemAdi = dtOkul.Rows[0]["sinavDonemi"].ToString();
                    yedekBilgi.DonemYili = dtOkul.Rows[0]["ogretimYili"].ToString();
                    yedekBilgi.DosyaAdi = DosyaAdi;
                    yedekBilgi.KurumAdi = dtOkul.Rows[0]["okulAdi1"].ToString() + " " + dtOkul.Rows[0]["okulAdi2"].ToString();
                    yedekBilgi.YedekSaat = DateTime.Now.ToShortTimeString();
                    yedekBilgi.YedekTarihi = DateTime.Now.Date;
                    yedek.KayitEkle(yedekBilgi);
                    File.Copy("App_Data\\sinav.mdb", "App_Data\\yedek\\" + DosyaAdi + ".mdb");
                }
            }
            else
            {
                MessageBox.Show("Yedek alınacak dosya bulunamamaktadır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            KayitlariGoster();
            txtYedekAdi.Text = "";
        }

        private void buttonYedekSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Silmek istiyor musunuz?", "Dikkat !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                int id = Convert.ToInt32(dtGridViewYedekler.Rows[dtGridViewYedekler.CurrentCellAddress.Y].Cells["id"].Value);
                if (cevap == DialogResult.Yes)
                {
                    string DosyaYolu = "App_Data\\yedek\\" + dtGridViewYedekler.Rows[dtGridViewYedekler.CurrentCellAddress.Y].Cells["dosyaAdi"].Value + ".mdb";
                    if (File.Exists(DosyaYolu))
                        File.Delete(DosyaYolu);
                    else
                        MessageBox.Show("Silinecek Yedek dosya bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    yedek.KayitSil(id);
                    KayitlariGoster();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGeriAl_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Yedeği geri almak istiyor musunuz?", "Dikkat !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
              
                if (cevap == DialogResult.Yes)
                {
                    string DosyaYolu = "App_Data\\yedek\\" + dtGridViewYedekler.Rows[dtGridViewYedekler.CurrentCellAddress.Y].Cells["dosyaAdi"].Value + ".mdb";
                    if (File.Exists(DosyaYolu))
                    {
                        File.Delete("App_Data\\sinav.mdb");
                        File.Copy(DosyaYolu, "App_Data\\sinav.mdb");
                    }
                    else
                        MessageBox.Show("Geri alıanack dosya bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Dikkat !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //********
    }
}

