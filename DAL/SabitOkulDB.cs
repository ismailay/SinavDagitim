using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Batl.Info;

namespace Batl.DAL
{
    public class SabitOkulDB
    {
        HelperDB helper = new HelperDB();

        public DataTable RaporIcinKayitlariGetir()
        {
            string sql = "SELECT sabitOkul.okulAdi1, sabitOkul.okulAdi2, sabitOkul.ogretimYili,  sabitOkul.sinavDonemi, sabitOkul.raporBaslik1, sabitOkul.raporBaslik2, sabitOkul.raporBaslik3, sabitOkul.mudur, sabitOkul.dipnot, sabitOkul.sayi FROM sabitOkul;";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public DataTable KayitlariGetir()
        {
            string sql = "SELECT * FROM sabitOkul";
            return helper.ExecuteDataSet(sql).Tables[0];
        }
        public SabitOkulInfo KayitGetir(int bId)
        {
            string sql = "Select * from sabitOkul where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            OleDbDataReader dr = helper.ExecuteReader(sql, p);
            SabitOkulInfo sabitOkulBilgi = new SabitOkulInfo();
            if (dr.Read())
            {
                sabitOkulBilgi.OkulAdi1 = GenelOzelIsler.GetString(dr, "okulAdi1");
                sabitOkulBilgi.OkulAdi2 = GenelOzelIsler.GetString(dr, "okulAdi2");
                sabitOkulBilgi.Il = GenelOzelIsler.GetString(dr, "il");
                sabitOkulBilgi.Ilce = GenelOzelIsler.GetString(dr, "ilce");
                sabitOkulBilgi.Tel = GenelOzelIsler.GetString(dr, "tel");
                sabitOkulBilgi.OgretimYili = GenelOzelIsler.GetString(dr, "ogretimYili");
                sabitOkulBilgi.SinavDonemi = GenelOzelIsler.GetString(dr, "sinavDonemi");
                sabitOkulBilgi.SinavBaslamaTarihi = GenelOzelIsler.GetDateTime(dr, "sinavBaslamaTarihi");
                sabitOkulBilgi.SinavBitisTarihi = GenelOzelIsler.GetDateTime(dr, "sinavBitisTarihi");
                sabitOkulBilgi.UcretGozcu = GenelOzelIsler.GetString(dr, "ucretGozcu");
                sabitOkulBilgi.UcretKomisyon = GenelOzelIsler.GetString(dr, "ucretKomisyon");
                sabitOkulBilgi.RaporBaslik1 = GenelOzelIsler.GetString(dr, "raporBaslik1");
                sabitOkulBilgi.RaporBaslik2 = GenelOzelIsler.GetString(dr, "raporBaslik2");
                sabitOkulBilgi.RaporBaslik3 = GenelOzelIsler.GetString(dr, "raporBaslik3");
                sabitOkulBilgi.RaporBaslik4 = GenelOzelIsler.GetString(dr, "raporBaslik4");
                sabitOkulBilgi.Sayi = GenelOzelIsler.GetString(dr, "sayi");
                sabitOkulBilgi.Konu = GenelOzelIsler.GetString(dr, "konu");
                sabitOkulBilgi.Tarih = GenelOzelIsler.GetString(dr, "tarih");
                sabitOkulBilgi.Dipnot = GenelOzelIsler.GetString(dr, "dipnot");
                sabitOkulBilgi.Mudur = GenelOzelIsler.GetString(dr, "mudur");
                sabitOkulBilgi.MaksimumSaat = GenelOzelIsler.GetString(dr, "maksimumSaat");
                sabitOkulBilgi.MaksimumOgrencininGirecegiSinav = GenelOzelIsler.GetString(dr, "maksimumOgrencininGirecegiSinav");
                sabitOkulBilgi.Uay = GenelOzelIsler.GetString(dr, "uay");
                sabitOkulBilgi.Utarih = GenelOzelIsler.GetDateTime(dr, "utarih");
                sabitOkulBilgi.Id = bId;
            }
            dr.Close();
            return sabitOkulBilgi;
        }

        public int KayitDegistir(SabitOkulInfo sabitOkulBilgi)
        {
            // (okulAdi1, okulAdi2, il, ilce, tel, ogretimYili, sinavDonemi, sinavBaslamaTarihi, sinavBitisTarihi, ucretGozcu, ucretKomisyon, raporBaslik1, raporBaslik2, raporBaslik3, raporBaslik4, sayi, konu, tarih, dipnot, mudur, maksimumSaat, maksimumOgrencininGirecegiSinav, uay, utarih) Values (@Okuladi1, @Okuladi2, @Il, @Ilce, @Tel, @Ogretimyili, @Sinavdonemi, @Sinavbaslamatarihi, @Sinavbitistarihi, @Ucretgozcu, @Ucretkomisyon, @Raporbaslik1, @Raporbaslik2, @Raporbaslik3, @Raporbaslik4, @Sayi, @Konu, @Tarih, @Dipnot, @Mudur, @Maksimumsaat, @Maksimumogrenciningirecegisinav, @Uay, @Utarih)

            string sql = "Update sabitOkul Set okulAdi1=@Okuladi1, okulAdi2=@Okuladi2, il=@Il, ilce=@Ilce,  tel=@Tel, ogretimYili=@Ogretimyili, sinavDonemi=@Sinavdonemi, sinavBaslamaTarihi=@Sinavbaslamatarihi, sinavBitisTarihi=@Sinavbitistarihi, ucretGozcu=@Ucretgozcu, ucretKomisyon=@Ucretkomisyon, raporBaslik1=@Raporbaslik1, raporBaslik2=@Raporbaslik2, raporBaslik3=@Raporbaslik3, raporBaslik4=@Raporbaslik4, sayi=@Sayi, konu=@Konu, tarih=@Tarih, dipnot=@Dipnot, mudur=@Mudur, maksimumSaat=@Maksimumsaat, maksimumOgrencininGirecegiSinav=@Maksimumogrenciningirecegisinav, uay=@Uay, utarih=@Utarih where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Okuladi1",OleDbType.VarChar,100),
            new OleDbParameter("@Okuladi2",OleDbType.VarChar,100),
            new OleDbParameter("@Il",OleDbType.VarChar,100),
            new OleDbParameter("@Ilce",OleDbType.VarChar,100),
            new OleDbParameter("@Tel",OleDbType.VarChar,100),
            new OleDbParameter("@Ogretimyili",OleDbType.VarChar,100),
            new OleDbParameter("@Sinavdonemi",OleDbType.VarChar,100),
            new OleDbParameter("@Sinavbaslamatarihi",OleDbType.Date),
            new OleDbParameter("@Sinavbitistarihi",OleDbType.Date),
            new OleDbParameter("@Ucretgozcu",OleDbType.VarChar,100),
            new OleDbParameter("@Ucretkomisyon",OleDbType.VarChar,100),
            new OleDbParameter("@Raporbaslik1",OleDbType.VarChar,1000),
            new OleDbParameter("@Raporbaslik2",OleDbType.VarChar,1000),
            new OleDbParameter("@Raporbaslik3",OleDbType.VarChar,1000),
            new OleDbParameter("@Raporbaslik4",OleDbType.VarChar,1000),
            new OleDbParameter("@Sayi",OleDbType.VarChar,100),
            new OleDbParameter("@Konu",OleDbType.VarChar,100),
            new OleDbParameter("@Tarih",OleDbType.VarChar,100),
            new OleDbParameter("@Dipnot",OleDbType.VarChar,2000),
            new OleDbParameter("@Mudur",OleDbType.VarChar,100),
            new OleDbParameter("@Maksimumsaat",OleDbType.VarChar,100),
            new OleDbParameter("@Maksimumogrenciningirecegisinav",OleDbType.VarChar,100),
            new OleDbParameter("@Uay",OleDbType.VarChar,100),
            new OleDbParameter("@Utarih",OleDbType.Date),
            new OleDbParameter("@Id",OleDbType.Integer)
            };

