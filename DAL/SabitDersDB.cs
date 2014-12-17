using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Batl.Info;
using System.Data.OleDb;
using System.Data;

namespace Batl.DAL
{
    public class SabitDersDB
    {
        HelperDB helper = new HelperDB();
        public DataTable BolumSeviyeKayitlariniGetir(int bolumId, int seviyeId )
        {
            string sql = "SELECT sabitDers.id as dersid, sabitDers.adi as dersadi, sabitDersGrubu.id, sabitBolum.id FROM sabitBolum INNER JOIN (sabitDersGrubu INNER JOIN sabitDers ON sabitDersGrubu.id = sabitDers.seviye) ON sabitBolum.id = sabitDers.bolum WHERE ((sabitDersGrubu.id=@SeviyeId) AND (sabitBolum.id=@BolumId));";
            OleDbParameter p1 = new OleDbParameter("@SeviyeId", OleDbType.Integer);
            OleDbParameter p2 = new OleDbParameter("@BolumId", OleDbType.Integer);
            p1.Value = seviyeId;
            p2.Value = bolumId;
            return helper.ExecuteDataSet(sql, p1, p2).Tables[0];
        }
       

        public DataTable KayitlariGetir()
        {
            string sql = "SELECT sabitDers.id, sabitDers.kodu, sabitDers.adi, sabitDersGrubu.grup, sabitDers.sure, sabitDers.grup, sabitBolum.ad, sabitDers.seviye, sabitDers.bolum FROM sabitBolum INNER JOIN (sabitDersGrubu INNER JOIN sabitDers ON sabitDersGrubu.id = sabitDers.seviye) ON sabitBolum.id = sabitDers.bolum";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public SabitDersInfo KayitGetir(int bId)
        {
            string sql = "Select * from sabitDers where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            OleDbDataReader dr = helper.ExecuteReader(sql, p);
            SabitDersInfo sabitDersBilgi = new SabitDersInfo();
            if (dr.Read())
            {
                sabitDersBilgi.Kodu = GenelOzelIsler.GetString(dr, "kodu");
                sabitDersBilgi.Adi  = GenelOzelIsler.GetString(dr, "adi");
                sabitDersBilgi.Seviye = GenelOzelIsler.GetInteger(dr, "seviye");
                sabitDersBilgi.Sure = GenelOzelIsler.GetString(dr, "sure");
                sabitDersBilgi.Grup = GenelOzelIsler.GetString(dr, "grup");
                sabitDersBilgi.Bolum = GenelOzelIsler.GetInteger(dr, "bolum");
                sabitDersBilgi.Id = bId;
            }
            dr.Close();
            return sabitDersBilgi;
        }

        public int KayitDegistir(SabitDersInfo sabitDersBilgi)
        {
            string sql = "Update sabitDers Set kodu=@Kodu, adi=@Adi, seviye=@Seviye, sure=@Sure, grup=@Grup, bolum=@Bolum  where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Kodu",OleDbType.VarChar,100),
            new OleDbParameter("@Adi",OleDbType.VarChar,100),
            new OleDbParameter("@Seviye",OleDbType.Integer),
            new OleDbParameter("@Sure",OleDbType.VarChar,100),
            new OleDbParameter("@Grup",OleDbType.VarChar,100),
            new OleDbParameter("@Bolum",OleDbType.Integer),
            new OleDbParameter("@Id",OleDbType.Integer)
            };

            par[0].Value = sabitDersBilgi.Kodu;
            par[1].Value = sabitDersBilgi.Adi;
            par[2].Value = sabitDersBilgi.Seviye;
            par[3].Value = sabitDersBilgi.Sure;
            par[4].Value = sabitDersBilgi.Grup;
            par[5].Value = sabitDersBilgi.Bolum;
            par[6].Value = sabitDersBilgi.Id;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitEkle(SabitDersInfo sabitDersBilgi)
        {
            string sql = "insert into sabitDers (kodu,adi,seviye,sure,grup,bolum) Values (@Kodu,@Adi,@Seviye,@Sure,@Grup,@Bolum)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Kodu",OleDbType.VarChar,100),
            new OleDbParameter("@Adi",OleDbType.VarChar,100),
            new OleDbParameter("@Seviye",OleDbType.Integer),
            new OleDbParameter("@Sure",OleDbType.VarChar,100),
            new OleDbParameter("@Grup",OleDbType.VarChar,100),
            new OleDbParameter("@Bolum",OleDbType.Integer)
               };

            par[0].Value = sabitDersBilgi.Kodu;
            par[1].Value = sabitDersBilgi.Adi;
            par[2].Value = sabitDersBilgi.Seviye;
            par[3].Value = sabitDersBilgi.Sure;
            par[4].Value = sabitDersBilgi.Grup;
            par[5].Value = sabitDersBilgi.Bolum;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitSil(int id)
        {
            string sql = "delete from sabitDers where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }
    }
}
