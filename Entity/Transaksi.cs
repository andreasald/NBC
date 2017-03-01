using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNBC.Entity
{
    class Transaksi
    {
        string ID_Transaksi;
        string ID_Customer;
        int No_Ruang;
        string Kode_Promo;
        int ID_Shift;
        DateTime Tgl_Transaksi;
        string Keluhan;
        float Total;
        string Status_Transaksi;
        int ValidTransaksi;

        public int ValidTransaksi1
        {
            get { return ValidTransaksi; }
            set { ValidTransaksi = value; }
        }
        

       

       public Transaksi(string ID_Transaksi, string ID_Customer, int No_Ruang, string Kode_Promo, int ID_Shift, DateTime Tgl_Transaksi, string Keluhan, float Total, string Status_Transaksi,
       int ValidTransaksi)
       {
           this.ID_Customer = ID_Customer;
           this.ID_Shift = ID_Shift;
           this.ID_Transaksi = ID_Transaksi;
           this.Keluhan = Keluhan;
           this.Kode_Promo = Kode_Promo;
           this.No_Ruang = No_Ruang;
           this.Status_Transaksi = Status_Transaksi;
           this.Tgl_Transaksi = Tgl_Transaksi;
           this.Total = Total;
           this.ValidTransaksi = ValidTransaksi;
       }


       public string ID_Transaksi1
       {
           get { return ID_Transaksi; }
           set { ID_Transaksi = value; }
       }

       public string ID_Customer1
       {
           get { return ID_Customer; }
           set { ID_Customer = value; }
       }

       public int No_Ruang1
       {
           get { return No_Ruang; }
           set { No_Ruang = value; }
       }

       public string Kode_Promo1
       {
           get { return Kode_Promo; }
           set { Kode_Promo = value; }
       }

       public int ID_Shift1
       {
           get { return ID_Shift; }
           set { ID_Shift = value; }
       }


       public DateTime Tgl_Transaksi1
       {
           get { return Tgl_Transaksi; }
           set { Tgl_Transaksi = value; }
       }

       public string Keluhan1
       {
           get { return Keluhan; }
           set { Keluhan = value; }
       }
       public float Total1
       {
           get { return Total; }
           set { Total = value; }
       }


       public string Status_Transaksi1
       {
           get { return Status_Transaksi; }
           set { Status_Transaksi = value; }
       }

    }
}
