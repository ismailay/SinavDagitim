using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batl.Info
{
    public class SabitOgretmenInfo
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
        string bolum;

        public string Bolum
        {
            get { return bolum; }
            set { bolum = value; }
        }
        string grup;

        public string Grup
        {
            get { return grup; }
            set { grup = value; }
        }

        int eskiKomisyonGorevi;

        public int EskiKomisyonGorevi
        {
            get { return eskiKomisyonGorevi; }
            set { eskiKomisyonGorevi = value; }
        }
        int eskiGozcuGorevi;

        public int EskiGozcuGorevi
        {
            get { return eskiGozcuGorevi; }
            set { eskiGozcuGorevi = value; }
        }
        int yeniKomisyonGorevi;

        public int YeniKomisyonGorevi
        {
            get { return yeniKomisyonGorevi; }
            set { yeniKomisyonGorevi = value; }
        }
        int yeniGozcuGorevi;

        public int YeniGozcuGorevi
        {
            get { return yeniGozcuGorevi; }
            set { yeniGozcuGorevi = value; }
        }

    }
}
