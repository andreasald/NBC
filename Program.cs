using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using iNBC.Boundary;
using iNBC.Boundary.KepalaKlinikUI;
using iNBC.Boundary.PendaftaranTransaksiUI;
using iNBC.Boundary.KasirUI;

namespace iNBC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
