using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Batl.Info;

namespace Batl.DAL
{
    public class DersDagitimDB
    {
        HelperDB helper = new HelperDB();

        public OleDbDataReader CarsafListeIcinKayitlariTekTekGetir()
        {
            string sql = "SELECT dersDagitim.id, sabitTarih.tarih, sabitSaat.saat, dersDagitim.oturum, sabitDers.adi as DersAdi, dersDagitim.turu as Sekli, sabitDersGrubu.grup as Sinif, sabitOgretmen.adi as OgretmenAdi, sabitMudurYardimcilar.adi as MudurYardimciAdi FROM (sabitTarih RIGHT JOIN (sabitSaat RIGHT JOIN (sabitDersGrubu RIGHT JOIN (sabitDers RIGHT JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) ON sabitDersGrubu.id = sabitDers.seviye) ON sabitSaat.id = dersDagitim.saatId) ON sabitTarih.id = dersDagitim.tarihId) LEFT JOIN (sabitMudurYardimcilar RIGHT JOIN (sabitOgretmen RIGHT JOIN nobetciOgretmen ON sabitOgretmen.id = nobetciOgretmen.ogretmenId) ON sabitMudurYardimcilar.id = nobetciOgretmen.mudurYardimcisiId) ON sabitTarih.id = nobetciOgretmen.tarihId ORDER BY sabitTarih.tarih, sabitSaat.saat, dersDagitim.oturum;";
            return helper.ExecuteReader(sql);
        }

        public OleDbDataReader KayitlariTekTekGetir(int bId)
        {
            // string sql = "SELECT dersDagitim.oturum, zaman.sutunSayisi, zaman.satirSayisi, sabitDers.adi, sabitDers.id as DersId, zaman.id as ZamanId, dersDagitim.id as DersDagitimId FROM sabitDers INNER JOIN (zaman INNER JOIN dersDagitim ON zaman.id = dersDagitim.zamanId) ON sabitDers.id = dersDagitim.dersId WHERE (((dersDagitim.oturum)=@Id)); ";
            string sql = "SELECT dersDagitim.oturum, dersDagitim.id AS DersDagitimId, sabitTarih.tarih, sabitSaat.saat, sabitDers.id as DersId, sabitDers.adi FROM sabitTarih INNER JOIN (sabitSaat INNER JOIN (sabitDers INNER JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) ON sabitSaat.id = dersDagitim.saatId) ON sabitTarih.id = dersDagitim.tarihId WHERE (((dersDagitim.oturum)=@Id));";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            return helper.ExecuteReader(sql, p);
        }

        public OleDbDataReader KayitlariTekTekGetir()
        {
            string sql = "SELECT dersDagitim.oturum, dersDagitim.id AS DersDagitimId, sabitTarih.tarih, sabitSaat.saat, sabitDers.id as DersId, sabitDers.adi FROM sabitTarih INNER JOIN (sabitSaat INNER JOIN (sabitDers INNER JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) ON sabitSaat.id = dersDagitim.saatId) ON sabitTarih.id = dersDagitim.tarihId;";
            return helper.ExecuteReader(sql);
        }

