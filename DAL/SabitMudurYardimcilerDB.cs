using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Batl.Info;
namespace Batl.DAL
{
    public class SabitMudurYardimcilerDB
    {
        HelperDB helper = new HelperDB();
        public DataTable KayitlariGetir()
        {
            string sql = "select * from sabitMudurYardimcilar order by adi";
            return helper.ExecuteDataSet(sql).Tables[0];
        }
        public int KayitSil(int id)
        {
            string sql = "delete from sabitMudurYardimcilar where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }
        public int KayitEkle(SabitMudurYardimcilarInfo SabitMudurYardimcilarBilgi)
        {
            string sql = "insert into sabitMudurYardimcilar (adi,unvan) Values(@Adi, @Unvan)";
            OleDbParameter[] par = new OleDbParameter[]{
        
            new OleDbParameter("@Adi",OleDbType.VarChar,100),
            new OleDbParameter("@Unvan",OleDbType.VarChar,100)
            };
            par[0].Value = SabitMudurYardimcilarBilgi.Adi ;
            par[1].Value = SabitMudurYardimcilarBilgi.Unvan ;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitDegis(SabitMudurYardimcilarInfo SabitMudurYardimcilarBilgi)
        {
            string sql = "Update sabitMudurYardimcilar Set adi=@Adi, unvan=@Unvan where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Adi",OleDbType.VarChar,100),
            new OleDbParameter("@Unvan",OleDbType.VarChar,100),
            new OleDbParameter("@Id",OleDbType.Integer)
            };


            par[0].Value = SabitMudurYardimcilarBilgi.Adi;
            par[1].Value = SabitMudurYardimcilarBilgi.Unvan;
            par[2].Value = SabitMudurYardimcilarBilgi.Id;
            return helper.ExecuteNonQuery(sql, par);
        }
    }
}
