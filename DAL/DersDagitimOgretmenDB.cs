using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Batl.Info;
using System.Data.OleDb;
using System.Data;

namespace Batl.DAL
{
    public class DersDagitimOgretmenDB
    {
        HelperDB helper = new HelperDB();

        public OleDbDataReader OgretmenleriGetirTekrarsiz()
        {
            string sql = "SELECT DISTINCT dersDagitimOgretmen.ogretmenId, sabitOgretmen.adi, sabitOgretmen.bolum FROM sabitOgretmen INNER JOIN dersDagitimOgretmen ON sabitOgretmen.id = dersDagitimOgretmen.ogretmenId;";
            return helper.ExecuteReader(sql);
        }

        public DataTable ImzaCetveliRaporIcinKayitlariGetir(int tarihId)
        {
            //string sql = "SELECT dersDagitim.id, dersDagitim.TarihId, sabitTarih.tarih, sabitOgretmen.adi AS OgretmenAdi, sabitSaat.saat, dersDagitimOgretmen.gorevTuru AS OgretmenGorevTuru, sabitMudurYardimcilar.adi as nobetciMudurYardimcisi FROM sabitMudurYardimcilar RIGHT JOIN ((sabitTarih INNER JOIN (sabitSaat INNER JOIN (sabitOgretmen INNER JOIN (dersDagitim INNER JOIN dersDagitimOgretmen ON dersDagitim.id = dersDagitimOgretmen.dersDagitimId) ON sabitOgretmen.id = dersDagitimOgretmen.ogretmenId) ON sabitSaat.id = dersDagitim.saatId) ON sabitTarih.id = dersDagitim.tarihId) LEFT JOIN nobetciOgretmen ON sabitTarih.id = nobetciOgretmen.tarihId) ON sabitMudurYardimcilar.id = nobetciOgretmen.mudurYardimcisiId WHERE (((dersDagitim.TarihId)=@TarihId)) ORDER BY sabitSaat.saat, dersDagitimOgretmen.gorevTuru DESC;";
            string sql = @"SELECT dersDagitim.id, dersDagitim.TarihId, sabitTarih.tarih, sabitOgretmen.adi AS OgretmenAdi, sabitSaat.saat, dersDagitimOgretmen.gorevTuru AS OgretmenGorevTuru, sabitMudurYardimcilar.adi AS nobetciMudurYardimcisi, sabitDers.adi as DersAdi
FROM sabitDers INNER JOIN ((sabitTarih INNER JOIN (sabitSaat INNER JOIN (sabitOgretmen INNER JOIN (dersDagitim INNER JOIN dersDagitimOgretmen ON dersDagitim.id = dersDagitimOgretmen.dersDagitimId) ON sabitOgretmen.id = dersDagitimOgretmen.ogretmenId) ON sabitSaat.id = dersDagitim.saatId) ON sabitTarih.id = dersDagitim.tarihId) LEFT JOIN (sabitMudurYardimcilar RIGHT JOIN nobetciOgretmen ON sabitMudurYardimcilar.id = nobetciOgretmen.mudurYardimcisiId) ON sabitTarih.id = nobetciOgretmen.tarihId) ON sabitDers.id = dersDagitim.dersId
WHERE (((dersDagitim.TarihId)=[@TarihId]))
ORDER BY CDate(sabitSaat.saat), dersDagitimOgretmen.gorevTuru DESC,sabitOgretmen.adi ASC ;";
            OleDbParameter par = new OleDbParameter("@TarihId", OleDbType.Integer);
            par.Value = tarihId;
            return helper.ExecuteDataSet(sql, par).Tables[0];
        }

        public DataTable ImzaCetveliIcinKayitlariGetir(int tarihId)
        {
            string sql = "SELECT dersDagitim.id , dersDagitim.TarihId, sabitTarih.tarih, sabitOgretmen.adi, sabitSaat.saat, dersDagitimOgretmen.gorevTuru FROM sabitOgretmen INNER JOIN (sabitSaat INNER JOIN (sabitTarih INNER JOIN (dersDagitim INNER JOIN dersDagitimOgretmen ON dersDagitim.id = dersDagitimOgretmen.dersDagitimId) ON sabitTarih.id = dersDagitim.tarihId) ON sabitSaat.id = dersDagitim.saatId) ON sabitOgretmen.id = dersDagitimOgretmen.ogretmenId WHERE (((dersDagitim.tarihId)=@TarihId)) ORDER BY CDate(sabitSaat.saat), dersDagitimOgretmen.gorevTuru DESC,sabitOgretmen.adi ASC;";
            OleDbParameter par = new OleDbParameter("@TarihId", OleDbType.Integer);
            par.Value = tarihId;
            return helper.ExecuteDataSet(sql, par).Tables[0];
        }



        public int KayitEkle(DersDagitimOgretmenInfo dersDagitimOgretmenBilgi)
        {
            string sql = "insert into dersDagitimOgretmen (ogretmenId,dersDagitimId,gorevTuru) Values (@OgretmenId,@DersDagitimId,@GorevTuru)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@OgretmenId",OleDbType.Integer),
            new OleDbParameter("@DersDagitimId",OleDbType.Integer),
            new OleDbParameter("@GorevTuru",OleDbType.VarChar,100)
               };

            par[0].Value = dersDagitimOgretmenBilgi.OgretmenId;
            par[1].Value = dersDagitimOgretmenBilgi.DersDagitimId;
            par[2].Value = dersDagitimOgretmenBilgi.GorevTuru;
            return helper.ExecuteNonQuery(sql, par);
        }

        public DataTable KayitlariGetir()
        {
            string sql = "SELECT distinct  sabitOgretmen.id as OgretmenId, sabitOgretmen.adi as OgretmenAdi FROM sabitOgretmen INNER JOIN dersDagitimOgretmen ON sabitOgretmen.id = dersDagitimOgretmen.ogretmenId;";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public int KayitSil(int id)
        {
            string sql = "delete from dersDagitimOgretmen where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }

        public int OgretmeninTumKayitlariniSil(int id)
        {
            string sql = "delete from dersDagitimOgretmen where ogretmenId=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }

        public int DerseAitOgretmenleriSil(int id)
        {
            string sql = "delete from dersDagitimOgretmen where dersDagitimId=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }
    }
}
