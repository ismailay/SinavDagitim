using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Batl.Info;
using System.Data;

namespace Batl.DAL
{
   public class SabitSinifDB
    {
        HelperDB helper = new HelperDB();

        public DataTable KayitlariGetir()
        {
            string sql = "SELECT * FROM sabitSinif order by adi";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public SabitSinifInfo KayitGetir(int bId)
        {
            string sql = "Select * from sabitSinif where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            OleDbDataReader dr = helper.ExecuteReader(sql, p);
            SabitSinifInfo sabitSinifBilgi = new SabitSinifInfo();
            if (dr.Read())
            {
                sabitSinifBilgi.Adi = GenelOzelIsler.GetString(dr, "adi");
                sabitSinifBilgi.Id = bId;
            }
            dr.Close();
            return sabitSinifBilgi;
        }

        public int KayitDegistir(SabitSinifInfo sabitSinifBilgi)
        {
            string sql = "Update sabitSinif Set adi=@Adi where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Adi",OleDbType.VarChar,100),
            new OleDbParameter("@Id",OleDbType.Integer)
            };

            par[0].Value = sabitSinifBilgi.Adi;
            par[1].Value = sabitSinifBilgi.Id;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitEkle(SabitSinifInfo sabitSinifBilgi)
        {
            string sql = "insert into sabitSinif (adi) Values (@Adi)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Adi",OleDbType.VarChar,100),
               };

            par[0].Value = sabitSinifBilgi.Adi;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitSil(int id)
        {
            string sql = "delete from sabitSinif where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }
    }
}
