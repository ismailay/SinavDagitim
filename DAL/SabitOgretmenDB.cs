using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Batl.Info;
using System.Data;
using System.Data.OleDb;

namespace Batl.DAL
{
    public class SabitOgretmenDB
    {
        HelperDB helper = new HelperDB();

        public int KayitDegistirYeniGorev(int komisyonGorevSayisi, int gozcuGorevSayisi, int ogrId)
        {
            string sql = "Update sabitOgretmen Set yeniKomisyonGorevi=@YeniKomisyonGorevi, yeniGozcuGorevi=@YeniGozcuGorevi  where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
            new OleDbParameter("@YeniKomisyonGorevi",OleDbType.Integer),
            new OleDbParameter("@YeniGozcuGorevi",OleDbType.Integer),
            new OleDbParameter("@Id",OleDbType.Integer)
            };

            par[0].Value = komisyonGorevSayisi;
            par[1].Value = gozcuGorevSayisi;
            par[2].Value = ogrId;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitDegistirEskiGorev(int komisyonGorevSayisi, int gozcuGorevSayisi, int ogrId)
        {
            string sql = "Update sabitOgretmen Set eskiKomisyonGorevi=@EskiKomisyonGorevi, eskiGozcuGorevi=@EskiGozcuGorevi  where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
            new OleDbParameter("@EskiKomisyonGorevi",OleDbType.Integer),
            new OleDbParameter("@EskiGozcuGorevi",OleDbType.Integer),
            new OleDbParameter("@Id",OleDbType.Integer)
            };

            par[0].Value = komisyonGorevSayisi;
            par[1].Value = gozcuGorevSayisi;
            par[2].Value = ogrId;
            return helper.ExecuteNonQuery(sql, par);
        }

        public DataTable OgretmenGorevSayisi(int ogrId, string gorevTuru)
        {
            string sql = "SELECT Count(dersDagitimOgretmen.ogretmenId) AS Toplam FROM dersDagitimOgretmen GROUP BY dersDagitimOgretmen.ogretmenId, dersDagitimOgretmen.gorevTuru HAVING (((dersDagitimOgretmen.ogretmenId)=@OgretmenId) AND ((dersDagitimOgretmen.gorevTuru)=@GorevTuru));";
            OleDbParameter[] par = new OleDbParameter[]{
                new OleDbParameter("@OgretmenId",OleDbType.Integer),
                new OleDbParameter("@GorevTuru",OleDbType.VarChar,100)
                };
            par[0].Value = ogrId;
            par[1].Value = gorevTuru;
            return helper.ExecuteDataSet(sql, par).Tables[0];
        }

        public OleDbDataReader KayitlariTekTekGetir()
        {
            string sql = "SELECT * FROM sabitOgretmen order by adi";
            return helper.ExecuteReader(sql);
        }

