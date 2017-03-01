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
using iNBC.Boundary.KepalaKlinikUI;
using iNBC.Boundary;
using iNBC.Boundary.PendaftaranTransaksiUI;

namespace iNBC
{
    public partial class Pemeriksaan : Form
    {

        int inProgress = 0;

        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["LoginForm"];

        public Pemeriksaan()
        {
            InitializeComponent();
        }

        PemeriksaanControl Periksa_C = new PemeriksaanControl();
        TransactionControl TC = new TransactionControl();


        public void hideStart()
        {
            lblGreet.Visible = false;
            lblGreet2.Visible = false;
            lblGreet3.Visible = false;
            lblGreet4.Visible = false;
            button1x.Visible = false;
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
            //tambahPromo1.setFlag(1);
            //tambahPromo1.Visible = true;
            //disable();
            setDataGridView(this.dataGridView1);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            inputPemeriksaan inputPeriksa = new inputPemeriksaan();
            this.WindowState = FormWindowState.Minimized;
            inputPeriksa.ShowDialog();
            this.WindowState = FormWindowState.Normal;
            
        }

        public void disable()
        {
            btnTambah.Enabled = false;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            btnTampil.Enabled = true;
        }

        public void enable()
        {
            btnTampil.Enabled = true;
            btnTambah.Enabled = true;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
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
            
        }

        public void searchDataGridView(DataGridView DG, int idDokter)
        {

            DG.DataSource = Periksa_C.getAntrianByDokter2(int.Parse(txtID.Text));

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
            
            /*DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Telepon";
            DG.Columns[2].HeaderText = "Username";
            DG.Columns[3].HeaderText = "Nama";
            DG.Columns[4].HeaderText = "Alamat";
            DG.Columns[5].HeaderText = "Jenis Kelamin";
            DG.Columns[6].HeaderText = "Password";
            DG.Columns[7].HeaderText = "Status";
            DG.Columns[8].HeaderText = "Role";*/
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
            //txtID.Text = getKolom(dataGridView1, 0);
            //txtRow.Text = getRow(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtID.Text = getKolom(dataGridView1, 0);
            //txtRow.Text = getRow(dataGridView1);
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            //txtID.Text = getKolom(dataGridView1, 0);
            //txtRow.Text = getRow(dataGridView1);
        }

        public void Enableedit()
        {;
            btnTambah.Enabled = true;
            btnEdit.Enabled = true;
            btnTampil.Enabled = true;
            btnHapus.Enabled = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            idRiwayatTransaksi.Text = "";
            setDataGridView(this.dataGridView1);
            btnPilih.Visible = true;

        }

        public void setDataGridView(DataGridView DG)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 12);

            if (inProgress == 0)
            {
                
                DG.DataSource = Periksa_C.getAntrianByDokter2(int.Parse(idDokter.Text));


                DG.Columns[0].Visible = false;
                DG.Columns[1].HeaderText = "Antrian";
                DG.Columns[2].HeaderText = "Nama Customer";
            }

            else if (inProgress == 1)
            {
                string idcus = TC.getIDPelanggan(txtID.Text);
                DG.DataSource = Periksa_C.getRiwayatCustomerBy(idcus);
                DG.Columns[0].HeaderText = "No Transaksi";
                DG.Columns[1].HeaderText = "No Customer";
                DG.Columns[2].HeaderText = "No Ruangan";
                DG.Columns[3].HeaderText = "Kode Promo";
                DG.Columns[4].HeaderText = "Shift";
                DG.Columns[5].HeaderText = "Tanggal";
                DG.Columns[6].HeaderText = "Keluhan";
                DG.Columns[7].HeaderText = "Total";
                DG.Columns[8].HeaderText = "Status";
                DG.Columns[9].HeaderText = "Valid";

                DG.Columns[0].Visible = false;
                DG.Columns[1].Visible = false;
                DG.Columns[2].Visible = false;
                DG.Columns[3].Visible = false;
                DG.Columns[4].Visible = false;
                DG.Columns[7].Visible = false;
                DG.Columns[8].Visible = false;
                DG.Columns[9].Visible = false;
                DG.Columns[10].Visible = false;
                DG.Columns[5].DefaultCellStyle.Format = "dd - MMMM - yyyy";
                
                DG.Columns[5].Width = 150;
                DG.Columns[6].Width = 410;


            }

            

            //DG.Columns[0].HeaderText = "ID";
            //DG.Columns[1].HeaderText = "Nama";
            //DG.Columns[2].HeaderText = "Tanggal Lahir";
            //DG.Columns[3].HeaderText = "Jenis Kelamin";
            //DG.Columns[4].HeaderText = "Alamat";
            //DG.Columns[5].HeaderText = "Telepon";
            //DG.Columns[6].HeaderText = "Email";
            //DG.Columns[7].HeaderText = "Alergi";
            //DG.Columns[8].HeaderText = "Tanggal Registrasi";
            //DG.Columns[9].HeaderText = "Poin";
            //DG.Columns[10].HeaderText = "Password";

            //DG.Columns[0].Width = 130;
            //DG.Columns[3].Width = 50;
            //DG.Columns[8].Width = 145;
            //DG.Columns[9].Width = 50;
            //DG.Columns[2].Width = 150;
            //DG.Columns[8].Width = 150;
            //DG.Columns[10].Width = 95;



