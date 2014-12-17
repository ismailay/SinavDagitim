using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Batl.Info;
using System.Data.OleDb;

namespace Batl.DAL
{
    public class SabitTarihDB
    {
        HelperDB helper = new HelperDB();

        public OleDbDataReader UcretTablosuIcinTarihleriGetir(int ayNo)
        {
            string sql = "SELECT sabitTarih.id, sabitTarih.tarih FROM sabitTarih WHERE Month(CDate(sabitTarih.tarih))=@AyNo order BY sabitTarih.tarih;";
            OleDbParameter p = new OleDbParameter("@AyNo", OleDbType.Integer);
            p.Value = ayNo;
            return helper.ExecuteReader(sql, p);
        }

        public DataTable  UcretTablosuIcinGorevTurleriniGetir(int ayNo, int ogrId, int tarId, string gorevTuru)
        {
            string sql = "SELECT Count(dersDagitimOgretmen.gorevTuru) AS Toplam FROM sabitTarih INNER JOIN (sabitOgretmen INNER JOIN (dersDagitim INNER JOIN dersDagitimOgretmen ON dersDagitim.id = dersDagitimOgretmen.dersDagitimId) ON sabitOgretmen.id = dersDagitimOgretmen.ogretmenId) ON sabitTarih.id = dersDagitim.tarihId GROUP BY dersDagitimOgretmen.gorevTuru, dersDagitim.tarihId, dersDagitimOgretmen.ogretmenId, Month(CDate([sabitTarih].[tarih])) HAVING (((dersDagitimOgretmen.gorevTuru)=[@GorevTuru]) AND ((dersDagitim.tarihId)=[@TarihId]) AND ((dersDagitimOgretmen.ogretmenId)=[@OgretmenId]) AND ((Month(CDate([sabitTarih].[tarih])))=[@AyNo]));";
            OleDbParameter[] par = new OleDbParameter[]{
                new OleDbParameter("@GorevTuru",OleDbType.VarChar,20), 
                new OleDbParameter("@TarihId",OleDbType.Integer),
                new OleDbParameter("@OgretmenId",OleDbType.Integer),
                new OleDbParameter("@AyNo",OleDbType.Integer)
               };
            par[0].Value = gorevTuru;
            par[1].Value = tarId;
            par[2].Value = ogrId;
            par[3].Value = ayNo;
            return helper.ExecuteDataSet(sql, par).Tables[0];
        }


        public DataTable AyIsimleri()
        {
            //string sql = "SELECT Monthname(Month(CONVERT(date,[sabitTarih]![tarih]))) AS Adi, Month(CDate([sabitTarih]![tarih])) AS Numara FROM sabitTarih;";
            string sql = "SELECT  distinct iif(M=1,'Ocak',iif(M=2,'Şubat', iif(M=3,'Mart', iif(M=4,'Nisan', iif(M=5,'Mayıs', iif(M=6,'Haziran', iif(M=7,'Temmuz', iif(M=8,'Ağustos', iif(M=9,'Eylül', iif(M=10,'Ekim', iif(M=11,'Kasım','Aralık'))))))))))) AS Adi, M as Numara FROM (SELECT Month(CDate([sabitTarih]![tarih])) AS M	FROM sabitTarih ) a ";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public DataTable KayitlariGetir()
        {
            string sql = "SELECT * FROM sabitTarih order by CDate(tarih)";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public OleDbDataReader KayitlariTekTekGetir()
        {
            string sql = "SELECT * from sabitTarih order by tarih; ";
            return helper.ExecuteReader(sql);
        }

        public int KayitlariSil()
        {
            string sql = "delete from sabitTarih";
            return helper.ExecuteNonQuery(sql);
        }

        public int KayitEkle(SabitTarihInfo SabitTarihBilgi)
        {
            string sql = "insert into sabitTarih (tarih) Values (@Tarih)";
            OleDbParameter[] par = new OleDbParameter[]{
                     new OleDbParameter("@Tarih",OleDbType.VarChar,100)
               };
            par[0].Value = SabitTarihBilgi.Tarih;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitEkle(string Tarih)
        {
            string sql = "insert into sabitTarih (tarih) Values (@Tarih)";
            OleDbParameter[] par = new OleDbParameter[]{
                     new OleDbParameter("@Tarih",OleDbType.VarChar,100)
               };
            par[0].Value = Tarih;
            return helper.ExecuteNonQuery(sql, par);
        }

        public DataTable KayitBul(string Tarih)
        {
            string sql = "select * from sabitTarih  where tarih=@Tarih";
            OleDbParameter[] par = new OleDbParameter[]{
                     new OleDbParameter("@Tarih",OleDbType.VarChar,100)
               };
            par[0].Value = Tarih;
            return helper.ExecuteDataSet(sql, par).Tables[0];
        }

        public DataTable TarihleriGetir()
        {
            string sql = "SELECT * from sabitTarih order by tarih";
            return helper.ExecuteDataSet(sql).Tables[0];
        }


    }
}
