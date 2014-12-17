using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batl.Info
{
    public class ZamanInfo
    {
        bool zamandaDegisiklikVarmi = false;

        public bool ZamandaDegisiklikVarmi
        {
            get { return zamandaDegisiklikVarmi; }
            set { zamandaDegisiklikVarmi = value; }
        }

        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string tarih;

        public string Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
        string sutunSayisi;

        public string SutunSayisi
        {
            get { return sutunSayisi; }
            set { sutunSayisi = value; }
        }
        string satirSayisi;

        public string SatirSayisi
        {
            get { return satirSayisi; }
            set { satirSayisi = value; }
        }
        string gTarih;

        public string GTarih
        {
            get { return gTarih; }
            set { gTarih = value; }
        }
        string gSaat;

        public string GSaat
        {
            get { return gSaat; }
            set { gSaat = value; }
        }
        string durum;

        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }
    }
}
