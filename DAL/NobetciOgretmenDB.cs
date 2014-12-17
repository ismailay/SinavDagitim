using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Batl.Info;

namespace Batl.DAL
{
    public class NobetciOgretmenDB
    {
        HelperDB helper = new HelperDB();
        public OleDbDataReader SeciliTarihKayitlariniGetir(string bId)
        {
            string sql = "SELECT sabitMudurYardimcilar.adi AS MudurYardimcisiAdi, sabitOgretmen.adi AS OgretmenAdi, nobetciOgretmen.id AS NobetciOgretmenId, nobetciOgretmen.tarihId, nobetciOgretmen.mudurYardimcisiId, nobetciOgretmen.ogretmenId, sabitTarih.tarih FROM sabitTarih INNER JOIN (sabitOgretmen INNER JOIN (sabitMudurYardimcilar INNER JOIN nobetciOgretmen ON sabitMudurYardimcilar.id = nobetciOgretmen.mudurYardimcisiId) ON sabitOgretmen.id = nobetciOgretmen.ogretmenId) ON sabitTarih.id = nobetciOgretmen.tarihId WHERE (((sabitTarih.tarih)=@Tarih));";
            OleDbParameter p = new OleDbParameter("@Tarih", OleDbType.VarChar, 20);
            p.Value = bId;
            return helper.ExecuteReader(sql, p);
        }

        public int KayitDegistir(NobetciOgretmenInfo nobetciOgretmenBilgi)
        {
            string sql = "Update NobetciOgretmen Set mudurYardimcisiId=@MudurYardimcisiId, ogretmenId=@OgretmenId where id=@Id";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@MudurYardimcisiId",OleDbType.Integer),
            new OleDbParameter("@OgretmenId",OleDbType.Integer),
            new OleDbParameter("@Id",OleDbType.Integer)
            };

            par[0].Value = nobetciOgretmenBilgi.MudurYardimcisi;
            par[1].Value = nobetciOgretmenBilgi.Ogretmen;
            par[2].Value = nobetciOgretmenBilgi.Id;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int KayitEkle(NobetciOgretmenInfo nobetciOgretmenBilgi)
        {
            string sql = "insert into NobetciOgretmen (mudurYardimcisiId,ogretmenId,tarihId) Values (@MudurYardimcisiId,@OgretmenId,@TarihId)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@MudurYardimcisiId",OleDbType.Integer),
            new OleDbParameter("@OgretmenId",OleDbType.Integer),
            new OleDbParameter("@TarihId",OleDbType.Integer)
               };

            par[0].Value = nobetciOgretmenBilgi.MudurYardimcisi;
            par[1].Value = nobetciOgretmenBilgi.Ogretmen;
            par[2].Value = nobetciOgretmenBilgi.Tarih;
            return helper.ExecuteNonQuery(sql, par);
        } 
    }
}
