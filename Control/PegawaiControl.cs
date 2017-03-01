using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iNBC.DataSetNBCTableAdapters;
using System.Data;
using iNBC.Entity;

namespace iNBC.Control
{
    class PegawaiControl
    {
        private PEGAWAITableAdapter T_Pgw = new PEGAWAITableAdapter();
        private ROLETableAdapter Role = new ROLETableAdapter();
        
        public DataTable showPegawai()
        {
            return T_Pgw.GetData();
        }

        public DataTable getNamaRole()
        {
            return Role.GetData();
        }

        public int getIdRole(string namaRole)
        {
            return Role.GetIDROLE(namaRole).Value;
        }


        public DataTable searchPegawai(string keyword)
        {
            return T_Pgw.GetDataBySearchPegawai(keyword);
        }

        public void addPegawai(Pegawai P)
        {
            T_Pgw.InsertPegawai(P.Role,P.Telp,P.Username,P.Nama,P.Alamat,P.Jenis_kelamin,P.Pass,P.Status,1);
        }

        public void editPegawai(Pegawai P, int id)
        {
            T_Pgw.UpdatePegawai(P.Telp, P.Username, P.Nama, P.Alamat, P.Jenis_kelamin, P.Pass, P.Status, P.Role, id);
        }

        public void deletePegawai(int idpegawai)
        {
            T_Pgw.DeletePegawai(idpegawai);
               
        }

        public string unikUsername(string calonUsername)
        {
            return  T_Pgw.getUsernamePGW(calonUsername);
        }



    }
}
