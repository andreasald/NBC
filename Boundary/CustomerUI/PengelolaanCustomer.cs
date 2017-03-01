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
using iNBC.Boundary;
using iNBC.Boundary.CustomerUI;



namespace iNBC
{
    public partial class PengelolaanCustomer : Form
    {
        public int todayCustomer = 0;

        public PengelolaanCustomer()
        {
            InitializeComponent();
        }

        CustomerControl CSTMR_C = new CustomerControl();

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
            
            DG.DataSource = CSTMR_C.showCustomer();

            DataTable DT = CSTMR_C.showCustomer();
            BindingList<DataTable> listTbl = new BindingList<DataTable>();
            if (DT.Rows.Count > 0)
            {
                int counter = 0, subTblIndex = -1;
                foreach (DataRow dr in DT.Rows)
                {
                    if (counter == 0)
                    {
                        listTbl.Add(DT.Clone());
                        subTblIndex++;
                    }
                    listTbl[subTblIndex].Rows.Add(dr.ItemArray);
                    counter++;
                    if (counter == 10) counter = 0; //set jumlah baris
                }
            }
            bindingSource1.DataSource = listTbl;
            bindingNavigator1.BindingSource = bindingSource1;
            DG.DataSource = (DT.Rows.Count > 0 ? listTbl[bindingSource1.Position] : DT);


            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Tanggal Lahir";
            DG.Columns[3].HeaderText = "Jenis Kelamin";
            DG.Columns[4].HeaderText = "Alamat";
            DG.Columns[5].HeaderText = "Telepon";
            DG.Columns[6].HeaderText = "Email";
            DG.Columns[7].HeaderText = "Alergi";
            DG.Columns[8].HeaderText = "Tanggal Registrasi";
            DG.Columns[9].HeaderText = "Poin";
            DG.Columns[10].HeaderText = "Password";

            DG.Columns[0].Width = 130;
            DG.Columns[3].Width = 50;
            DG.Columns[8].Width = 145;
            DG.Columns[9].Width = 50;
            DG.Columns[2].Width = 150;
            DG.Columns[8].Width = 150;
            DG.Columns[10].Width = 95;



            DG.Columns[2].DefaultCellStyle.Format = "dd - MMMM - yyyy";
            DG.Columns[8].DefaultCellStyle.Format = "dd - MMMM - yyyy";
            DG.Columns[10].Visible = false;
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
      
        int flagperintah = 0;
        public void setFlag(int flag)
        {
            flagperintah = flag;
        }

        private void button1_Click(object sender, EventArgs e)//Button Tambah
        {
            hideStart();
            tambahCustomer1.setFlag(1);
            tambahCustomer1.Visible = true;
            disable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            hideStart();
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih data yang akan diubah","iNBC",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                dataGridView1.Focus();
            }
            else
            {
                editCustomer1.setFlag(2);
                string ID = getKolom(dataGridView1, 0);
                string nama = getKolom(dataGridView1,1);
                string tgl_lahir = getKolom(dataGridView1, 2);
                string jk = getKolom(dataGridView1, 3);
                string alamat = getKolom(dataGridView1, 4);
                string telp = getKolom(dataGridView1, 5);
                string email = getKolom(dataGridView1, 6);
                string alergi = getKolom(dataGridView1, 7);
                string tgl_registrasi = getKolom(dataGridView1, 8);
                string poin = getKolom(dataGridView1, 9);
                string password = getKolom(dataGridView1, 10);
                editCustomer1.isiTextBox(nama,tgl_lahir,jk,alamat,telp,email,alergi,password,ID);
                editCustomer1.Visible = true;
                txtID.Clear();
                disable();

            }
        }

        public void disable()
        {
            btnTambah.Enabled = false;
            btnEdit.Enabled = false;
            btnCetak.Enabled = false;
            dataGridView1.Enabled = false;
            btnTampil.Enabled = false;
            txtCari.Enabled = false;
        }

        public void enable()
        {
            btnTampil.Enabled = true;
            btnTambah.Enabled = true;
            btnEdit.Enabled = true;
            btnCetak.Enabled = true;
            dataGridView1.Enabled = true;
            txtCari.Enabled = true;

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
            
            DG.DataSource = CSTMR_C.cariCustomer(keyword);
            
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
            btnCetak.Enabled = true;

            setDataGridView(this.dataGridView1);
            dataGridView1.Rows[int.Parse(txtRow.Text)].Selected = true;
            txtID.Text = getKolomEdit(dataGridView1, int.Parse(txtRow.Text));
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e) //button cetak ya
        {

            hideStart();
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih Customer yang akan dicetak kartunya", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView1.Focus();
            }
            else
            {
                this.Hide();
                CetakKartuCustomer ctk = new CetakKartuCustomer();
                ctk.ShowDialog();
                this.Show();
            }
        }

        private void Pengelolaan_Load(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;
            tambahCustomer1.Visible = false;
            editCustomer1.Visible = false;
            setDataGridView(this.dataGridView1);
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

        private void tambahCustomer1_Load(object sender, EventArgs e)
        {

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {

            hideStart();
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            this.searchDataGridView(dataGridView1, this.txtCari.Text);
            if (txtCari.Text == "")
            {
                this.setDataGridView(dataGridView1);
            }
        }
    }
}
