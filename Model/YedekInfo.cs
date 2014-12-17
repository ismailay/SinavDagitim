using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batl.Info
{
   public  class YedekInfo
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string adi;

        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }
        DateTime  yedekTarihi;

        public DateTime YedekTarihi
        {
            get { return yedekTarihi; }
            set { yedekTarihi = value; }
        }
        String yedekSaat;

        public String YedekSaat
        {
            get { return yedekSaat; }
            set { yedekSaat = value; }
        }
        DateTime baslangicTarihi;

        public DateTime BaslangicTarihi
        {
            get { return baslangicTarihi; }
            set { baslangicTarihi = value; }
        }
        DateTime bitisTarihi;

        public DateTime BitisTarihi
        {
            get { return bitisTarihi; }
            set { bitisTarihi = value; }
        }

        
        string kurumAdi;

        public string KurumAdi
        {
            get { return kurumAdi; }
            set { kurumAdi = value; }
        }
        string donemAdi;

        public string DonemAdi
        {
            get { return donemAdi; }
            set { donemAdi = value; }
        }
        string donemYili;

        public string DonemYili
        {
            get { return donemYili; }
            set { donemYili = value; }
        }
        string dosyaAdi;

        public string DosyaAdi
        {
            get { return dosyaAdi; }
            set { dosyaAdi = value; }
        }
    }
}
