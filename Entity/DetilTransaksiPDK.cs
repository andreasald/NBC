using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNBC.Entity
{
    class DetilTransaksiPDK
    {
        int id_produk;
        string id_transaksi;
        int qtypdk;
        float subtotalpdk;

        public DetilTransaksiPDK(int id_produk, string id_transaksi, int qtypdk, float subtotalpdk)
        {
            this.id_produk = id_produk;
            this.id_transaksi = id_transaksi;
            this.qtypdk = qtypdk;
            this.subtotalpdk = subtotalpdk;
        }

        public int Id_produk
        {
            get { return id_produk; }
            set { id_produk = value; }
        }
        

        public string Id_transaksi
        {
            get { return id_transaksi; }
            set { id_transaksi = value; }
        }


        public int Qtypdk
        {
            get { return qtypdk; }
            set { qtypdk = value; }
        }
        

        public float Subtotalpdk
        {
            get { return subtotalpdk; }
            set { subtotalpdk = value; }
        }

        

    }
}
