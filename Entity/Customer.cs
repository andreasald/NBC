using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNBC.Entity
{
    class Customer
    {
        string ID;
        string nama;
        DateTime TGLLahir;
        string JK;
        string alamat;
        string telp;
        string email;
        string alergi;
        DateTime TGL_Registrasi;
        int poin;
        string password;
        int valid;

        public Customer(string ID, string nama, DateTime TGLLahir, string JK, string alamat, string telp, string email,
        string alergi, DateTime TGL_Registrasi, int poin, string password, int valid)
        {
            this.ID = ID;
            this.nama = nama;
            this.TGLLahir = TGLLahir;
            this.JK = JK;
            this.alamat = alamat;
            this.telp = telp;
            this.email = email;
            this.alergi = alergi;
            this.TGL_Registrasi = TGL_Registrasi;
            this.poin = poin;
            this.password = password;
            this.valid = valid;
        }

        public string ID1
        {
            get { return ID; }
            set { ID = value; }
        }



        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }


        public DateTime TGL1
        {
            get { return TGLLahir; }
            set { TGLLahir = value; }
        }


        public string JK1
        {
            get { return JK; }
            set { JK = value; }
        }

        public string Alamat
        {
            get { return alamat; }
            set { alamat = value; }
        }
    
        public string Telp
        {
            get { return telp; }
            set { telp = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Alergi
        {
            get { return alergi; }
            set { alergi = value; }
        }

        public DateTime TGL_Registrasi1
        {
            get { return TGL_Registrasi; }
            set { TGL_Registrasi = value; }
        }
        public int Poin
        {
            get { return poin; }
            set { poin = value; }
        }
 
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        

        public int Valid
        {
            get { return valid; }
            set { valid = value; }
        }
    }
}
