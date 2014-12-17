using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batl.Info
{
    public class DersDagitimInfo
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        int tarihId;

        public int TarihId
        {
            get { return tarihId; }
            set { tarihId = value; }
        }
        int saatId;

        public int SaatId
        {
            get { return saatId; }
            set { saatId = value; }
        }
        int dersId;

        public int DersId
        {
            get { return dersId; }
            set { dersId = value; }
        }
        int oturum;

        public int Oturum
        {
            get { return oturum; }
            set { oturum = value; }
        }

        string turu;

        public string Turu
        {
            get { return turu; }
            set { turu = value; }
        }
        int sekli;

        public int Sekli
        {
            get { return sekli; }
            set { sekli = value; }
        }
    }
}
