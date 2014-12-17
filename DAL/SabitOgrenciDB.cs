using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Batl.Info;
using System.Data;
using System.Data.OleDb;


namespace Batl.DAL
{
    public class SabitOgrenciDB
    {
        HelperDB helper = new HelperDB();

        public DataTable KayitlariGetir()
        {
            string sql = "SELECT sabitOgrenci.id, sabitOgrenci.numara, sabitOgrenci.sinif, sabitOgrenci.adsoyad, sabitOgrenci.ders, sabitOgrenci.notu, sabitSinif.adi FROM sabitSinif INNER JOIN sabitOgrenci ON sabitSinif.id = sabitOgrenci.sinif order by sabitOgrenci.adsoyad";
            return helper.ExecuteDataSet(sql).Tables[0];
        }
        public SabitOgrenciInfo KayitGetir(int bId)
        {
            string sql = "Select * from sabitOgrenci where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            OleDbDataReader dr = helper.ExecuteReader(sql, p);
            SabitOgrenciInfo sabitOgrenciBilgi = new SabitOgrenciInfo();
            if (dr.Read())
            {
                sabitOgrenciBilgi.Numara = GenelOzelIsler.GetString(dr, "numara");
                sabitOgrenciBilgi.Sinif = GenelOzelIsler.GetInteger(dr, "sinif");
                sabitOgrenciBilgi.Adsoyad = GenelOzelIsler.GetString(dr, "adsoyad");
                sabitOgrenciBilgi.Ders= GenelOzelIsler.GetString(dr, "ders");
                sabitOgrenciBilgi.Notu = GenelOzelIsler.GetString(dr, "notu");
                sabitOgrenciBilgi.Id = bId;
            }
            dr.Close();
            return sabitOgrenciBilgi;
        }

        public int KayitDegistir(SabitOgrenciInfo sabitOgrenciBilgi)
        {
            // (okulAdi1, okulAdi2, il, ilce, tel, ogretimYili, sinavDonemi, sinavBaslamaTarihi, sinavBitisTarihi, ucretGozcu, ucretKomisyon, raporBaslik1, raporBaslik2, raporBaslik3, raporBaslik4, sayi, konu, tarih, dipnot, mudur, maksimumSaat, maksimumOgrencininGirecegiSinav, uay, utarih) Values (@Okuladi1, @Okuladi2, @Il, @Ilce, @Tel, @Ogretimyili, @Sinavdonemi, @Sinavbaslamatarihi, @Sinavbitistarihi, @Ucretgozcu, @Ucretkomisyon, @Raporbaslik1, @Raporbaslik2, @Raporbaslik3, @Raporbaslik4, @Sayi, @Konu, @Tarih, @Dipnot, @Mudur, @Maksimumsaat, @Maksimumogrenciningirecegisinav, @Uay, @Utarih)

            string sql = "Update sabitOgrenci Set numara=@Numara, sinif=@Sinif, adsoyad=@AdSoyad, ders=@Ders, notu=@Notu where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Numara",OleDbType.VarChar,100),
            new OleDbParameter("@Sinif",OleDbType.Integer),
            new OleDbParameter("@AdSoyad",OleDbType.VarChar,100),
            new OleDbParameter("@Ders",OleDbType.VarChar,100),
            new OleDbParameter("@Notu",OleDbType.VarChar,100),
            new OleDbParameter("@Id",OleDbType.Integer)
            };

            par[0].Value = sabitOgrenciBilgi.Numara ;
            par[1].Value = sabitOgrenciBilgi.Sinif;
            par[2].Value = sabitOgrenciBilgi.Adsoyad;
            par[3].Value = sabitOgrenciBilgi.Ders;
            par[4].Value = sabitOgrenciBilgi.Notu;
            par[5].Value = sabitOgrenciBilgi.Id;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitEkle(SabitOgrenciInfo sabitOgrenciBilgi)
        {
            string sql = "insert into sabitOgrenci (numara, sinif, adsoyad, ders, notu) Values (@Numara, @Sinif, @AdSoyad, @Ders, @Notu)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Numara",OleDbType.VarChar,100),
            new OleDbParameter("@Sinif",OleDbType.Integer),
            new OleDbParameter("@AdSoyad",OleDbType.VarChar,100),
            new OleDbParameter("@Ders",OleDbType.VarChar,100),
            new OleDbParameter("@Notu",OleDbType.VarChar,100)        
            };

            par[0].Value = sabitOgrenciBilgi.Numara;
            par[1].Value = sabitOgrenciBilgi.Sinif;
            par[2].Value = sabitOgrenciBilgi.Adsoyad;
            par[3].Value = sabitOgrenciBilgi.Ders;
            par[4].Value = sabitOgrenciBilgi.Notu;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitSil(int id)
        {
            string sql = "delete from sabitOgrenci where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }
    }


}