        public DataTable KayitlariGetir()
        {
            string sql = "SELECT * FROM sabitOgretmen order by adi";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public SabitOgretmenInfo KayitGetir(int bId)
        {
            string sql = "Select * from sabitOgretmen where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            OleDbDataReader dr = helper.ExecuteReader(sql, p);
            SabitOgretmenInfo sabitOgretmenBilgi = new SabitOgretmenInfo();
            if (dr.Read())
            {
                sabitOgretmenBilgi.Adi = GenelOzelIsler.GetString(dr, "adi");
                sabitOgretmenBilgi.Bolum = GenelOzelIsler.GetString(dr, "bolum");
                sabitOgretmenBilgi.Grup = GenelOzelIsler.GetString(dr, "grup");
                sabitOgretmenBilgi.EskiGozcuGorevi = GenelOzelIsler.GetInteger(dr, "eskiGozcuGorevi");
                sabitOgretmenBilgi.EskiKomisyonGorevi = GenelOzelIsler.GetInteger(dr, "eskiKomisyonGorevi");
                sabitOgretmenBilgi.YeniKomisyonGorevi = GenelOzelIsler.GetInteger(dr, "yeniKomisyonGorevi");
                sabitOgretmenBilgi.YeniGozcuGorevi = GenelOzelIsler.GetInteger(dr, "yeniGozcuGorevi");
                sabitOgretmenBilgi.Id = bId;
            }
            dr.Close();
            return sabitOgretmenBilgi;
        }

        public int KayitDegistir(SabitOgretmenInfo sabitOgretmenBilgi)
        {
            // (okulAdi1, okulAdi2, il, ilce, tel, ogretimYili, sinavDonemi, sinavBaslamaTarihi, sinavBitisTarihi, ucretGozcu, ucretKomisyon, raporBaslik1, raporBaslik2, raporBaslik3, raporBaslik4, sayi, konu, tarih, dipnot, mudur, maksimumSaat, maksimumOgrencininGirecegiSinav, uay, utarih) Values (@Okuladi1, @Okuladi2, @Il, @Ilce, @Tel, @Ogretimyili, @Sinavdonemi, @Sinavbaslamatarihi, @Sinavbitistarihi, @Ucretgozcu, @Ucretkomisyon, @Raporbaslik1, @Raporbaslik2, @Raporbaslik3, @Raporbaslik4, @Sayi, @Konu, @Tarih, @Dipnot, @Mudur, @Maksimumsaat, @Maksimumogrenciningirecegisinav, @Uay, @Utarih)

            string sql = "Update sabitOgretmen Set adi=@Adi, bolum=@Bolum, grup=@Grup, eskiKomisyonGorevi=@EskiKomisyonGorevi, eskiGozcuGorevi=@EskiGozcuGorevi, yeniKomisyonGorevi=@YeniKomisyonGorevi, yeniGozcuGorevi=@YeniGozcuGorevi  where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Adi",OleDbType.VarChar,100),
            new OleDbParameter("@Bolum",OleDbType.VarChar,100),
            new OleDbParameter("@Grup",OleDbType.VarChar,100),
            new OleDbParameter("@EskiKomisyonGorevi",OleDbType.Integer),
            new OleDbParameter("@EskiGozcuGorevi",OleDbType.Integer),
            new OleDbParameter("@YeniKomisyonGorevi",OleDbType.Integer),
            new OleDbParameter("@YeniGozcuGorevi",OleDbType.Integer),
            new OleDbParameter("@Id",OleDbType.Integer)
            };

            par[0].Value = sabitOgretmenBilgi.Adi;
            par[1].Value = sabitOgretmenBilgi.Bolum;
            par[2].Value = sabitOgretmenBilgi.Grup;
            par[3].Value = sabitOgretmenBilgi.EskiKomisyonGorevi;
            par[4].Value = sabitOgretmenBilgi.EskiGozcuGorevi;
            par[5].Value = sabitOgretmenBilgi.YeniKomisyonGorevi;
            par[6].Value = sabitOgretmenBilgi.YeniGozcuGorevi;
            par[7].Value = sabitOgretmenBilgi.Id;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitEkle(SabitOgretmenInfo sabitOgretmenBilgi)
        {
            string sql = "insert into sabitOgretmen (adi, bolum, grup, eskiKomisyonGorevi, eskiGozcuGorevi, yeniKomisyonGorevi, yeniGozcuGorevi) Values (@Adi, @Bolum, @Grup, @EskiKomisyonGorevi, @EskiGozcuGorevi, @YeniKomisyonGorevi, @YeniGozcuGorevi)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Adi",OleDbType.VarChar,100),
            new OleDbParameter("@Bolum",OleDbType.VarChar,100),
            new OleDbParameter("@Grup",OleDbType.VarChar,100),   
            new OleDbParameter("@EskiKomisyonGorevi",OleDbType.Integer),
            new OleDbParameter("@EskiGozcuGorevi",OleDbType.Integer),
            new OleDbParameter("@YeniKomisyonGorevi",OleDbType.Integer),
            new OleDbParameter("@YeniGozcuGorevi",OleDbType.Integer),
            };

            par[0].Value = sabitOgretmenBilgi.Adi;
            par[1].Value = sabitOgretmenBilgi.Bolum;
            par[2].Value = sabitOgretmenBilgi.Grup;
            par[3].Value = sabitOgretmenBilgi.EskiKomisyonGorevi;
            par[4].Value = sabitOgretmenBilgi.EskiGozcuGorevi;
            par[5].Value = sabitOgretmenBilgi.YeniKomisyonGorevi;
            par[6].Value = sabitOgretmenBilgi.YeniGozcuGorevi;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitSil(int id)
        {
            string sql = "delete from sabitOgretmen where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }

    }
}
