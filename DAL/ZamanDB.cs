using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Batl.Info;
using System.Data;

namespace Batl.DAL
{
    public class ZamanDB
    {
        HelperDB helper = new HelperDB();

        public OleDbDataReader KayitlariTekTekGetir()
        {
            string sql = "SELECT * FROM zaman";
            return helper.ExecuteReader(sql);
        }

        public OleDbDataReader KayitSatir()
        {
            string sql = "SELECT DISTINCT (satirSayisi) , gTarih FROM zaman";
            return helper.ExecuteReader(sql);
        }

        public OleDbDataReader KayitSutun()
        {
            string sql = "SELECT DISTINCT (sutunSayisi) , gSaat FROM zaman";
            return helper.ExecuteReader(sql);
        }

        public int KayitlariSil()
        {
            string sql = "delete from zaman";
            return helper.ExecuteNonQuery(sql);
        }
       
        public int KayitlariSil(int id)
        {
            string sql = "delete from zaman where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }

        public int KayitEkle(ZamanInfo zamanBilgi)
        {
            string sql = "insert into zaman (tarih,sutunSayisi,satirSayisi,gTarih,gSaat,durum) Values (@Tarih,@SutunSayisi,@SatirSayisi,@GTarih,@GSaat,@Durum)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Tarih",OleDbType.VarChar,100),
            new OleDbParameter("@SutunSayisi",OleDbType.VarChar,2),
            new OleDbParameter("@SatirSayisi",OleDbType.VarChar,2),
            new OleDbParameter("@GTarih",OleDbType.VarChar,100),
            new OleDbParameter("@GSaat",OleDbType.VarChar,100),
            new OleDbParameter("@Durum",OleDbType.VarChar,1)
               };

            par[0].Value = zamanBilgi.Tarih;
            par[1].Value = zamanBilgi.SutunSayisi;
            par[2].Value = zamanBilgi.SatirSayisi;
            par[3].Value = zamanBilgi.GTarih;
            par[4].Value = zamanBilgi.GSaat;
            par[5].Value = zamanBilgi.Durum;
            return helper.ExecuteNonQuery(sql, par);
        }

        public DataTable KayitBul(string tarih, string saat)
        {
            string sql = "select * from zaman  where gTarih=@GTarih and gSaat=@GSaat";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@GTarih",OleDbType.VarChar,100),
            new OleDbParameter("@GSaat",OleDbType.VarChar,100)
               };

            par[0].Value = tarih;
            par[1].Value = saat;
            return helper.ExecuteDataSet(sql, par).Tables[0];
        }

        public int KayitDuzenle(ZamanInfo zamanBilgi)
        {
            string sql = "Update  zaman  set sutunSayisi=@SutunSayisi ,satirSayisi=@SatirSayisi ,durum=@Durum where id=@Id";

            OleDbParameter[] par = new OleDbParameter[]{
                     
            new OleDbParameter("@SutunSayisi",OleDbType.VarChar,2),
            new OleDbParameter("@SatirSayisi",OleDbType.VarChar,2),
            new OleDbParameter("@Durum",OleDbType.VarChar,1),
            new OleDbParameter("@Id",OleDbType.Integer)
               };

            par[0].Value = zamanBilgi.SutunSayisi;
            par[1].Value = zamanBilgi.SatirSayisi;
            par[2].Value = zamanBilgi.Durum;
            par[3].Value = zamanBilgi.Id;
            return helper.ExecuteNonQuery(sql, par);
        }
    }
}
