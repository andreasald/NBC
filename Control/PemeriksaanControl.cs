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
    class PemeriksaanControl
    {
        TRANSAKSITableAdapter T_TSC = new TRANSAKSITableAdapter();
        TRANSAKSI1TableAdapter T_TSC1 = new TRANSAKSI1TableAdapter();
        PEGAWAIxTRANSAKSITableAdapter T_PxT = new PEGAWAIxTRANSAKSITableAdapter();

        public DataTable getAntrianByDokter2(int idDok)
        {
            return T_PxT.getAntrianDokter(idDok);
        }

        public DataTable getRiwayatCustomerBy(string idcus)
        {
            return T_TSC.getRiwayatCustomer(idcus);
        }
    }
}
