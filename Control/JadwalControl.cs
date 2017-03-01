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
    class JadwalControl
    {
        private PEGAWAIxSHIFTTableAdapter T_PxS = new PEGAWAIxSHIFTTableAdapter();
        private PEGAWAITableAdapter T_PEG = new PEGAWAITableAdapter();
        private JADWALTableAdapter T_JDWL = new JADWALTableAdapter();

        public DataTable showPromo()
        {
            return T_PxS.GetData();
        }

        public DataTable getNamaPegawai()
        {
            return T_PEG.GetData();
        }

        public DataTable getNamaDokter()
        {
            return T_PEG.GetDataNamaDokter();
        }

        public DataTable getNamaBeautician()
        {
            return T_PEG.GetDataNamaBeautician();
        }


        public int getIdPegawai(string nama)
        {
            return T_PEG.GetIdPegawai(nama).Value;
        }

        public DataTable getShift()
        {
            return T_JDWL.GetData();
        }

        public int getIdShift(string nama,string hari)
        {
            return T_JDWL.getIdJadwal(nama,hari).Value;
        }

        
        public void addJadwal(PegawaixShift PxS)
        {
            T_PxS.InsertPEGAWAIxSHIFT(PxS.IdPEG, PxS.IdShift);
        }

        public void editJadwal(PegawaixShift PxS, int idP, int idS)
        {
            T_PxS.UpdatePEGAWAIXSHIFT(PxS.IdPEG, PxS.IdShift, idP, idS);
        }

        public int cekNjumlahJaga(int id)
        {
            return T_PxS.HitungJumlahJaga(id).Value;
        }

        public void deleteJadwal(int idP, int idS)
        {
            T_PxS.DeleteJadwal(idP, idS);
        }

    }
}