            par[0].Value = sabitOkulBilgi.OkulAdi1;
            par[1].Value = sabitOkulBilgi.OkulAdi2;
            par[2].Value = sabitOkulBilgi.Il;
            par[3].Value = sabitOkulBilgi.Ilce;
            par[4].Value = sabitOkulBilgi.Tel;
            par[5].Value = sabitOkulBilgi.OgretimYili;
            par[6].Value = sabitOkulBilgi.SinavDonemi;
            par[7].Value = sabitOkulBilgi.SinavBaslamaTarihi;
            par[8].Value = sabitOkulBilgi.SinavBitisTarihi;
            par[9].Value = sabitOkulBilgi.UcretGozcu;
            par[10].Value = sabitOkulBilgi.UcretKomisyon;
            par[11].Value = sabitOkulBilgi.RaporBaslik1;
            par[12].Value = sabitOkulBilgi.RaporBaslik2;
            par[13].Value = sabitOkulBilgi.RaporBaslik3;
            par[14].Value = sabitOkulBilgi.RaporBaslik4;
            par[15].Value = sabitOkulBilgi.Sayi;
            par[16].Value = sabitOkulBilgi.Konu;
            par[17].Value = sabitOkulBilgi.Tarih;
            par[18].Value = sabitOkulBilgi.Dipnot;
            par[19].Value = sabitOkulBilgi.Mudur;
            par[20].Value = sabitOkulBilgi.MaksimumSaat;
            par[21].Value = sabitOkulBilgi.MaksimumOgrencininGirecegiSinav;
            par[22].Value = sabitOkulBilgi.Uay;
            par[23].Value = sabitOkulBilgi.Utarih;
            par[24].Value = sabitOkulBilgi.Id;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitEkle(SabitOkulInfo sabitOkulBilgi)
        {
            string sql = "insert into sabitOkul (okulAdi1, okulAdi2, il, ilce, tel, ogretimYili, sinavDonemi, sinavBaslamaTarihi, sinavBitisTarihi, ucretGozcu, ucretKomisyon, raporBaslik1, raporBaslik2, raporBaslik3, raporBaslik4, sayi, konu, tarih, dipnot, mudur, maksimumSaat, maksimumOgrencininGirecegiSinav, uay, utarih) Values (@Okuladi1, @Okuladi2, @Il, @Ilce, @Tel, @Ogretimyili, @Sinavdonemi, @Sinavbaslamatarihi, @Sinavbitistarihi, @Ucretgozcu, @Ucretkomisyon, @Raporbaslik1, @Raporbaslik2, @Raporbaslik3, @Raporbaslik4, @Sayi, @Konu, @Tarih, @Dipnot, @Mudur, @Maksimumsaat, @Maksimumogrenciningirecegisinav, @Uay, @Utarih)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Okuladi1",OleDbType.VarChar,100),
            new OleDbParameter("@Okuladi2",OleDbType.VarChar,100),
            new OleDbParameter("@Il",OleDbType.VarChar,100),
            new OleDbParameter("@Ilce",OleDbType.VarChar,100),
            new OleDbParameter("@Tel",OleDbType.VarChar,100),
            new OleDbParameter("@Ogretimyili",OleDbType.VarChar,100),
            new OleDbParameter("@Sinavdonemi",OleDbType.VarChar,100),
            new OleDbParameter("@Sinavbaslamatarihi",OleDbType.Date),
            new OleDbParameter("@Sinavbitistarihi",OleDbType.Date),
            new OleDbParameter("@Ucretgozcu",OleDbType.VarChar,100),
            new OleDbParameter("@Ucretkomisyon",OleDbType.VarChar,100),
            new OleDbParameter("@Raporbaslik1",OleDbType.VarChar,1000),
            new OleDbParameter("@Raporbaslik2",OleDbType.VarChar,1000),
            new OleDbParameter("@Raporbaslik3",OleDbType.VarChar,1000),
            new OleDbParameter("@Raporbaslik4",OleDbType.VarChar,1000),
            new OleDbParameter("@Sayi",OleDbType.VarChar,100),
            new OleDbParameter("@Konu",OleDbType.VarChar,100),
            new OleDbParameter("@Tarih",OleDbType.VarChar,100),
            new OleDbParameter("@Dipnot",OleDbType.VarChar,2000),
            new OleDbParameter("@Mudur",OleDbType.VarChar,100),
            new OleDbParameter("@Maksimumsaat",OleDbType.VarChar,100),
            new OleDbParameter("@Maksimumogrenciningirecegisinav",OleDbType.VarChar,100),
            new OleDbParameter("@Uay",OleDbType.VarChar,100),
            new OleDbParameter("@Utarih",OleDbType.Date)
            };

