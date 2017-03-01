using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNBC.Entity
{
    class Jadwal
    {
        int IdShift;
        string start;
        string end;
        string hari;
        int validJadwal;

        public Jadwal(int IdShift, string start, string end, string hari, int validJadwal)
        {
            this.IdShift = IdShift;
            this.start = start;
            this.end = end;
            this.hari = hari;
            this.validJadwal = 1;
        }

        public int IdShift1
        {
            get { return IdShift; }
            set { IdShift = value; }
        }
        

        public string Start
        {
            get { return start; }
            set { start = value; }
        }
        

        public string End
        {
            get { return end; }
            set { end = value; }
        }
        

        public string Hari
        {
            get { return hari; }
            set { hari = value; }
        }
        

        public int ValidJadwal
        {
            get { return validJadwal; }
            set { validJadwal = value; }
        }
    }
}
