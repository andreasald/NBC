using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iNBC.Control;
using iNBC.Entity;
using iNBC.Boundary;
using iNBC.Boundary.KepalaKlinikUI;
using iNBC.Boundary.PendaftaranTransaksiUI;

namespace iNBC
{
    public partial class Pembayaran : Form
    {
        public Pembayaran()
        {
            InitializeComponent();
        }

        PegawaiControl PC = new PegawaiControl();
        PembayaranControl PBY_C = new PembayaranControl();

        public void hideStart()
        {
            lblGreet.Visible = false;
            lblGreet2.Visible = false;
            lblGreet3.Visible = false;
            lblGreet4.Visible = false;
            button1.Visible = false;
        }

        public void setDataGridView(DataGridView DG)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 12);


            DG.DataSource = PBY_C.getReceivable();

            //DG.Columns["ID_PEGAWAI"].DisplayIndex = 0;
            //DG.Columns["NAMAPGW"].DisplayIndex = 1;
            //DG.Columns["JKPGW"].DisplayIndex = 2;
            //DG.Columns["ALAMAT"].DisplayIndex = 3;
            //DG.Columns["NO_TELP"].DisplayIndex = 4;
            //DG.Columns["USERNAME"].DisplayIndex = 5;
            //DG.Columns["PASSWORDPGW"].DisplayIndex = 6;
            //DG.Columns["NAMA_ROLE"].DisplayIndex = 7;
            //DG.Columns["STATUSAVAILABLE"].DisplayIndex = 8;

            //DG.Columns[0].HeaderText = "ID";
            //DG.Columns[1].HeaderText = "Telepon";
            //DG.Columns[2].HeaderText = "Username";
            //DG.Columns[3].HeaderText = "Nama";
            //DG.Columns[4].HeaderText = "Alamat";
            //DG.Columns[5].HeaderText = "Jenis Kelamin";
            //DG.Columns[6].HeaderText = "Password";
            //DG.Columns[7].HeaderText = "Status";
            //DG.Columns[8].HeaderText = "Role";

            //DG.Columns[0].Width = 55;
            //DG.Columns[1].Width = 150;
            //DG.Columns[3].Width = 200;
            //DG.Columns[4].Width = 170;
            //DG.Columns[8].Width = 150;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KelolaPegawai_Load(object sender, EventArgs e)
        {
            tambahPegawai2.Visible = false;
            setDataGridView(this.dataGridView1);
            button1.Enabled = false;
        }

        
        private void tambahPegawai1_Load(object sender, EventArgs e)
        {
            
        }

        int flagperintah = 0;
        public void setFlag(int flag)
        {
            flagperintah = flag;
        }

        private void button1_Click(object sender, EventArgs e)//Button Tambah
        {
            hideStart();
            //tambahPegawai2.setFlag(1);
            //tambahPegawai2.Visible = true;
            setDataGridView(this.dataGridView1);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                DialogResult dr = MessageBox.Show("Silahkan Pilih Antrian", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                hideStart();
                inputPembayaran TransaksiKonsultasiDashBoard = new inputPembayaran();
                this.WindowState = FormWindowState.Minimized;
                TransaksiKonsultasiDashBoard.ShowDialog();
                this.WindowState = FormWindowState.Normal;
                setDataGridView(this.dataGridView1);
                txtID.Text = "";
            }
            
        }

        public void disable()
        {
            btnTambah.Enabled = false;
        }

        public void enable()
        {
            btnTampil.Enabled = true;

            setDataGridView(this.dataGridView1);
            dataGridView1.Rows[0].Selected = true;
        }

        public void setToolStripUser(string user)
        {
            this.toolStripStatusLabel1.Text = user;
        }

        private void toolStripUser_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripUser_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            searchDataGridView(dataGridView1, txtCari.Text);
        }

        public void searchDataGridView(DataGridView DG, string keyword)
        {
            DG.DataSource = PC.searchPegawai(keyword);
            /*
            
            string nama = getKolom(dataGridView1,3);
                string jk = getKolom(dataGridView1, 5);
                string alamat = getKolom(dataGridView1, 4);
                string telp = getKolom(dataGridView1, 1);
                string username = getKolom(dataGridView1, 2);
                string pass = getKolom(dataGridView1, 6);
                string role = getKolom(dataGridView1, 8);
                string status = getKolom(dataGridView1, 7);
             */
            
            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Telepon";
            DG.Columns[2].HeaderText = "Username";
            DG.Columns[3].HeaderText = "Nama";
            DG.Columns[4].HeaderText = "Alamat";
            DG.Columns[5].HeaderText = "Jenis Kelamin";
            DG.Columns[6].HeaderText = "Password";
            DG.Columns[7].HeaderText = "Status";
            DG.Columns[8].HeaderText = "Role";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
        }

        public void Enableedit()
        {
            txtCari.Enabled = true;
            dataGridView1.Enabled = true;
            btnTambah.Enabled = true;
            btnEdit.Enabled = true;
            btnTampil.Enabled = true;
            btnHapus.Enabled = true;

            setDataGridView(this.dataGridView1);
            dataGridView1.Rows[int.Parse(txtRow.Text)].Selected = true;
            txtID.Text = getKolomEdit(dataGridView1, int.Parse(txtRow.Text));
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

            hideStart();
            availablePromo availablePromoDashBoard = new availablePromo();
            this.WindowState = FormWindowState.Minimized;
            availablePromoDashBoard.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            hideStart();
        }

    }
}
