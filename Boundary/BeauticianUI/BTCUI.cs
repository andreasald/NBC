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
using iNBC.Control;

namespace iNBC.Boundary.KepalaKlinikUI
{
    public partial class BTCUI : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["LoginForm"];
        TransactionControl TSC_C = new TransactionControl();
        BeauticianControl BTC_C = new BeauticianControl();

        int oke = 0;


        public BTCUI()
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


        private string getKolom(DataGridView dg, int i)
        {
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }

        private string getKolomEdit(DataGridView dg, int i)
        {
            return dg[dg.Columns[0].Index, dg.Rows[i].Index].Value.ToString();
        }

        private string getRow(DataGridView dg)
        {
            return dg.CurrentRow.Index.ToString();
        }




        private void KKUI_Load(object sender, EventArgs e)
        {
            //code load antrian?
            txtIDPeg.Text = ((LoginForm)f).txtID.Text;
            setDataGridView3(dataGridView3);

        }

        public void setDataGridView(DataGridView DG)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 12);

            DG.DataSource = TSC_C.tampilDetilPWT(idTransaksi.Text);

            DG.Columns[0].HeaderText = "Nama Perawatan";
            DG.Columns[1].HeaderText = "Kuantitas";
        }

        public void setDataGridView2(DataGridView DG)
        {
            this.dataGridView2.DefaultCellStyle.Font = new Font("Calibri", 12);

            DG.DataSource = TSC_C.tampilDetilPDK(idTransaksi.Text);

            DG.Columns[0].Visible = false;
            DG.Columns[1].Visible = false;
            DG.Columns[3].Visible = false;

            DG.Columns[4].DisplayIndex = 0;
            DG.Columns[2].DisplayIndex = 1;

            DG.Columns[4].HeaderText = "Nama Produk";
            DG.Columns[2].HeaderText = "Kuantitas";
        }

        public void setDataGridView3(DataGridView DG)
        {
            this.dataGridView3.DefaultCellStyle.Font = new Font("Calibri", 12);
            DG.DataSource = TSC_C.antrianUntukBTC(int.Parse(txtIDPeg.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Application.Restart();
        }


        private void makeItShow()
        {
            lblBTC.Visible = true;
            lblKtr.Visible = true;
            lblRng.Visible = true;
            btnSelesai.Visible = true;
            txtBTC.Visible = true;
            txtKeterangan.Visible = true;
            txtRuang.Visible = true;

            //txtIDTSC.Visible = false;
            btnConfirm.Visible = false;
            //lblTSC.Visible = false;
        }

        private void makeItHide()
        {
            lblBTC.Visible = false;
            lblKtr.Visible = false;
            lblRng.Visible = false;
            btnSelesai.Visible = false;
            txtBTC.Visible = false;
            txtKeterangan.Visible = false;
            txtRuang.Visible = false;

            //txtIDTSC.Visible = true;
            btnConfirm.Visible = true;
            //lblTSC.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (oke == 0)
            {
                DialogResult dr = MessageBox.Show("Silahkan pilih pelanggan terlebih dahulu", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                makeItShow();
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                txtKeluhan.Visible = false;
                setDataGridView3(dataGridView3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            makeItHide();
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            txtKeluhan.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (txtIDTSC.Text == "")
            {
                DialogResult dr = MessageBox.Show("Silahkan pilih transaksi", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                oke = 1;
                if (TSC_C.getIDtscbySearch(txtIDTSC.Text) != "Not Found")
                {
                    TSC_C.updateStatusToLunas(txtIDTSC.Text);
                    txtRuang.Text = TSC_C.getRuangByTransaksi(txtIDTSC.Text).ToString();
                    txtBTC.Text = TSC_C.getNamaBeauticianbyTransaksi(txtIDTSC.Text);
                    idTransaksi.Text = txtIDTSC.Text;
                    setDataGridView(this.dataGridView1);
                    setDataGridView2(this.dataGridView2);
                    txtKeluhan.Text = TSC_C.getKeluhanCus(idTransaksi.Text);
                    btnConfirm.Enabled = false;
                    DialogResult dr = MessageBox.Show("Pelanggan telah terpilih, silahkan lihat detil transaksi milik pelanggan", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else
                {
                    DialogResult dr = MessageBox.Show("Nomor transaksi tidak valid, silahkan periksa kembali nomor transaksi tersebut", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }



            }
            
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            int idPeg = TSC_C.getIDPegawai(txtBTC.Text);
            BTC_C.updateStatusPegawai(idPeg);
            BTC_C.updateStatusRuang(int.Parse(txtRuang.Text));
            BTC_C.updateKeteranganRuangan(txtKeterangan.Text,int.Parse(txtRuang.Text));

            DialogResult dr = MessageBox.Show("Perawatan Selesai","iNBC",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            makeItHide();
            txtIDTSC.Text = "";
            idTransaksi.Text = "";
            btnConfirm.Enabled = true;
            oke = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (oke == 0)
            {
                DialogResult dr = MessageBox.Show("Silahkan pilih pelanggan terlebih dahulu", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                makeItHide();
                txtIDTSC.Visible = false;
                btnConfirm.Visible = false;
                lblTSC.Visible = false;

                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                dataGridView3.Visible = false;
                txtKeluhan.Visible = true;
            }
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDTSC.Text = getKolom(dataGridView3, 0);
            txtID.Text = getKolom(dataGridView3, 0);
            txtRow.Text = getRow(dataGridView3);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDTSC.Text = getKolom(dataGridView3, 0);
            txtID.Text = getKolom(dataGridView3, 0);
            txtRow.Text = getRow(dataGridView3);
        }

        private void dataGridView3_KeyUp(object sender, KeyEventArgs e)
        {
            txtIDTSC.Text = getKolom(dataGridView3, 0);
            txtID.Text = getKolom(dataGridView3, 0);
            txtRow.Text = getRow(dataGridView3);
        }
    }
}
