using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Batl.Info;

namespace Batl.DAL
{
    public class YedekDB
    {
        HelperYedekDB helper = new HelperYedekDB();

        public DataTable KayitlariGetir()
        {
        string sql="select * from bilgiler";
        return helper.ExecuteDataSet(sql).Tables[0];
        }
       
        public int KayitEkle(YedekInfo yedekBilgi)
        {
            string sql = "insert into bilgiler (adi,yedekTarihi, yedekSaat, baslangicTarihi, bitisTarihi, kurumAdi, donemAdi, donemYili, dosyaAdi) Values (@Adi, @YedekTarihi, @YedekSaat, @BaslangicTarihi, @BitisTarihi, @KurumAdi, @DonemAdi, @DonemYili, @DosyaAdi)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Adi",OleDbType.VarChar,255),
            new OleDbParameter("@YedekTarihi",OleDbType.Date),
            new OleDbParameter("@YedekSaat",OleDbType.VarChar,100),
            new OleDbParameter("@BaslangicTarihi",OleDbType.Date),
            new OleDbParameter("@BitisTarihi",OleDbType.Date),
            new OleDbParameter("@KurumAdi",OleDbType.VarChar,255),
            new OleDbParameter("@DonemAdi",OleDbType.VarChar,255),
            new OleDbParameter("@DonemYili",OleDbType.VarChar,255),
            new OleDbParameter("@DosyaAdi",OleDbType.VarChar,255)
               };

            par[0].Value = yedekBilgi.Adi;
            par[1].Value = yedekBilgi.YedekTarihi;
            par[2].Value = yedekBilgi.YedekSaat;
            par[3].Value = yedekBilgi.BaslangicTarihi;
            par[4].Value = yedekBilgi.BitisTarihi;
            par[5].Value = yedekBilgi.KurumAdi;
            par[6].Value = yedekBilgi.DonemAdi;
            par[7].Value = yedekBilgi.DonemYili;
            par[8].Value = yedekBilgi.DosyaAdi;

            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitSil(int id)
        {
            string sql = "delete from bilgiler where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }
    }
}