            if (sabitOkulBilgi.OkulAdi1 == null) sabitOkulBilgi.OkulAdi1 = "";
            if (sabitOkulBilgi.OkulAdi2 == null) sabitOkulBilgi.OkulAdi2 = "";
            if (sabitOkulBilgi.Il == null) sabitOkulBilgi.Il = "";
            if (sabitOkulBilgi.Ilce == null) sabitOkulBilgi.Ilce = "";
            if (sabitOkulBilgi.Tel == null) sabitOkulBilgi.Tel = "";
            if (sabitOkulBilgi.OgretimYili == null) sabitOkulBilgi.OgretimYili = "";
            if (sabitOkulBilgi.SinavDonemi == null) sabitOkulBilgi.SinavDonemi = "";
            if (sabitOkulBilgi.UcretGozcu == null) sabitOkulBilgi.UcretGozcu = "";
            if (sabitOkulBilgi.UcretKomisyon == null) sabitOkulBilgi.UcretKomisyon = "";
            if (sabitOkulBilgi.RaporBaslik1 == null) sabitOkulBilgi.RaporBaslik1 = "";
            if (sabitOkulBilgi.RaporBaslik2 == null) sabitOkulBilgi.RaporBaslik2 = "";
            if (sabitOkulBilgi.RaporBaslik3 == null) sabitOkulBilgi.RaporBaslik3 = "";
            if (sabitOkulBilgi.RaporBaslik4 == null) sabitOkulBilgi.RaporBaslik4 = "";
            if (sabitOkulBilgi.Sayi == null) sabitOkulBilgi.Sayi = "";
            if (sabitOkulBilgi.Konu == null) sabitOkulBilgi.Konu = "";
            if (sabitOkulBilgi.Tarih == null) sabitOkulBilgi.Tarih = "";
            if (sabitOkulBilgi.Dipnot == null) sabitOkulBilgi.Dipnot = "";
            if (sabitOkulBilgi.Mudur == null) sabitOkulBilgi.Mudur = "";
            if (sabitOkulBilgi.MaksimumSaat == null) sabitOkulBilgi.MaksimumSaat = "";
            if (sabitOkulBilgi.MaksimumOgrencininGirecegiSinav == null) sabitOkulBilgi.MaksimumOgrencininGirecegiSinav = "";
            if (sabitOkulBilgi.Uay == null) sabitOkulBilgi.Uay = "";
            if (sabitOkulBilgi.Utarih == null) sabitOkulBilgi.Utarih = DateTime.Now;

