using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Batl.Info;

namespace Batl.DAL
{
    public class SabitSaatDB
    {
        HelperDB helper = new HelperDB();

        public OleDbDataReader KayitlariTekTekGetir()
        {
            string sql = "SELECT id,saat FROM sabitSaat order by saat";
            return helper.ExecuteReader(sql);
        }

        public DataTable KayitlariGetir()
        {
            string sql = "SELECT * FROM sabitSaat order by saat";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public SabitSaatInfo KayitGetir(int bId)
        {
            string sql = "Select * from sabitSaat where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            OleDbDataReader dr = helper.ExecuteReader(sql, p);
            SabitSaatInfo sabitSaatBilgi = new SabitSaatInfo();
            if (dr.Read())
            {
                sabitSaatBilgi.Saat = GenelOzelIsler.GetString(dr, "saat");
                sabitSaatBilgi.Id = bId;
            }
            dr.Close();
            return sabitSaatBilgi;
        }

        public int KayitDegistir(SabitSaatInfo sabitSaatBilgi)
        {
            string sql = "Update sabitSaat Set saat=@Saat where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Saat",OleDbType.VarChar,100),
            new OleDbParameter("@Id",OleDbType.Integer)
            };

            par[0].Value = sabitSaatBilgi.Saat;
            par[1].Value = sabitSaatBilgi.Id;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitEkle(SabitSaatInfo sabitSaatBilgi)
        {
            string sql = "insert into sabitSaat (saat) Values (@Saat)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Saat",OleDbType.VarChar,100),
               };

            par[0].Value = sabitSaatBilgi.Saat;
            return helper.ExecuteNonQuery(sql, par);
        }
        public DataTable KayitBul(string Saat)
        {
            string sql = "select * from sabitSaat  where saat=@Saat";
            OleDbParameter[] par = new OleDbParameter[]{
            new OleDbParameter("@Saat",OleDbType.VarChar,100)
               };
            par[0].Value = Saat;
            return helper.ExecuteDataSet(sql, par).Tables[0];
        }

        public int KayitSil(int id)
        {
            string sql = "delete from sabitSaat where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }
    }
}
