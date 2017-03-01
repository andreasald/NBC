using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNBC.Entity
{
    class Role
    {
        int idRole;
        string nama_role;
        
        
		public Role(int idRole, string nama_role)
        {
            this.idRole = idRole;
            this.nama_role = nama_role;
        }



        public string Nama_role
        {
            get { return nama_role; }
            set { nama_role = value; }
        }

        public int IdRole
        {
            get { return idRole; }
            set { idRole = value; }
        }
    }
}
