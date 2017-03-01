using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNBC.Entity
{
    class Pegawai
    {
        string nama,jenis_kelamin,telp,alamat,username,pass;
        int role, validPegawai;

        
        string status;



        public Pegawai(string nama, string jenis_kelamin, string telp, 
        string alamat, string username, string pass, int role, string status,int validPegawai)
        {   
            this.nama = nama;
            this.jenis_kelamin = jenis_kelamin;
            this.telp = telp;
            this.alamat = alamat;
            this.username = username;
            this.pass = pass;
            this.role = role;
            this.status = status;
            this.validPegawai = validPegawai;
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
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

        public string Jenis_kelamin
        {
            get { return jenis_kelamin; }
            set { jenis_kelamin = value; }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public int Role
        {
            get { return role; }
            set { role = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int ValidPegawai
        {
            get { return validPegawai; }
            set { validPegawai = value; }
        }

    }    
}
