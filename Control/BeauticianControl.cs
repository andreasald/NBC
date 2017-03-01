using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iNBC.DataSetNBCTableAdapters;
using System.Data;
using iNBC.Entity;
using System.Data.SqlClient;

namespace iNBC.Control
{
    class BeauticianControl
    {
        RUANGTableAdapter T_RUANG = new RUANGTableAdapter();
        PEGAWAITableAdapter T_PEG = new PEGAWAITableAdapter();

        public void updateStatusRuang(int noRuang)
        {
            T_RUANG.updateStatusRuangan(noRuang);
        }

        public void updateStatusPegawai(int idPeg)
        {
            T_PEG.updateStatusPegawaiAfterBTC(idPeg);
        }

        public void updateKeteranganRuangan(string keterangan, int noRuang)
        {
            T_RUANG.updateKeteranganRuang(keterangan,noRuang);
        }
    }
}
