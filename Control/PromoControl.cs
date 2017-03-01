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
    class PromoControl
    {
        private PROMOTableAdapter T_PRO = new PROMOTableAdapter();

        public DataTable showPromo()
        {
            return T_PRO.GetData();
        }

        public DataTable searchPromo(string keyword)
        {
            return T_PRO.searchPromo(keyword);
        }

        public void addPromo(Promo P)
        {
            T_PRO.InsertPromo(P.Kode, P.Nama, P.Diskon, P.Start, P.End, P.Status, 1);
        }

        public void editPromo(Promo Pro, string id)
        {
            T_PRO.UpdatePromo(Pro.Nama,Pro.Diskon,Pro.Start,Pro.End,Pro.Status,id);
        }

        public void deleteProduk(string idproduk)
        {
            T_PRO.DeletePromo(idproduk);

        }
    }
}
