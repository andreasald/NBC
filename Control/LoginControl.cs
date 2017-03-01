using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iNBC.DataSetNBCTableAdapters;

namespace iNBC.Control
{
    class LoginControl
    {
        PEGAWAITableAdapter T_pgw = new PEGAWAITableAdapter();



        public bool cekLogin(string user, string pass)
        {
            bool cek = false;
            try
            {
                if (T_pgw.LoginValidator(user, pass).Equals(user.ToUpper()))
                {
                    cek = true;
                }
            }
            catch (Exception ex)
            {
                cek = false;
            }

            return cek;
        }


        public int GetRoleUser(string user, string pass)
        {
            int role = 0;
            try
            {
                role = int.Parse(T_pgw.GetRole(user, pass).ToString());
            }
            catch (Exception ex)
            {
                role = 0;
            }

            return role;
        }

        public int getIDPegawaiYangLogin(string username)
        {
            if (T_pgw.getIDPegawaiLogin(username).HasValue)
            {
                return T_pgw.getIDPegawaiLogin(username).Value;
            }
            else 
            {
                return -1;
            }
        }





    }


    

}
