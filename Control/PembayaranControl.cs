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
    class PembayaranControl
    {
        private TRANSAKSITableAdapter T_TSC = new TRANSAKSITableAdapter();
        private TRANSAKSI2TableAdapter T_TSC2 = new TRANSAKSI2TableAdapter();
        private PROMOTableAdapter T_PRO = new PROMOTableAdapter();
        private PEGAWAIxTRANSAKSITableAdapter T_PxT = new PEGAWAIxTRANSAKSITableAdapter();
        private PEGAWAITableAdapter T_PEG = new PEGAWAITableAdapter();
        private DETIL_TRANSAKSI_PWTTableAdapter T_dtlPWT = new DETIL_TRANSAKSI_PWTTableAdapter();
        private DETIL_TRANSAKSI_PDKTableAdapter T_dtlPDK = new DETIL_TRANSAKSI_PDKTableAdapter();
        private CUSTOMERTableAdapter T_Cus = new CUSTOMERTableAdapter();

        public DataTable getReceivable()
        {
            return T_TSC2.GetDataReceiveable();
        }

        public DataTable getAvailablePromo(string tanggal)
        {
            return T_PRO.getAvailablePromo(tanggal);
        }

        public double getBesarDiskon(string kode)
        {
            if (T_PRO.getBesarDiskon(kode).HasValue)
            {
                return T_PRO.getBesarDiskon(kode).Value;
            }

            else
            {
                return 0;
            }
        }

        public string getNamaCustByIDT(string idT)
        {
            return T_TSC.getNamaCustomer(idT);
        }

        public string getNamaDokterByIdt(string idT)
        {
            return T_PxT.getNamaDokterByIdt(idT);
        }

        public string getKodePromo(string idT)
        {
            return T_TSC.getKodePromoTscCusByid(idT);
        }

        public string AmbilNamaPegawai(int id)
        {
            return T_PEG.getNamaPegawaiBy(id);
        }

        public double AmbilTotalTransaksi(string idT)
        {
            return T_TSC.getTotalTransaksi(idT).Value;
        }

        public double getSubtotalPDKAllbyTSCID(string idT)
        {
            return double.Parse(T_dtlPDK.getTotalSubPDKbyIDt(idT).ToString());
        }

        public double getSubtotalPWTAllbyTSCID(string idT)
        {
            return double.Parse(T_dtlPWT.getTotalDetilPWTbyIDT(idT).ToString());
        }

        public string getNamaPetugasCus(string idT)
        {
            return T_PxT.getNamaKasir(idT).ToString();
        }

        public DateTime getTanggalLahirCustomerBy(string idT)
        {
            return DateTime.Parse(T_Cus.getTanggalLahirCustomer(idT).ToString());
        }

        public void setValidBirthday(int TheValue)
        {
            T_PRO.updatePromoBirthday(TheValue);
        }

        public void updateSubTotalPWTBy(double nilaiBaru, string idPWT, string idT)
        {
            T_dtlPWT.updateSubtotal(nilaiBaru,idPWT,idT);
        }

        public void updateSubTotalPDKBy(double nilaiBAru, int idPDK, string idT)
        {
            T_dtlPDK.updateSubtotalPDK(nilaiBAru, idT, idPDK);
        }

        public double getSubtotalSinglePWT(string idPWT, string idTSC)
        {
            return T_dtlPWT.getSubTotalsingle(idPWT, idTSC).Value;
        }
    }
}
