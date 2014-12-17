using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Batl.Info;
using System.Data.OleDb;
using System.Data;

namespace Batl.DAL
{
    public class CarsafTabloDB
    {
        HelperDB helper = new HelperDB();

        public DataTable KayitlariGetir()
        {
            string sql = "select * from carsafTablo order by cdate(tarih),saat asc ;";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public int KayitEkle(CarsafTabloInfo carsafTabloBilgi)
        {
            string sql = "insert into carsafTablo (Tarih,Saat,Oturum,Ders,Sinif,Sekli,NobetciOgretmen,NobetciMudurYardimcisi,KomisyonUye,GozcuUye) Values (@Tarih,@Saat,@Oturum,@Ders,@Sinif,@Sekli,@NobetciOgretmen,@NobetciMudurYardimcisi,@KomisyonUye,@GozcuUye)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Tarih",OleDbType.VarChar,10),
            new OleDbParameter("@Saat",OleDbType.VarChar,5),
            new OleDbParameter("@Oturum",OleDbType.VarChar,2),
            new OleDbParameter("@Ders",OleDbType.VarChar,100),
            new OleDbParameter("@Sinif",OleDbType.VarChar,5),
            new OleDbParameter("@Sekli",OleDbType.VarChar,20),
            new OleDbParameter("@NobetciOgretmen",OleDbType.VarChar,50),
            new OleDbParameter("@NobetciMudurYardimcisi",OleDbType.VarChar,50),
            new OleDbParameter("@KomisyonUye",OleDbType.VarChar,255),
            new OleDbParameter("@GozcuUye",OleDbType.VarChar,255)
               };

            par[0].Value = carsafTabloBilgi.Tarih;
            par[1].Value = carsafTabloBilgi.Saat;
            par[2].Value = carsafTabloBilgi.Oturum;
            par[3].Value = carsafTabloBilgi.Ders;
            par[4].Value = carsafTabloBilgi.Sinif;
            par[5].Value = carsafTabloBilgi.Sekli;
            par[6].Value = carsafTabloBilgi.NobetciOgretmen;
            par[7].Value = carsafTabloBilgi.NobetciMudurYardimcisi;
            par[8].Value = carsafTabloBilgi.KomisyonUye;
            par[9].Value = carsafTabloBilgi.GozcuUye;
            return helper.ExecuteNonQuery(sql, par);
        }

        public int TumKayitlariSil()
        {
            string sql = "delete from carsafTablo;";
            return helper.ExecuteNonQuery(sql);
        }
    }
}
