using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Batl.Info;
using System.Data.OleDb;
using System.Data;

namespace Batl.DAL
{
    public class SabitBolumDB
    {
        HelperDB helper = new HelperDB();

        public DataTable KayitlariGetir()
        {
            string sql = "SELECT * FROM sabitBolum order by ad";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public SabitBolumInfo KayitGetir(int bId)
        {
            string sql = "Select * from sabitBolum where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            OleDbDataReader dr = helper.ExecuteReader(sql, p);
            SabitBolumInfo sabitBolumBilgi = new SabitBolumInfo();
            if (dr.Read())
            {
                sabitBolumBilgi.Ad = GenelOzelIsler.GetString(dr, "ad");
                sabitBolumBilgi.Id = bId;
            }
            dr.Close();
            return sabitBolumBilgi;
        }

        public int KayitDegistir(SabitBolumInfo sabitBolumBilgi)
        {
            string sql = "Update sabitBolum Set ad=@Ad where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Ad",OleDbType.VarChar,100),
            new OleDbParameter("@Id",OleDbType.Integer)
            };

            par[0].Value = sabitBolumBilgi.Ad;
            par[1].Value = sabitBolumBilgi.Id;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitEkle(SabitBolumInfo sabitBolumBilgi)
        {
            string sql = "insert into sabitBolum (ad) Values (@Ad)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Ad",OleDbType.VarChar,100),
               };

            par[0].Value = sabitBolumBilgi.Ad;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitSil(int id)
        {
            string sql = "delete from sabitBolum where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }
    }
}
