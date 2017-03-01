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
    class CustomerControl
    {
        private CUSTOMERTableAdapter T_CSTMR = new CUSTOMERTableAdapter();

        public DataTable showCustomer()
        {
            return T_CSTMR.GetData();
        }

        public void addCustomer(Customer C)
        {
            T_CSTMR.InsertCustomer(C.ID1,C.Nama,C.TGL1,C.JK1,C.Alamat,C.Telp,C.Email,C.Alergi,C.TGL_Registrasi1,C.Poin,C.Password,1);
        }

        public void editCustomer(Customer C, String ID)
        {
            T_CSTMR.UpdateCustomer(C.Nama,C.TGL1,C.JK1,C.Alamat,C.Telp,C.Email,C.Alergi,C.TGL_Registrasi1,C.Password,ID);
        }

        public DateTime lastDate()
        {
            return T_CSTMR.LastDate().Value;
        }

        public string AmbilLastID()
        {
            return T_CSTMR.IDTerakhir();
        }

        public DataTable cariCustomer(string keyword)
        {
            return T_CSTMR.searchCustomer(keyword);
        }

        public int tryVerify(string id)
        {
            if (T_CSTMR.verifyCustomer(id) != null)
            {
                return 1;
            }

            else
            {
                return 0;
            }
        }

        public double getPoinCustomer(string id)
        {
            if (T_CSTMR.getPoin(id).HasValue)
            {
                return T_CSTMR.getPoin(id).Value;
            }
            else
            {
                return 0;
            }
        }

    }
}
