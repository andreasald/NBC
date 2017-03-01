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
    class TransactionControl
    {
        private PEGAWAIxSHIFTTableAdapter T_PxS = new PEGAWAIxSHIFTTableAdapter();
        private PEGAWAIxTRANSAKSITableAdapter T_PxT = new PEGAWAIxTRANSAKSITableAdapter();
        private PEGAWAITableAdapter T_PEG = new PEGAWAITableAdapter();
        private JADWALTableAdapter T_JDWL = new JADWALTableAdapter();
        private TRANSAKSITableAdapter T_TSC = new TRANSAKSITableAdapter();
        private TRANSAKSI2TableAdapter T_TSC2 = new TRANSAKSI2TableAdapter();
        private RUANGTableAdapter T_RUANG = new RUANGTableAdapter();
        private PERAWATANTableAdapter T_PWT = new PERAWATANTableAdapter();
        private PRODUKTableAdapter T_PDK = new PRODUKTableAdapter();
        private DETIL_TRANSAKSI_PWTTableAdapter T_dtlPWT = new DETIL_TRANSAKSI_PWTTableAdapter();
        private DETIL_TRANSAKSI_PDKTableAdapter T_dtlPDK = new DETIL_TRANSAKSI_PDKTableAdapter();
        private CUSTOMERTableAdapter T_CUS = new CUSTOMERTableAdapter();
        private antrianBTCTableAdapter T_ANTRIAN = new antrianBTCTableAdapter();

        public DataTable getDokterAvailable(string shift, string hari)
        {
            return T_PxS.getDokterByShiftAndDays(shift,hari);
        }

        public DataTable getBeauticianAvailable(string shift, string hari)
        {
            return T_PxS.getBeauticianByShiftAndDays(shift, hari);
        }

        public DataTable getBeauticianCewekAvailable(string shift, string hari)
        {
            return T_PxS.getBeauticianWanitaAvailable(shift, hari);
        }

        public DataTable getBeauticianCowokAvailable(string shift, string hari)
        {
            return T_PxS.getBeauticiaPriaAvailable(shift,hari);
        }

        public DataTable getRoomsAvailable()
        {
            return T_RUANG.getRuangAvailable();
        }

        public DataTable getPerawatan()
        {
            return T_PWT.GetData();
        }

        public DataTable getPerawatanNonMedisMain()
        {
            return T_PWT.GetPerawatanNonMedis();
        }

        public DataTable getProduk()
        {
            return T_PDK.GetData();
        }

        public string getIDPerawatan(string namaPerawatan)
        {
            return T_PWT.getIDPerawatan(namaPerawatan);
        }

        public int getIDProduk(string namaProduk)
        {
            return T_PDK.getIDProduk(namaProduk).Value;
        }

        public void addTransaksi(Transaksi T)
        {
            T_TSC.insertTransaksi(T.ID_Transaksi1,T.ID_Customer1,T.No_Ruang1,T.Kode_Promo1,T.ID_Shift1,T.Tgl_Transaksi1,T.Keluhan1,T.Total1,T.Status_Transaksi1,T.ValidTransaksi1);
        }

        public void addDetilTransaksi(DetilTransaksiPwt dtlPWT)
        {
            T_dtlPWT.insertDetilPerawatan(dtlPWT.ID_Perawatan1, dtlPWT.ID_Transaksi1, dtlPWT.Qtypwt, dtlPWT.Subtotalpwt, dtlPWT.Tukarpoin);
        }

        public void addDetilTransaksiPDK(DetilTransaksiPDK dtlPDK)
        {
            T_dtlPDK.insertDetilProduk(dtlPDK.Id_produk,dtlPDK.Id_transaksi,dtlPDK.Qtypdk,dtlPDK.Subtotalpdk);
        }

        public string ambilLastIDTransaksi()
        {
            return T_TSC.getLastTransactionID();
        }

        public DateTime ambilLastDate()
        {
            return T_TSC.getLastTransactionDate().Value;
        }

        public string statusTransaksiCustomer(string id)
        {
            return T_TSC.alternativeGetStatusTransaksiCustomer(id);
        }

        public float getHargaPerawatan(string id)
        {
            return float.Parse(T_PWT.getHargaPerawatan(id).ToString());
        }

        public float getHargaProduk(int id)
        {
            return float.Parse(T_PDK.getHargaProduk(id).ToString());
        }

        public string getDetilTransakaiPerawatan(string id)
        {
            return T_dtlPWT.availableData(id);
        }

        public void deleteCanceledTransaction(string id)
        {
            T_TSC.deleteCanceledTransaction(id);
        }

        public void deleteDetilPWTCanceledTransaction(string id)
        {
            T_dtlPWT.deleteDetilTransaksiPwt(id);
        }

        public void deleteDetilPDKCanceledTransaction(string id)
        {
            T_dtlPDK.deleteDetilTransaksiPdk(id);
        }

        public void addTransaksiXPegawai(PegawaiXTransaksi PxTData)
        {
            T_PxT.insertPegawaiXTransaksi(PxTData.IdPegawai,PxTData.IdTransaksi);
        }

        public int getIDPegawai(string nama)
        {
            return T_PEG.GetIdPegawai(nama).Value;
        }

        public void updateDataTransaksi(Transaksi T, string id)
        {
            T_TSC.updateTransaksiOk(T.ID_Customer1,T.No_Ruang1,T.Keluhan1,T.ID_Shift1,T.Status_Transaksi1,T.ValidTransaksi1,id);
        }

        public void updateKeluhanOlehDokter(string keluhan, string idT)
        {
            T_TSC.UpdateKeluhanByDokter(keluhan, idT);
        }

        public DataTable showDetilPWT(string id)
        {
            return T_dtlPWT.GetDetilPerawatanByIdTransaksi(id);
        }

        public DataTable tampilDetilPWT(string id)
        {
            return T_dtlPWT.GetDtlPwtbyTscId(id);
        }

        public DataTable tampilDetilPDK(string id)
        {
            return T_dtlPDK.GetDtlPdkbyTscId(id);
        }

        public void updateDetilPWT(DetilTransaksiPwt dtl, string id)
        {
            T_dtlPWT.updateDetilTransaksi(dtl.Qtypwt, id);
        }

        public void updateDetilPDK(DetilTransaksiPDK dtl, int id)
        {
            T_dtlPDK.updateDetilTransaksiProduk(dtl.Qtypdk, id);
        }

        public string cekSudahDisana(string idTSC, string idPWT)
        {
            return T_dtlPWT.getAlreadyThere(idTSC, idPWT);
        }

        public int cekSudahDisanaProduk(string idTSC, int idPDK)
        {
            if (T_dtlPDK.getSudahDisana(idTSC, idPDK).HasValue)
            {
                return T_dtlPDK.getSudahDisana(idTSC, idPDK).Value;
            }

            else
            {
                return 0;
            }
        }

        public int getKuantitasX(string idPWT,string idTSC)
        {
            if (int.Parse(T_dtlPWT.getKuantitas(idPWT, idTSC).ToString()) != 0)
            {
                return int.Parse(T_dtlPWT.getKuantitas(idPWT, idTSC).ToString());
            }

            else
            {
                return 0;
            }

        }

        public int getKuantitasPDK(int idPdk, string idTSC)
        {
            return T_dtlPDK.getKuantitasProduk(idPdk, idTSC).Value;
        }

        public void deletePerawatanIni(string idT, string idP)
        {
            T_dtlPWT.deleteSelectedPerawatan(idT, idP);
        }

        public void deleteProdukIni(string idT, int idPdk)
        {
            T_dtlPDK.deleteSelectedProduk(idT,idPdk);
        }

        public string getIDPelanggan(string idTSC)
        {
            return T_TSC.getIDCustomer(idTSC);
        }

        public string getKeluhanCus(string idTSC)
        {
            return T_TSC.getKeluhanBy(idTSC).ToString();
        }

        public DataTable getAntrianEdit()
        {
            return T_TSC2.GetDataReceiveable();
        }

        public void updatePegawaiXTransaksi(PegawaiXTransaksi PxTnew, int idPlama, string idTlama)
        {
            T_PxT.updatePegawaiXTransaksi(PxTnew.IdPegawai, PxTnew.IdTransaksi,idPlama,idTlama);
        }

        public int getBeauticianYangLama(string idTSC)
        {
            return T_PxT.getBeauticianLama(idTSC).Value;
        }

        public string getNamaBeauticianbyTransaksi(string idT)
        {
            return T_PxT.getNamaBeauticianByIDTransaksi(idT);
        }

        public int getRuangByTransaksi(string idT)
        {
            return T_TSC.getRuangByTransaksi(idT).Value;
        }

        public string getJenisKelCus(string idT)
        {
            return T_TSC.getJenisKelaminCustomer(idT);
        }

        public string getJenisKelaminCustomerByIDCus(string idCus)
        {
            return T_CUS.getJenisKelaminCustomerByidMereka(idCus);
        }

        public double getTotalDuitPWT(string idT)
        {
            if (double.Parse(T_dtlPWT.getSubTotalPwtBy(idT).ToString())!=0)
            {
                return double.Parse(T_dtlPWT.getSubTotalPwtBy(idT).ToString());
            }

            else
            {
                return 0;
            }
            
        }

        public double getTotalDuitPDK(string idT)
        {
            if (T_dtlPDK.getSubTotalPDKby(idT).HasValue)
            {
                return T_dtlPDK.getSubTotalPDKby(idT).Value;
            }
            else
            {
                return 0;
            }
        }

        public void setPayed(string idTransaksi)
        {
            T_TSC.updateStatusTransaksi(idTransaksi);
        }

        public DataTable tampilDetilPWTutkKasir(string id)
        {
            return T_dtlPWT.getDetilPwtUntukKasir(id);
        }

        public DataTable tampilDetilPDKutkKasir(string id)
        {
            return T_dtlPDK.getDetilUntukKasir(id);
        }

        public void updatePoinCust(int poinbaru, string idCustomer)
        {
            T_CUS.updatePoinCust(poinbaru, idCustomer);
        }

        public void updateDetilPWTPromo(string idPWT, string idTSC, int qty, float subtotal)
        {
            T_dtlPWT.updateDETILpwtAfterPoin(qty, subtotal, idPWT, idTSC);
        }

        public double getSubtotalSingle(string idT, string idPWT)
        {
            if (T_dtlPWT.getSubTotalsingle(idPWT, idT).HasValue)
            {
                return T_dtlPWT.getSubTotalsingle(idPWT, idT).Value;
            }

            else
            {
                return 0;
            }
        }

        public void updateStockProduk(int stokBaru, int ID)
        {
            T_PDK.updateStockPDK(stokBaru,ID);
        }

        public int getStockProdukNow(int idPDK)
        {
            if (T_PDK.getStockProduk(idPDK).HasValue)
            {
                return T_PDK.getStockProduk(idPDK).Value;
            }
            else
            {
                return 0;
            }
        }

        public void updateKodePromoInTransaksi(string kodePromo, string idTSC)
        {
            T_TSC.updateKodePromoTransaksi(kodePromo,idTSC);
        }

        public void updateStatusToLunas(string idTSC)
        {
            T_TSC.updateStatusLunas(idTSC);
        }

        public string getIDtscbySearch(string idtsc)
        {
            if (T_TSC.getIDtsc(idtsc) != null)
            {
                return T_TSC.getIDtsc(idtsc);
            }

            else
            {
                return "Not Found";
            }

        }

        public int getRuangTransaksi(string idTSC)
        {
            if (T_TSC.getRuangByIDTSC(idTSC).HasValue)
            {
                return T_TSC.getRuangByIDTSC(idTSC).Value;
            }

            else
            {
                return 0;
            }
        }

        public void updateTukarPoin(int poin, string idP, string idT)
        {
            T_dtlPWT.updatePoinYgDitukar(poin,idP,idT);
        }

        public int ambilTukaredPoin(string idP, string idT)
        {
            return T_dtlPWT.getTukaredPoinLama(idP,idT).Value;
        }

        public void updateTotalTransaksi(double newTotal, string idT)
        {
            T_TSC.updateTotalTransaksi(newTotal,idT);
        }

        //BIG REVOLUTION
        public void updateStatusPegawaiSelectedBy(int idP)
        {
            T_PEG.updateStatusPegawaiSelected(idP);
        }

        public void updateStatusRuanganSelectedBy(int noRuang)
        {
            T_RUANG.updateStatusRuanganDipakai(noRuang);
        }
        //BIG REVOLUTION


        //BIG REVOLUTION VI
        public DataTable antrianUntukBTC(int idPeg)
        {
            return T_ANTRIAN.getAntriannyaBTC(idPeg);
        }



    }
}