        public DataTable KayitlariGetir()
        {
            //string sql = "SELECT dersDagitim.id AS DersDagitimId, sabitDers.adi as SabitDersAdi, sabitBolum.ad as SabitBolumAdi, zaman.gTarih AS Tarih, zaman.gSaat AS Saat FROM sabitBolum INNER JOIN (zaman INNER JOIN (sabitDers INNER JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) ON zaman.id = dersDagitim.zamanId) ON sabitBolum.id = sabitDers.bolum;";
            //string sql = "SELECT dersDagitim.id AS DersDagitimId, sabitDers.adi AS SabitDersAdi, sabitBolum.ad AS SabitBolumAdi, sabitTarih.tarih, sabitSaat.saat FROM sabitTarih INNER JOIN (sabitSaat INNER JOIN ((sabitBolum INNER JOIN sabitDers ON sabitBolum.id = sabitDers.bolum) INNER JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) ON sabitSaat.id = dersDagitim.saatId) ON sabitTarih.id = dersDagitim.tarihId order by sabitTarih.tarih;";
            string sql = "SELECT dersDagitim.id AS DersDagitimId, sabitDers.adi AS SabitDersAdi, sabitBolum.ad AS SabitBolumAdi, sabitTarih.tarih, sabitSaat.saat, sabitDersGrubu.grup, dersDagitim.turu, sabitSinavSekli.adi as SinavSekli FROM sabitSinavSekli INNER JOIN (sabitDersGrubu INNER JOIN (sabitTarih INNER JOIN (sabitSaat INNER JOIN ((sabitBolum INNER JOIN sabitDers ON sabitBolum.id = sabitDers.bolum) INNER JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) ON sabitSaat.id = dersDagitim.saatId) ON sabitTarih.id = dersDagitim.tarihId) ON sabitDersGrubu.id = sabitDers.seviye) ON sabitSinavSekli.id = dersDagitim.sekli;";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public DataTable KayitlariSinavDegistirIcinGetir()
        {
            //string sql = "SELECT dersDagitim.id AS DersDagitimId, sabitDers.adi as SabitDersAdi, sabitBolum.ad as SabitBolumAdi, zaman.gTarih AS Tarih, zaman.gSaat AS Saat FROM sabitBolum INNER JOIN (zaman INNER JOIN (sabitDers INNER JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) ON zaman.id = dersDagitim.zamanId) ON sabitBolum.id = sabitDers.bolum;";
            //string sql = "SELECT dersDagitim.id AS DersDagitimId, sabitDers.adi AS SabitDersAdi, sabitBolum.ad AS SabitBolumAdi, sabitTarih.tarih, sabitSaat.saat FROM sabitTarih INNER JOIN (sabitSaat INNER JOIN ((sabitBolum INNER JOIN sabitDers ON sabitBolum.id = sabitDers.bolum) INNER JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) ON sabitSaat.id = dersDagitim.saatId) ON sabitTarih.id = dersDagitim.tarihId order by sabitTarih.tarih;";
            //string sql = "SELECT dersDagitim.id AS DersDagitimId, dersDagitim.dersId as DersId, dersDagitim.oturum, sabitDers.adi AS SabitDersAdi, sabitBolum.ad AS SabitBolumAdi, sabitTarih.id as TarihId, sabitTarih.tarih, sabitSaat.id as SaatId, sabitSaat.saat, sabitDersGrubu.grup, dersDagitim.turu, sabitSinavSekli.id as sabitSinavSekliId, sabitSinavSekli.adi as SinavSekli FROM sabitSinavSekli INNER JOIN (sabitDersGrubu INNER JOIN (sabitTarih INNER JOIN (sabitSaat INNER JOIN ((sabitBolum INNER JOIN sabitDers ON sabitBolum.id = sabitDers.bolum) INNER JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) ON sabitSaat.id = dersDagitim.saatId) ON sabitTarih.id = dersDagitim.tarihId) ON sabitDersGrubu.id = sabitDers.seviye) ON sabitSinavSekli.id = dersDagitim.sekli;";
            string sql = "SELECT dersDagitim.id AS DersDagitimId, dersDagitim.dersId, dersDagitim.oturum, sabitDers.adi AS SabitDersAdi, sabitBolum.ad AS SabitBolumAdi, sabitTarih.id as TarihId, sabitTarih.tarih, sabitSaat.id as SaatId, sabitSaat.saat, sabitDersGrubu.grup, dersDagitim.turu, sabitSinavSekli.id as sabitSinavSekliId, sabitSinavSekli.adi as SinavSekli FROM sabitSinavSekli INNER JOIN (sabitDersGrubu INNER JOIN (sabitTarih INNER JOIN (sabitSaat INNER JOIN ((sabitBolum INNER JOIN sabitDers ON sabitBolum.id = sabitDers.bolum) INNER JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) ON sabitSaat.id = dersDagitim.saatId) ON sabitTarih.id = dersDagitim.tarihId) ON sabitDersGrubu.id = sabitDers.seviye) ON sabitSinavSekli.id = dersDagitim.sekli;";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public OleDbDataReader SinavDegisiklikIcinOturumlariGetir(int tarihId, int saatId)
        {
            string sql = "SELECT dersDagitim.oturum, dersDagitim.tarihId, dersDagitim.saatId FROM dersDagitim WHERE (dersDagitim.tarihId=@TarihId AND dersDagitim.saatId=@SaatId);";
            OleDbParameter[] par = new OleDbParameter[]{
            new OleDbParameter("@TarihId",OleDbType.Integer),
            new OleDbParameter("@SaatId",OleDbType.Integer)
               };
            par[0].Value = tarihId;
            par[1].Value = saatId;
            return helper.ExecuteReader(sql, par);
        }

        public OleDbDataReader SinavDegisiklikIcinTarihleriGetir(int oturum, int saatId)
        {
            string sql = "SELECT sabitTarih.tarih, dersDagitim.saatId, dersDagitim.oturum FROM sabitTarih INNER JOIN dersDagitim ON sabitTarih.id = dersDagitim.tarihId WHERE (((dersDagitim.saatId)=@SaatId) AND ((dersDagitim.oturum)=@Oturum));";

            OleDbParameter[] par = new OleDbParameter[]{
            new OleDbParameter("@SaatId",OleDbType.Integer),
            new OleDbParameter("@Oturum",OleDbType.Integer)
            
               };
            par[0].Value = saatId;
            par[1].Value = oturum;
            return helper.ExecuteReader(sql, par);
        }

        public OleDbDataReader SinavDegisiklikIcinSaatleriGetir(int oturum, int tarihId)
        {
            string sql = "SELECT sabitSaat.saat, dersDagitim.tarihId, dersDagitim.oturum FROM sabitSaat INNER JOIN dersDagitim ON sabitSaat.id = dersDagitim.saatId WHERE (((dersDagitim.tarihId)=@TarihId) AND ((dersDagitim.oturum)=@Oturum));";
            OleDbParameter[] par = new OleDbParameter[]{
            new OleDbParameter("@TarihId",OleDbType.Integer),
            new OleDbParameter("@Oturum",OleDbType.Integer)            
               };
            par[0].Value = tarihId;
            par[1].Value = oturum;
            return helper.ExecuteReader(sql, par);
        }

        public DataTable SeciliDerseAitOgretmenleriGetir(int bId)
        {
            string sql = "SELECT dersDagitim.id as DersDagitimId, sabitOgretmen.adi as SabitOgretmenAdi, dersDagitimOgretmen.gorevTuru, dersDagitimOgretmen.ogretmenId FROM sabitOgretmen INNER JOIN (dersDagitim INNER JOIN dersDagitimOgretmen ON dersDagitim.id = dersDagitimOgretmen.dersDagitimId) ON sabitOgretmen.id = dersDagitimOgretmen.ogretmenId WHERE (((dersDagitim.id)=@Id));";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            return helper.ExecuteDataSet(sql, p).Tables[0];
        }

        public OleDbDataReader  SeciliDerseAitOgretmenleriTekTekGetir(int bId)
        {
            string sql = "SELECT dersDagitim.id as DersDagitimId, sabitOgretmen.adi as SabitOgretmenAdi, dersDagitimOgretmen.gorevTuru, dersDagitimOgretmen.ogretmenId FROM sabitOgretmen INNER JOIN (dersDagitim INNER JOIN dersDagitimOgretmen ON dersDagitim.id = dersDagitimOgretmen.dersDagitimId) ON sabitOgretmen.id = dersDagitimOgretmen.ogretmenId WHERE (((dersDagitim.id)=@Id));";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            return helper.ExecuteReader(sql, p);
        }

        public DataTable DersEklenecekleriGetir()
        {
            //string sql = "select sabitDers.id, sabitDers.adi from sabitDers where not exists(select * from dersDagitim where sabitDers.id = dersDagitim.dersId)";
            string sql = "SELECT sabitDers.id as DersId, sabitDers.adi  as DersAdi, sabitDersGrubu.grup as Grup FROM sabitDersGrubu INNER JOIN sabitDers ON sabitDersGrubu.id = sabitDers.seviye WHERE (((Exists (select * from dersDagitim where sabitDers.id = dersDagitim.dersId))=False));";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public DataTable OgretmenleriGetir(string tarihId, string saatId)
        {
            // string sql = "Select SabitOgretmen.id as OgretmenId, SabitOgretmen.adi as OgretmenAdi from SabitOgretmen  where sabitOgretmen.id <>  ALL (SELECT sabitOgretmen.id FROM zaman INNER JOIN (dersDagitim INNER JOIN (sabitOgretmen INNER JOIN dersDagitimOgretmen ON sabitOgretmen.id = dersDagitimOgretmen.ogretmenId) ON dersDagitim.id = dersDagitimOgretmen.dersDagitimId) ON zaman.id = dersDagitim.zamanId WHERE (((zaman.gTarih)=@TarihId) AND ((zaman.gSaat)=@SaatId)))";
            string sql = "SELECT SabitOgretmen.id as OgretmenId, SabitOgretmen.adi as OgretmenAdi FROM SabitOgretmen WHERE (((SabitOgretmen.id)<>All (SELECT sabitOgretmen.id FROM sabitTarih INNER JOIN (sabitSaat INNER JOIN (dersDagitim INNER JOIN (sabitOgretmen INNER JOIN dersDagitimOgretmen ON sabitOgretmen.id = dersDagitimOgretmen.ogretmenId) ON dersDagitim.id = dersDagitimOgretmen.dersDagitimId) ON sabitSaat.id = dersDagitim.saatId) ON sabitTarih.id = dersDagitim.tarihId WHERE (((sabitTarih.tarih)=@TarihId) AND ((sabitSaat.saat)=@SaatId)))));";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@TarihId",OleDbType.VarChar,100),
            new OleDbParameter("@SaatId",OleDbType.VarChar,100)
               };
            par[0].Value = tarihId;
            par[1].Value = saatId;
            return helper.ExecuteDataSet(sql, par).Tables[0];
        }

        public OleDbDataReader DersleriBul(string tarihId, string saatId)
        {
            string sql = "SELECT dersDagitim.id, sabitTarih.tarih, sabitSaat.saat FROM sabitSaat INNER JOIN (sabitTarih INNER JOIN dersDagitim ON sabitTarih.id = dersDagitim.tarihId) ON sabitSaat.id = dersDagitim.saatId WHERE (((sabitTarih.tarih)=@TarihId) AND ((sabitSaat.saat)=@SaatId));";
            OleDbParameter[] par = new OleDbParameter[]{
            new OleDbParameter("@TarihId",OleDbType.VarChar,100),
            new OleDbParameter("@SaatId",OleDbType.VarChar,100)
               };
            par[0].Value = tarihId;
            par[1].Value = saatId;
            return helper.ExecuteReader(sql, par);
        }

        public OleDbDataReader DersGetir(int bId)
        {
            //string sql = "SELECT sabitDers.id, sabitDers.kodu, sabitDers.adi as DersAdi, sabitDersGrubu.grup as DersGrup, sabitDers.sure, sabitDers.grup, sabitBolum.ad as BolumAdi, sabitDers.seviye, sabitDers.bolum FROM sabitBolum INNER JOIN (sabitDersGrubu INNER JOIN sabitDers ON sabitDersGrubu.id = sabitDers.seviye) ON sabitBolum.id = sabitDers.bolum where sabitDers.id=@Id";
            //string sql = "SELECT sabitDers.id, sabitDers.kodu, sabitDers.adi AS DersAdi, sabitDersGrubu.grup AS DersGrup, sabitDers.sure, sabitDers.grup, sabitBolum.ad AS BolumAdi, sabitDers.seviye, sabitDers.bolum, dersDagitim.turu, dersDagitim.sekli FROM (sabitDersGrubu INNER JOIN (sabitBolum INNER JOIN sabitDers ON sabitBolum.id = sabitDers.bolum) ON sabitDersGrubu.id = sabitDers.seviye) INNER JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId WHERE (((sabitDers.id)=@Id));";
            string sql = "SELECT sabitDers.id, sabitDers.kodu, sabitDers.adi AS DersAdi, sabitDersGrubu.grup AS DersGrup, sabitDers.sure, sabitDers.grup, sabitBolum.ad AS BolumAdi, sabitDers.seviye, sabitDers.bolum, dersDagitim.turu, sabitSinavSekli.adi as SinavSekli FROM sabitSinavSekli INNER JOIN ((sabitDersGrubu INNER JOIN (sabitBolum INNER JOIN sabitDers ON sabitBolum.id = sabitDers.bolum) ON sabitDersGrubu.id = sabitDers.seviye) INNER JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) ON sabitSinavSekli.id = dersDagitim.sekli WHERE (((sabitDers.id)=@Id));";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            return helper.ExecuteReader(sql, p);
        }

        public DataTable SeciliDersleriGetir(int bId)
        {
            //string sql = "SELECT dersDagitimOgretmen.id, dersDagitimOgretmen.ogretmenId, sabitDers.adi AS DersAdi, zaman.gTarih AS Tarih, zaman.gSaat AS Saat, dersDagitim.turu AS SinavSekli, sabitDersGrubu.grup AS SinifSeviye, dersDagitimOgretmen.gorevTuru AS DersDagitimOgretmenGorevTuru FROM (zaman INNER JOIN ((sabitDersGrubu INNER JOIN sabitDers ON sabitDersGrubu.id = sabitDers.seviye) INNER JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) ON zaman.id = dersDagitim.zamanId) INNER JOIN dersDagitimOgretmen ON dersDagitim.id = dersDagitimOgretmen.dersDagitimId WHERE (((dersDagitimOgretmen.ogretmenId)=@Id));";
            string sql = "SELECT dersDagitimOgretmen.id, dersDagitimOgretmen.ogretmenId, sabitDers.adi AS DersAdi, sabitTarih.tarih, sabitSaat.saat, dersDagitim.turu AS SinavSekli, sabitDersGrubu.grup AS SinifSeviye, dersDagitimOgretmen.gorevTuru AS DersDagitimOgretmenGorevTuru FROM sabitSaat INNER JOIN (sabitTarih INNER JOIN (((sabitDersGrubu INNER JOIN sabitDers ON sabitDersGrubu.id = sabitDers.seviye) INNER JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) INNER JOIN dersDagitimOgretmen ON dersDagitim.id = dersDagitimOgretmen.dersDagitimId) ON sabitTarih.id = dersDagitim.tarihId) ON sabitSaat.id = dersDagitim.saatId WHERE (((dersDagitimOgretmen.ogretmenId)=@Id)) order by  Cdate(sabitTarih.tarih), Cdate(sabitSaat.saat);";

            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            return helper.ExecuteDataSet(sql, p).Tables[0];
        }

        public DataTable KomisyonGetir(int bId)
        {
            string sql = "SELECT dersDagitimOgretmen.id as dersDagitimOgretmenId, sabitOgretmen.adi as OgretmenAdi, dersDagitim.id, dersDagitimOgretmen.gorevTuru FROM sabitOgretmen INNER JOIN (dersDagitim INNER JOIN dersDagitimOgretmen ON dersDagitim.id = dersDagitimOgretmen.dersDagitimId) ON sabitOgretmen.id = dersDagitimOgretmen.ogretmenId WHERE (((dersDagitim.id)=@Id) AND ((dersDagitimOgretmen.gorevTuru)=\"Komisyon\"));";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            return helper.ExecuteDataSet(sql, p).Tables[0];
        }

        public DataTable GozcuGetir(int bId)
        {
            string sql = "SELECT dersDagitimOgretmen.id as dersDagitimOgretmenId, sabitOgretmen.adi as OgretmenAdi, dersDagitim.id, dersDagitimOgretmen.gorevTuru FROM sabitOgretmen INNER JOIN (dersDagitim INNER JOIN dersDagitimOgretmen ON dersDagitim.id = dersDagitimOgretmen.dersDagitimId) ON sabitOgretmen.id = dersDagitimOgretmen.ogretmenId WHERE (((dersDagitim.id)=@Id) AND ((dersDagitimOgretmen.gorevTuru)=\"Gözcü\"));";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            return helper.ExecuteDataSet(sql, p).Tables[0];
        }

        public int KayitEkle(DersDagitimInfo dersDagitimBilgi)
        {
            string sql = "insert into dersDagitim (tarihId,SaatId,dersId,oturum,turu,sekli) Values (@TarihId, @SaatId, @DersId, @Oturum,@Turu,@Sekli)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@TarihId",OleDbType.Integer),
            new OleDbParameter("@SaatId",OleDbType.Integer),
            new OleDbParameter("@DersId",OleDbType.Integer),
            new OleDbParameter("@Oturum",OleDbType.Integer),
            new OleDbParameter("@Turu",OleDbType.VarChar,100),
            new OleDbParameter("@Sekli",OleDbType.Integer)
               };

            par[0].Value = dersDagitimBilgi.TarihId;
            par[1].Value = dersDagitimBilgi.SaatId;
            par[2].Value = dersDagitimBilgi.DersId;
            par[3].Value = dersDagitimBilgi.Oturum;
            par[4].Value = dersDagitimBilgi.Turu;
            par[5].Value = dersDagitimBilgi.Sekli;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitDegistir(DersDagitimInfo dersDagitimBilgi)
        {
            string sql = "Update dersDagitim Set tarihId=@TarihId,SaatId=@SaatId,dersId=@DersId,oturum=@Oturum,turu=@Turu,sekli=@Sekli where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@TarihId",OleDbType.Integer),
            new OleDbParameter("@SaatId",OleDbType.Integer),
            new OleDbParameter("@DersId",OleDbType.Integer),
            new OleDbParameter("@Oturum",OleDbType.Integer),
            new OleDbParameter("@Turu",OleDbType.VarChar,100),
            new OleDbParameter("@Sekli",OleDbType.Integer),
            new OleDbParameter("@Id",OleDbType.Integer)
               };

