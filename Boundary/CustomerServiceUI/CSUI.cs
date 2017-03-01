using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iNBC.Boundary.PendaftaranTransaksiUI;
using iNBC.Boundary.JadwalUI;

namespace iNBC.Boundary.KepalaKlinikUI
{
    public partial class CSUI : Form
    {
        public CSUI()
        {
            InitializeComponent();
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            PengelolaanCustomer CustomerDashBoard = new PengelolaanCustomer();
            this.WindowState = FormWindowState.Minimized;
            CustomerDashBoard.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            DialogResult dX = CustomMessage.Show("Pilih jenis transaksi", "Konsultasi", "Non-Konsultasi", "Cancel");

            if (dX == DialogResult.Yes)
            {
                PendaftaranTransaksi TransaksiKonsultasiDashBoard = new PendaftaranTransaksi();
                this.WindowState = FormWindowState.Minimized;
                TransaksiKonsultasiDashBoard.ShowDialog();
                this.WindowState = FormWindowState.Normal;
            }

            if (dX == DialogResult.No)
            {
                PendaftaranNK NK = new PendaftaranNK();
                this.WindowState = FormWindowState.Minimized;
                NK.ShowDialog();
                this.WindowState = FormWindowState.Normal;

            }
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
