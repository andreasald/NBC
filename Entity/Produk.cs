using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNBC.Entity
{
    class Produk
    {
        string namaPDK;
        string descPDK;
        int hargaPDK;
        int stockPDK;
        int ukuranPDK;
        string satuanPDK;
        int validPDK;

        

        public Produk(string namaPDK, string descPDK, int hargaPDK, int stockPDK, int ukuranPDK, string satuanPDK, int validPDK)
        {
            this.namaPDK = namaPDK;
            this.descPDK = descPDK;
            this.hargaPDK = hargaPDK;
            this.satuanPDK = satuanPDK;
            this.stockPDK = stockPDK;
            this.ukuranPDK = ukuranPDK;
            this.validPDK = validPDK;
        }
        
        public int ValidPDK
        {
            get { return validPDK; }
            set { validPDK = value; }
        }
        public string SatuanPDK
        {
            get { return satuanPDK; }
            set { satuanPDK = value; }
        }
        public int UkuranPDK
        {
            get { return ukuranPDK; }
            set { ukuranPDK = value; }
        }
        public int StockPDK
        {
            get { return stockPDK; }
            set { stockPDK = value; }
        }
        public int HargaPDK
        {
            get { return hargaPDK; }
            set { hargaPDK = value; }
        }
        public string DescPDK
        {
            get { return descPDK; }
            set { descPDK = value; }
        }
        public string NamaPDK
        {
            get { return namaPDK; }
            set { namaPDK = value; }
        }

    }
}
