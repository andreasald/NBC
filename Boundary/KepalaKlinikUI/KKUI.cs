using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iNBC.Boundary.KepalaKlinikUI
{
    public partial class KKUI : Form
    {
        public KKUI()
        {
            InitializeComponent();
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            //this.Hide();
            PengelolaanJadwal JadwalDashBoard = new PengelolaanJadwal();
            this.WindowState = FormWindowState.Minimized;
            JadwalDashBoard.ShowDialog();
            this.WindowState = FormWindowState.Normal;
            
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            //this.Hide();
            PengelolaanPromo PromoDashBoard = new PengelolaanPromo();
            this.WindowState = FormWindowState.Minimized;
            PromoDashBoard.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void KKUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void KKUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Application.Restart();
        }
    }
}
