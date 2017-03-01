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
    class ProdukControl
    {
        PRODUKTableAdapter T_PDK = new PRODUKTableAdapter();

        public DataTable showProduk()
        {
            return T_PDK.GetData();
        }

        public void addProduk(Produk Pdk)
        {
            T_PDK.InsertProduk(Pdk.NamaPDK, Pdk.DescPDK, Pdk.HargaPDK, Pdk.StockPDK, Pdk.UkuranPDK, Pdk.SatuanPDK, 1);
        }

        public void editProduk(Produk Pdk, int id)
        {
            T_PDK.UpdateProduk(Pdk.NamaPDK, Pdk.DescPDK, Pdk.HargaPDK, Pdk.StockPDK, Pdk.UkuranPDK, Pdk.SatuanPDK, id);
        }

        public void deleteProduk(int idproduk)
        {
            T_PDK.DeleteProduk(idproduk);
        }


    }
}
