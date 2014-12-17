using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batl.Info
{
    public class DersDagitimOgretmenInfo
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        int ogretmenId;

        public int OgretmenId
        {
            get { return ogretmenId; }
            set { ogretmenId = value; }
        }
        int dersDagitimId;

        public int DersDagitimId
        {
            get { return dersDagitimId; }
            set { dersDagitimId = value; }
        }

        string gorevTuru;

        public string GorevTuru
        {
            get { return gorevTuru; }
            set { gorevTuru = value; }
        }
    }
}