            //DG.Columns[2].DefaultCellStyle.Format = "dd - MMMM - yyyy";
            //DG.Columns[8].DefaultCellStyle.Format = "dd - MMMM - yyyy";
            //DG.Columns[10].Visible = false;
        }

        private void Pengelolaan_Load(object sender, EventArgs e)
        {
            idDokter.Text = ((LoginForm)f).txtID.Text;
            tambahPromo1.Visible = false;
            button1x.Enabled = false;
            btnEdit.Enabled = false;
            btnTampil.Enabled = true;
            btnHapus.Enabled = false;
        }

        private void tambahPromo1_Load(object sender, EventArgs e)
        {

        }

        private void PengelolaanPromo_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            this.Hide();
            KKUI frm = new KKUI();
            frm.ShowDialog();
            this.Close();
             * */
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            hideStart();
            editPemeriksaan TransaksiKonsultasiDashBoard = new editPemeriksaan();
            this.WindowState = FormWindowState.Minimized;
            TransaksiKonsultasiDashBoard.ShowDialog();
            this.WindowState = FormWindowState.Normal;

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtID.Text = getKolom(dataGridView1, 1);
            idRiwayatTransaksi.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
            txtNamaCus.Text = getKolom(dataGridView1, 2);
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 1);
            idRiwayatTransaksi.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
            txtNamaCus.Text = getKolom(dataGridView1, 2);
        }

        private void dataGridView1_KeyUp_1(object sender, KeyEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 1);
            idRiwayatTransaksi.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
            txtNamaCus.Text = getKolom(dataGridView1, 2);
        }

        public void ShowStart()
        {
            lblGreet.Visible = true;
            lblGreet2.Visible = true;
            lblGreet3.Visible = true;
            lblGreet4.Visible = true;
            button1x.Visible = true;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            if (inProgress == 0)
            {
                if (txtID.Text == "")
                {
                    DialogResult dr = MessageBox.Show("Silahkan pilih antrian", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    setDataGridView(this.dataGridView1);
                    hideStart();
                }

                else
                {
                    idTransaksinya.Text = txtID.Text;
                    inProgress = 1;
                    btnTambah.Enabled = false;
                    btnEdit.Enabled = true;
                    btnTampil.Enabled = true;
                    btnHapus.Enabled = true;
                    btnSelesai.Text = "Selesai";
                    lblNamaPelanggan.Text = txtNamaCus.Text;
                    lblNoAntrian.Text = txtID.Text.Substring(7);
                    
                }
                
                
                
            }

            else if (inProgress == 1)
            {
                DialogResult dr = MessageBox.Show("Anda yakin telah selesai pemeriksaan dengan pasien ini?", "iNBC", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

                if (dr == DialogResult.Yes)
                {
                    DialogResult drX = MessageBox.Show("Pemeriksaan pelanggan" + lblNamaPelanggan.Text + " telah selesai. Silahkan pilih antrian berikutnya", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    inProgress = 0;
                    btnTambah.Enabled = true;
                    btnEdit.Enabled = false;
                    btnTampil.Enabled = true;
                    btnHapus.Enabled = false;
                    dataGridView1.Enabled = true;
                    btnSelesai.Text = "Pilih";
                    lblNoAntrian.Text = "-";
                    lblNamaPelanggan.Text = "-";
                    hideRiwayatStuff();
                    ShowStart();
                    
                }

                
            }

        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            if (idRiwayatTransaksi.Text == "")
            {
                DialogResult dr = MessageBox.Show("Silahkan pilih transaksi yang ingin dilihat detailnya","iNBC",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else 
            {
                setDataGridView2(this.dataGridView2);
                setDataGridView3(this.dataGridView3);
                enableRiwayatStuff();
                txtRwytKeluhan.Text = TC.getKeluhanCus(idRiwayatTransaksi.Text);
            }
            

        }

        public void setDataGridView2(DataGridView DG)
        {
            DG.DataSource = TC.tampilDetilPDK(txtID.Text);

            DG.Columns[0].Visible = false;
            DG.Columns[1].Visible = false;
            DG.Columns[3].Visible = false;

            DG.Columns[4].DisplayIndex = 0;
            DG.Columns[2].DisplayIndex = 1;

            DG.Columns[4].HeaderText = "Nama Produk";
            DG.Columns[2].HeaderText = "Kuantitas";

            DG.Columns[4].Width = 182;
            DG.Columns[2].Width = 65;
        }

        public void setDataGridView3(DataGridView DG)
        {
            DG.DataSource = TC.tampilDetilPWT(txtID.Text);

            DG.Columns[0].HeaderText = "Nama Perawatan";
            DG.Columns[1].HeaderText = "Kuantitas";

            DG.Columns[0].Width = 182;
            DG.Columns[1].Width = 65;

        }

        public void enableRiwayatStuff()
        {
            lblDetilPerawatan.Visible = true;
            lblDetilProduk.Visible = true;
            dataGridView2.Visible = true;
            dataGridView3.Visible = true;
            btnPilih.Visible = true;
            txtRwytKeluhan.Visible = true;
            label4.Visible = true;
        }

        public void hideRiwayatStuff()
        {
            lblDetilPerawatan.Visible = false;
            lblDetilProduk.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            btnPilih.Visible = false;
            txtRwytKeluhan.Visible = false;
            label4.Visible = false;
        }

    }
}