            par[0].Value = dersDagitimBilgi.TarihId;
            par[1].Value = dersDagitimBilgi.SaatId;
            par[2].Value = dersDagitimBilgi.DersId;
            par[3].Value = dersDagitimBilgi.Oturum;
            par[4].Value = dersDagitimBilgi.Turu;
            par[5].Value = dersDagitimBilgi.Sekli;
            par[6].Value = dersDagitimBilgi.Id;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitSil(int id)
        {
            string sql = "delete from dersDagitim where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }

        public DataTable OgretmenElPropgramiRapor(int bId)
        {
            string sql = "SELECT dersDagitim.turu as SinavSekli, dersDagitimOgretmen.ogretmenId, sabitOgretmen.adi as OgretmenAdi, sabitTarih.tarih, sabitSaat.saat, sabitDersGrubu.grup as Seviye, sabitBolum.ad as BolumAdi, sabitDers.adi as DersAdi, dersDagitimOgretmen.gorevTuru FROM sabitTarih INNER JOIN (sabitSaat INNER JOIN (sabitOgretmen INNER JOIN (sabitDersGrubu INNER JOIN ((sabitBolum INNER JOIN sabitDers ON sabitBolum.id = sabitDers.bolum) INNER JOIN (dersDagitim INNER JOIN dersDagitimOgretmen ON dersDagitim.id = dersDagitimOgretmen.dersDagitimId) ON sabitDers.id = dersDagitim.dersId) ON sabitDersGrubu.id = sabitDers.seviye) ON sabitOgretmen.id = dersDagitimOgretmen.ogretmenId) ON sabitSaat.id = dersDagitim.saatId) ON sabitTarih.id = dersDagitim.tarihId WHERE (((dersDagitimOgretmen.ogretmenId)=@Id)) order by CDate(sabitTarih.tarih), Cdate(sabitSaat.saat);";

            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            return helper.ExecuteDataSet(sql, p).Tables[0];
        }
        //**************************************************
        public DataTable SinavIlanCizelgesiRapor()
        {
          //  string sql = "SELECT sabitTarih.tarih, sabitSaat.saat, sabitBolum.ad as BolumAdi, sabitDersGrubu.grup as Sinif, sabitDers.adi as Ders, dersDagitim.turu as SinavTuru, dersDagitim.sekli FROM sabitDersGrubu RIGHT JOIN ((sabitBolum RIGHT JOIN sabitDers ON sabitBolum.id = sabitDers.bolum) RIGHT JOIN (sabitSaat RIGHT JOIN (sabitTarih RIGHT JOIN dersDagitim ON sabitTarih.id = dersDagitim.tarihId) ON sabitSaat.id = dersDagitim.saatId) ON sabitDers.id = dersDagitim.dersId) ON sabitDersGrubu.id = sabitDers.seviye;";
            string sql = "SELECT sabitTarih.tarih, sabitSaat.saat, sabitBolum.ad AS BolumAdi, sabitDersGrubu.grup AS Sinif, sabitDers.adi AS Ders, dersDagitim.turu AS SinavTuru, sabitSinavSekli.adi as Sekli FROM sabitSinavSekli INNER JOIN (sabitTarih RIGHT JOIN (sabitSaat RIGHT JOIN (sabitDersGrubu RIGHT JOIN ((sabitBolum RIGHT JOIN sabitDers ON sabitBolum.id = sabitDers.bolum) RIGHT JOIN dersDagitim ON sabitDers.id = dersDagitim.dersId) ON sabitDersGrubu.id = sabitDers.seviye) ON sabitSaat.id = dersDagitim.saatId) ON sabitTarih.id = dersDagitim.tarihId) ON sabitSinavSekli.id = dersDagitim.sekli order by Cdate(sabitTarih.Tarih) asc,cdate(sabitSaat.saat) asc;";

           return helper.ExecuteDataSet(sql).Tables[0];
        }
        public DataTable SinavaGirmesiGerekenlerRapor()
        {
            string sql = "SELECT sabitOgrenci.adsoyad as ogrAdi, sabitOgrenci.numara as ogrNo, sabitSinif.adi as ogrSinif, sabitDers.adi as dersAdi, sabitDersGrubu.grup, sabitTarih.tarih, sabitSaat.saat FROM sabitDersGrubu INNER JOIN (sabitSinif INNER JOIN ((sabitDers INNER JOIN (sabitOgrenci INNER JOIN ogrenciDers ON sabitOgrenci.id = ogrenciDers.idx) ON sabitDers.id = ogrenciDers.ders) INNER JOIN (sabitSaat INNER JOIN (sabitTarih INNER JOIN dersDagitim ON sabitTarih.id = dersDagitim.tarihId) ON sabitSaat.id = dersDagitim.saatId) ON sabitDers.id = dersDagitim.dersId) ON sabitSinif.id = sabitOgrenci.sinif) ON sabitDersGrubu.id = sabitDers.seviye;";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

    }
}