            par[0].Value = sabitOkulBilgi.OkulAdi1;
            par[1].Value = sabitOkulBilgi.OkulAdi2;
            par[2].Value = sabitOkulBilgi.Il;
            par[3].Value = sabitOkulBilgi.Ilce;
            par[4].Value = sabitOkulBilgi.Tel;
            par[5].Value = sabitOkulBilgi.OgretimYili;
            par[6].Value = sabitOkulBilgi.SinavDonemi;
            par[7].Value = sabitOkulBilgi.SinavBaslamaTarihi;
            par[8].Value = sabitOkulBilgi.SinavBitisTarihi;
            par[9].Value = sabitOkulBilgi.UcretGozcu;
            par[10].Value = sabitOkulBilgi.UcretKomisyon;
            par[11].Value = sabitOkulBilgi.RaporBaslik1;
            par[12].Value = sabitOkulBilgi.RaporBaslik2;
            par[13].Value = sabitOkulBilgi.RaporBaslik3;
            par[14].Value = sabitOkulBilgi.RaporBaslik4;
            par[15].Value = sabitOkulBilgi.Sayi;
            par[16].Value = sabitOkulBilgi.Konu;
            par[17].Value = sabitOkulBilgi.Tarih;
            par[18].Value = sabitOkulBilgi.Dipnot;
            par[19].Value = sabitOkulBilgi.Mudur;
            par[20].Value = sabitOkulBilgi.MaksimumSaat;
            par[21].Value = sabitOkulBilgi.MaksimumOgrencininGirecegiSinav;
            par[22].Value = sabitOkulBilgi.Uay;
            par[23].Value = sabitOkulBilgi.Utarih;
            return helper.ExecuteNonQuery(sql, par);
        }
    }
}
