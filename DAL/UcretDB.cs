using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Batl.Info;
using System.Data.OleDb;
using System.Data;

namespace Batl.DAL
{
    public class UcretDB
    {
        HelperDB helper = new HelperDB();
        
        public DataTable KayitlariGetir()
        {
            string sql = "select * from ucret";
            return helper.ExecuteDataSet(sql).Tables[0];
        }

        public int TumKayitlariSil()
        {
            string sql = "delete from ucret";
            return helper.ExecuteNonQuery(sql);
        }

        public int KayitEkle(UcretInfo ucretBilgi)
        {
            string sql = "insert into ucret (tarihAdi, isim, brans, k01, k02, k03, k04, k05, k06, k07, k08, k09, k10, k11, k12, k13, k14, k15, k16, k17, k18, k19, k20, k21, k22, k23, k24, k25, k26, k27, k28, k29, k30, k31, g01, g02, g03, g04, g05, g06, g07, g08, g09, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24, g25, g26, g27, g28, g29, g30, g31, komisyonToplam, gozcuToplam,komisyonSayi,gozcuSayi) Values (@Tarihadi, @Isim, @Brans, @K01, @K02, @K03, @K04, @K05, @K06, @K07, @K08, @K09, @K10, @K11, @K12, @K13, @K14, @K15, @K16, @K17, @K18, @K19, @K20, @K21, @K22, @K23, @K24, @K25, @K26, @K27, @K28, @K29, @K30, @K31, @G01, @G02, @G03, @G04, @G05, @G06, @G07, @G08, @G09, @G10, @G11, @G12, @G13, @G14, @G15, @G16, @G17, @G18, @G19, @G20, @G21, @G22, @G23, @G24, @G25, @G26, @G27, @G28, @G29, @G30, @G31, @Komisyontoplam, @Gozcutoplam, @KomisyonSayi, @GozcuSayi)";
            OleDbParameter[] par = new OleDbParameter[]{
           
            new OleDbParameter("@Tarihadi",OleDbType.VarChar,100),
            new OleDbParameter("@Isim",OleDbType.VarChar,100),
            new OleDbParameter("@Brans",OleDbType.VarChar,100),
            new OleDbParameter("@K01",OleDbType.Integer),
            new OleDbParameter("@K02",OleDbType.Integer),
            new OleDbParameter("@K03",OleDbType.Integer),
            new OleDbParameter("@K04",OleDbType.Integer),
            new OleDbParameter("@K05",OleDbType.Integer),
            new OleDbParameter("@K06",OleDbType.Integer),
            new OleDbParameter("@K07",OleDbType.Integer),
            new OleDbParameter("@K08",OleDbType.Integer),
            new OleDbParameter("@K09",OleDbType.Integer),
            new OleDbParameter("@K10",OleDbType.Integer),
            new OleDbParameter("@K11",OleDbType.Integer),
            new OleDbParameter("@K12",OleDbType.Integer),
            new OleDbParameter("@K13",OleDbType.Integer),
            new OleDbParameter("@K14",OleDbType.Integer),
            new OleDbParameter("@K15",OleDbType.Integer),
            new OleDbParameter("@K16",OleDbType.Integer),
            new OleDbParameter("@K17",OleDbType.Integer),
            new OleDbParameter("@K18",OleDbType.Integer),
            new OleDbParameter("@K19",OleDbType.Integer),
            new OleDbParameter("@K20",OleDbType.Integer),
            new OleDbParameter("@K21",OleDbType.Integer),
            new OleDbParameter("@K22",OleDbType.Integer),
            new OleDbParameter("@K23",OleDbType.Integer),
            new OleDbParameter("@K24",OleDbType.Integer),
            new OleDbParameter("@K25",OleDbType.Integer),
            new OleDbParameter("@K26",OleDbType.Integer),
            new OleDbParameter("@K27",OleDbType.Integer),
            new OleDbParameter("@K28",OleDbType.Integer),
            new OleDbParameter("@K29",OleDbType.Integer),
            new OleDbParameter("@K30",OleDbType.Integer),
            new OleDbParameter("@K31",OleDbType.Integer),
            new OleDbParameter("@G01",OleDbType.Integer),
            new OleDbParameter("@G02",OleDbType.Integer),
            new OleDbParameter("@G03",OleDbType.Integer),
            new OleDbParameter("@G04",OleDbType.Integer),
            new OleDbParameter("@G05",OleDbType.Integer),
            new OleDbParameter("@G06",OleDbType.Integer),
            new OleDbParameter("@G07",OleDbType.Integer),
            new OleDbParameter("@G08",OleDbType.Integer),
            new OleDbParameter("@G09",OleDbType.Integer),
            new OleDbParameter("@G10",OleDbType.Integer),
            new OleDbParameter("@G11",OleDbType.Integer),
            new OleDbParameter("@G12",OleDbType.Integer),
            new OleDbParameter("@G13",OleDbType.Integer),
            new OleDbParameter("@G14",OleDbType.Integer),
            new OleDbParameter("@G15",OleDbType.Integer),
            new OleDbParameter("@G16",OleDbType.Integer),
            new OleDbParameter("@G17",OleDbType.Integer),
            new OleDbParameter("@G18",OleDbType.Integer),
            new OleDbParameter("@G19",OleDbType.Integer),
            new OleDbParameter("@G20",OleDbType.Integer),
            new OleDbParameter("@G21",OleDbType.Integer),
            new OleDbParameter("@G22",OleDbType.Integer),
            new OleDbParameter("@G23",OleDbType.Integer),
            new OleDbParameter("@G24",OleDbType.Integer),
            new OleDbParameter("@G25",OleDbType.Integer),
            new OleDbParameter("@G26",OleDbType.Integer),
            new OleDbParameter("@G27",OleDbType.Integer),
            new OleDbParameter("@G28",OleDbType.Integer),
            new OleDbParameter("@G29",OleDbType.Integer),
            new OleDbParameter("@G30",OleDbType.Integer),
            new OleDbParameter("@G31",OleDbType.Integer),
            new OleDbParameter("@Komisyontoplam",OleDbType.Integer),
            new OleDbParameter("@Gozcutoplam",OleDbType.Integer),
            new OleDbParameter("@KomisyonSayi",OleDbType.Integer),
            new OleDbParameter("@GozcuSayi",OleDbType.Integer)
            };

            par[0].Value = ucretBilgi.TarihAdi;
            par[1].Value = ucretBilgi.Isim;
            par[2].Value = ucretBilgi.Brans;
            par[3].Value = ucretBilgi.K01;
            par[4].Value = ucretBilgi.K02;
            par[5].Value = ucretBilgi.K03;
            par[6].Value = ucretBilgi.K04;
            par[7].Value = ucretBilgi.K05;
            par[8].Value = ucretBilgi.K06;
            par[9].Value = ucretBilgi.K07;
            par[10].Value = ucretBilgi.K08;
            par[11].Value = ucretBilgi.K09;
            par[12].Value = ucretBilgi.K10;
            par[13].Value = ucretBilgi.K11;
            par[14].Value = ucretBilgi.K12;
            par[15].Value = ucretBilgi.K13;
            par[16].Value = ucretBilgi.K14;
            par[17].Value = ucretBilgi.K15;
            par[18].Value = ucretBilgi.K16;
            par[19].Value = ucretBilgi.K17;
            par[20].Value = ucretBilgi.K18;
            par[21].Value = ucretBilgi.K19;
            par[22].Value = ucretBilgi.K20;
            par[23].Value = ucretBilgi.K21;
            par[24].Value = ucretBilgi.K22;
            par[25].Value = ucretBilgi.K23;
            par[26].Value = ucretBilgi.K24;
            par[27].Value = ucretBilgi.K25;
            par[28].Value = ucretBilgi.K26;
            par[29].Value = ucretBilgi.K27;
            par[30].Value = ucretBilgi.K28;
            par[31].Value = ucretBilgi.K29;
            par[32].Value = ucretBilgi.K30;
            par[33].Value = ucretBilgi.K31;
            par[34].Value = ucretBilgi.G01;
            par[35].Value = ucretBilgi.G02;
            par[36].Value = ucretBilgi.G03;
            par[37].Value = ucretBilgi.G04;
            par[38].Value = ucretBilgi.G05;
            par[39].Value = ucretBilgi.G06;
            par[40].Value = ucretBilgi.G07;
            par[41].Value = ucretBilgi.G08;
            par[42].Value = ucretBilgi.G09;
            par[43].Value = ucretBilgi.G10;
            par[44].Value = ucretBilgi.G11;
            par[45].Value = ucretBilgi.G12;
            par[46].Value = ucretBilgi.G13;
            par[47].Value = ucretBilgi.G14;
            par[48].Value = ucretBilgi.G15;
            par[49].Value = ucretBilgi.G16;
            par[50].Value = ucretBilgi.G17;
            par[51].Value = ucretBilgi.G18;
            par[52].Value = ucretBilgi.G19;
            par[53].Value = ucretBilgi.G20;
            par[54].Value = ucretBilgi.G21;
            par[55].Value = ucretBilgi.G22;
            par[56].Value = ucretBilgi.G23;
            par[57].Value = ucretBilgi.G24;
            par[58].Value = ucretBilgi.G25;
            par[59].Value = ucretBilgi.G26;
            par[60].Value = ucretBilgi.G27;
            par[61].Value = ucretBilgi.G28;
            par[62].Value = ucretBilgi.G29;
            par[63].Value = ucretBilgi.G30;
            par[64].Value = ucretBilgi.G31;
            par[65].Value = ucretBilgi.KomisyonToplam;
            par[66].Value = ucretBilgi.GozcuToplam;
            par[67].Value = ucretBilgi.KomisyonSayi;
            par[68].Value = ucretBilgi.GozcuSayi;
            return helper.ExecuteNonQuery(sql, par);
        }
    }
}
