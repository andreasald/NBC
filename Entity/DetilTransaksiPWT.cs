using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNBC.Entity
{
    class DetilTransaksiPwt
    {
        String ID_Perawatan;
        String ID_Transaksi;
        int qtypwt;
        float subtotalpwt;
        int tukarpoin;

        public DetilTransaksiPwt(String ID_Perawatan, String ID_Transaksi, int qtypwt, float subtotalpwt, int tukarpoin)
        {
            this.ID_Perawatan = ID_Perawatan;
            this.ID_Transaksi = ID_Transaksi;
            this.qtypwt = qtypwt;
            this.subtotalpwt = subtotalpwt;
            this.tukarpoin = tukarpoin;
        }

        public String ID_Perawatan1
        {
            get { return ID_Perawatan; }
            set { ID_Perawatan = value; }
        }


        public String ID_Transaksi1
        {
            get { return ID_Transaksi; }
            set { ID_Transaksi = value; }
        }


        public int Qtypwt
        {
            get { return qtypwt; }
            set { qtypwt = value; }
        }


        public float Subtotalpwt
        {
            get { return subtotalpwt; }
            set { subtotalpwt = value; }
        }
        

        public int Tukarpoin
        {
            get { return tukarpoin; }
            set { tukarpoin = value; }
        }

        

    }
}
