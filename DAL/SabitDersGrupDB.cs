using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Batl.Info;
using System.Data.OleDb;

namespace Batl.DAL
{
    public class SabitDersGrupDB
    {
        HelperDB helper = new HelperDB();

        public DataTable KayitlariGetir()
        {
            string sql = "SELECT * FROM sabitDersGrubu order by grup";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public SabitDersGrupInfo KayitGetir(int bId)
        {
            string sql = "Select * from sabitDersGrubu where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = bId;
            OleDbDataReader dr = helper.ExecuteReader(sql, p);
            SabitDersGrupInfo sabitDersGrubuBilgi = new SabitDersGrupInfo();
            if (dr.Read())
            {
                sabitDersGrubuBilgi.Grup = GenelOzelIsler.GetString(dr, "grup");
                sabitDersGrubuBilgi.Id = bId;
            }
            dr.Close();
            return sabitDersGrubuBilgi;
        }

        public int KayitDegistir(SabitDersGrupInfo sabitDersGrubuBilgi)
        {
            string sql = "Update sabitDersGrubu Set grup=@Grup where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Grup",OleDbType.VarChar,100),
            new OleDbParameter("@Id",OleDbType.Integer)
            };

            par[0].Value = sabitDersGrubuBilgi.Grup;
            par[1].Value = sabitDersGrubuBilgi.Id;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitEkle(SabitDersGrupInfo sabitDersGrubuBilgi)
        {
            string sql = "insert into sabitDersGrubu (grup) Values (@Grup)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Grup",OleDbType.VarChar,100)
               };

            par[0].Value = sabitDersGrubuBilgi.Grup;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitSil(int id)
        {
            string sql = "delete from sabitDersGrubu where id=@Id;";
            OleDbParameter p = new OleDbParameter("@Id", OleDbType.Integer);
            p.Value = id;
            return helper.ExecuteNonQuery(sql, p);
        }
    }
}
