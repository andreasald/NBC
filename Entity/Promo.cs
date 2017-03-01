using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNBC.Entity
{
    class Promo
    {
        string kode;
        string nama;
        float diskon;
        DateTime start;
        DateTime end;
        string status;
        int validpromo;

        


        public Promo(string kode, string nama, float diskon, DateTime start, DateTime end, string status, int validpromo)
        {
            this.kode = kode;
            this.nama = nama;
            this.diskon = diskon;
            this.start = start;
            this.end = end;
            this.status = status;
            this.validpromo = validpromo;
        }


        public string Kode
        {
            get { return kode; }
            set { kode = value; }
        }


        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public float Diskon
        {
            get { return diskon; }
            set { diskon = value; }
        }

        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }


        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }
        

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Validpromo
        {
            get { return validpromo; }
            set { validpromo = value; }
        }

    }
}
