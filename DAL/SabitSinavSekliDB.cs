using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Batl.Info;

namespace Batl.DAL
{
    public class SabitSinavSekliDB
    {
        HelperDB helper = new HelperDB();

        public DataTable KayitlariGetir()
        {
            string sql = "SELECT * FROM sabitSinavSekli";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public int KayitDegistir(SabitSinavSekliInfo sabitSinavSekliBilgi)
        {
            string sql = "Update sabitSinavSekli Set adi=@Adi where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Adi",OleDbType.VarChar,100),
            new OleDbParameter("@Id",OleDbType.Integer)
            };

            par[0].Value = sabitSinavSekliBilgi.Adi;
            par[1].Value = sabitSinavSekliBilgi.Id;
            return helper.ExecuteNonQuery(sql, par);
        }


        public int KayitEkle(SabitSinavSekliInfo sabitSinavSekliBilgi)
        {
            string sql = "insert into sabitSinavSekli (adi) Values (@Adi)";
            OleDbParameter[] par = new OleDbParameter[]{
               new OleDbParameter("@Adi",OleDbType.VarChar,100),
               };
            par[0].Value = sabitSinavSekliBilgi.Adi;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int  KayitSil(int id)
        {
            string sql = "delete from sabitSinavSekli where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }
    }
}
