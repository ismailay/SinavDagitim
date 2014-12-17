using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batl.Info
{
    public class AyarlarInfo
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string durum;

        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }
        string zaman;

        public string Zaman
        {
            get { return zaman; }
            set { zaman = value; }
        }
        string maksimum;

        public string Maksimum
        {
            get { return maksimum; }
            set { maksimum = value; }
        }
    }
}
