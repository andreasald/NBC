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

namespace iNBC
{
    public partial class PengelolaanPromo : Form
    {
        public PengelolaanPromo()
        {
            InitializeComponent();
        }

        PromoControl Pro_C = new PromoControl();


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
            
            DG.DataSource = Pro_C.showPromo();


            DataTable DT = Pro_C.showPromo();
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
                    if (counter == 25) counter = 0; //set jumlah baris
                }
            }
            bindingSource1.DataSource = listTbl;
            bindingNavigator1.BindingSource = bindingSource1;
            DG.DataSource = (DT.Rows.Count > 0 ? listTbl[bindingSource1.Position] : DT);
            
            DG.Columns[0].HeaderText = "Kode Promo";
            DG.Columns[1].HeaderText = "Nama Promo";
            DG.Columns[2].HeaderText = "Diskon (dalam %)";
            DG.Columns[3].HeaderText = "Mulai";
            DG.Columns[4].HeaderText = "Berakhir";
            DG.Columns[5].HeaderText = "Status Promo";

            DG.Columns[0].Width = 125;
            DG.Columns[1].Width = 300;
            DG.Columns[2].Width = 120;
            DG.Columns[3].Width = 225;
            DG.Columns[4].Width = 225;
            DG.Columns[5].Width = 130;

            DG.Columns[3].DefaultCellStyle.Format = "dd - MMMM - yyyy";
            DG.Columns[4].DefaultCellStyle.Format = "dd - MMMM - yyyy";
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
            tambahPromo1.setFlag(1);
            tambahPromo1.Visible = true;
            disable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            hideStart();

            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih data yang akan diubah", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView1.Focus();
            }
            else
            {
                tambahPromo1.setFlag(2);
                string kode = getKolom(dataGridView1, 0);
                string nama = getKolom(dataGridView1,1);
                string diskon = getKolom(dataGridView1, 2);
                string start = getKolom(dataGridView1, 3);
                string end = getKolom(dataGridView1, 4);
                string status = getKolom(dataGridView1, 5);
                tambahPromo1.isiTextBox(kode,nama,diskon,start,end,status,txtID.Text);
                tambahPromo1.Visible = true;
                txtID.Clear();
                disable();

            }
        }

        public void disable()
        {
            btnTambah.Enabled = false;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            dataGridView1.Enabled = false;
            btnTampil.Enabled = false;
            txtCari.Enabled = false;
        }

        public void enable()
        {
            btnTampil.Enabled = true;
            btnTambah.Enabled = true;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
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
            
            DG.DataSource = Pro_C.searchPromo(keyword);
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

            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih data yang akan dihapus","iNBC",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                dataGridView1.Focus();
            }

            else
            {
                DialogResult dr = MessageBox.Show("Apakah anda yakin ingin mengapus " + getKolom(dataGridView1,1) + " dari data promo?"
                    ,"Pertanyaan",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    DialogResult drX = MessageBox.Show("Data tersebut tidak akan bisa dikembalikan lagi, apakah anda yakin ingin melanjutkan?"
                       , "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    if(drX == DialogResult.Yes)
                    {
                        Pro_C.deleteProduk(txtID.Text);
                        DialogResult drY = MessageBox.Show("Promo " + getKolom(dataGridView1, 1) + " telah dihapus dari database"
                       , "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                txtID.Clear();
                this.enable();

            }

        }

        private void Pengelolaan_Load(object sender, EventArgs e)
        {
            tambahPromo1.Visible = false;
            setDataGridView(this.dataGridView1);
            button1.Enabled = false;
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
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            this.setDataGridView(dataGridView1);
        }

    }
}
