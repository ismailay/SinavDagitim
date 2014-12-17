using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Batl.Info;

namespace Batl.DAL
{
   public class OgrenciDersDB
    {
        HelperDB helper = new HelperDB();

        public DataTable KayitlariGetir(int bId)
        {
            string sql = "SELECT ogrenciDers.id, sabitDers.adi, sabitDersGrubu.grup, sabitOgrenci.id FROM sabitDersGrubu INNER JOIN (sabitDers INNER JOIN (sabitOgrenci INNER JOIN ogrenciDers ON sabitOgrenci.id = ogrenciDers.idx) ON sabitDers.id = ogrenciDers.ders) ON sabitDersGrubu.id = sabitDers.seviye WHERE sabitOgrenci.id=@Id ;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            return helper.ExecuteDataSet(sql,p).Tables[0];
        }

        public int KayitEkle(OgrenciDersInfo ogrenciDersBilgi)
        {
            string sql = "insert into ogrenciDers (idx, ders, adi) Values (@Idx, @Ders, @Adi)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Idx",OleDbType.Integer),
            new OleDbParameter("@Ders",OleDbType.Integer),
            new OleDbParameter("@Adi",OleDbType.VarChar,100)         
            };

            par[0].Value = ogrenciDersBilgi.Idx;
            par[1].Value = ogrenciDersBilgi.Ders;
            par[2].Value = ogrenciDersBilgi.Adi;
            return helper.ExecuteNonQuery(sql, par);
        }

        public DataTable KayitKontrol(OgrenciDersInfo ogrenciDersBilgi)
        {
            string sql = "SELECT * FROM ogrenciDers WHERE (idx=@Idx and ders=@Ders);";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Idx",OleDbType.Integer),
            new OleDbParameter("@Ders",OleDbType.Integer)     
            };
            par[0].Value = ogrenciDersBilgi.Idx;
            par[1].Value = ogrenciDersBilgi.Ders;
            return helper.ExecuteDataSet(sql, par).Tables[0];
        }

        public int KayitSil(int id)
        {
            string sql = "delete from ogrenciDers where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }
    }
}
