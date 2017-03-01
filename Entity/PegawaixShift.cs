using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNBC.Entity
{
    class PegawaixShift
    {
        int idPEG;
        int idShift;


        public PegawaixShift(int idPEG, int idShift)
        {
            this.idPEG = idPEG;
            this.idShift = idShift;
        }


        public int IdPEG
        {
            get { return idPEG; }
            set { idPEG = value; }
        }
        

        public int IdShift
        {
            get { return idShift; }
            set { idShift = value; }
        }
    }
}
