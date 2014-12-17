using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batl.Info
{
    public class NobetciOgretmenInfo
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        int tarih;

        public int Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
        int mudurYardimcisi;

        public int MudurYardimcisi
        {
            get { return mudurYardimcisi; }
            set { mudurYardimcisi = value; }
        }
        int ogretmen;

        public int Ogretmen
        {
            get { return ogretmen; }
            set { ogretmen = value; }
        }
    }
}
