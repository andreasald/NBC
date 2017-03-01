using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNBC.Entity
{
    class PegawaiXTransaksi
    {
        string idTransaksi;
        int idPegawai;

        public PegawaiXTransaksi(string idTransaksi, int idPegawai)
        {
            this.idTransaksi = idTransaksi;
            this.idPegawai = idPegawai;
        }

        public string IdTransaksi
        {
            get { return idTransaksi; }
            set { idTransaksi = value; }
        }


        public int IdPegawai
        {
            get { return idPegawai; }
            set { idPegawai = value; }
        }

    }
}
