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
using iNBC.Boundary.JadwalUI;
using iNBC.Boundary.KepalaKlinikUI;

namespace iNBC
{
    public partial class PengelolaanJadwal : Form
    {
        public PengelolaanJadwal()
        {
            InitializeComponent();
        }

        JadwalControl Jdwl_C = new JadwalControl();

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

            DG.DataSource = Jdwl_C.showPromo();


            DataTable DT = Jdwl_C.showPromo();
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


            DG.Columns["NAMAPGW"].DisplayIndex = 0;
            DG.Columns["SHIFT_NAME"].DisplayIndex = 1;
            DG.Columns["HARI"].DisplayIndex = 3;
            DG.Columns["NAMA_ROLE"].DisplayIndex = 2;
            DG.Columns["SHIFT_START"].DisplayIndex = 4;
            DG.Columns["SHIFT_END"].DisplayIndex = 5;

            DG.Columns[0].HeaderText = "Nama Pegawai";
            DG.Columns[1].HeaderText = "Shift";
            DG.Columns[2].HeaderText = "Role";
            DG.Columns[3].HeaderText = "Hari";
            DG.Columns[4].HeaderText = "Jam Mulai";
            DG.Columns[5].HeaderText = "Jam Selesai";

            DG.Columns[0].Width = 400;
            DG.Columns[1].Width = 200;
            DG.Columns[2].Width = 300;
            DG.Columns[3].Width = 100;
            DG.Columns[4].Width = 55;
            DG.Columns[5].Width = 55;
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
            
            DialogResult dX = CustomMessage.Show("Pilih Kategori Pegawai","Dokter","Beautician","Cancel");

            if (dX == DialogResult.Yes)
            {
                hideStart();
                tambahJadwalDokter1.setFlag(1);
                tambahJadwalDokter1.Visible = true;
                disable();
            }

            if (dX == DialogResult.No)
            {
                hideStart();
                tambahJadwalBeautician1.setFlag(1);
                tambahJadwalBeautician1.Visible = true;
                disable();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            hideStart();

            if (txtID.Text == "" || txtID2.Text == "")
            {
                MessageBox.Show("Silahkan pilih data yang akan diubah","iNBC",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                dataGridView1.Focus();
            }
            else
            {
                if (getKolom(dataGridView1, 2) == "Beautician")
                {
                    tambahJadwalBeautician1.setFlag(2);
                    string pegawai = getKolom(dataGridView1, 0);
                    string shift = getKolom(dataGridView1, 1);
                    string hari = getKolom(dataGridView1, 3);

                    //int IDPegawaiToUbah = Jdwl_C.getIdPegawai(txtID.Text);
                    //int IDShiftToUbah = Jdwl_C.getIdPegawai(txtID2.Text);


                    tambahJadwalBeautician1.isiTextBox(pegawai, shift, hari, txtID.Text, txtID2.Text);
                    tambahJadwalBeautician1.Visible = true;
                    txtID.Clear();
                    txtID2.Clear();
                    disable();
                }

                if (getKolom(dataGridView1, 2) == "Dokter")
                {
                    tambahJadwalDokter1.setFlag(2);
                    string pegawai = getKolom(dataGridView1, 0);
                    string shift = getKolom(dataGridView1, 1);
                    string hari = getKolom(dataGridView1, 3);
                    tambahJadwalDokter1.isiTextBox(pegawai, shift, hari, txtID.Text, txtID2.Text);
                    tambahJadwalDokter1.Visible = true;
                    txtID.Clear();
                    txtID2.Clear();
                    disable();
                }
                

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
            
            //DG.DataSource = Pro_C.searchPromo(keyword);
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

        private string getKolom2(DataGridView dg, int i)
        {
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }

        private string getKolomEdit(DataGridView dg, int i)
        {
            return dg[dg.Columns[0].Index, dg.Rows[i].Index].Value.ToString();
        }

        private string getKolomEdit2(DataGridView dg, int i)
        {
            return dg[dg.Columns[1].Index, dg.Rows[i].Index].Value.ToString();
        }

        private string getRow(DataGridView dg)
        {
            return dg.CurrentRow.Index.ToString();
        }

        private string getKolomHari(DataGridView dg, int i)
        {
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text =  getKolom(dataGridView1,0);
            txtRow.Text = getRow(dataGridView1);
            txtID2.Text = getKolom(dataGridView1, 1);
            txtRow2.Text = getKolomHari(dataGridView1, 3);
            //txtRow2.Text = getRow(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
            txtID2.Text = getKolom(dataGridView1, 1);
            txtRow2.Text = getKolomHari(dataGridView1, 3);

            //txtRow2.Text = getRow(dataGridView1);
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
            txtID2.Text = getKolom(dataGridView1, 1);
            txtRow2.Text = getKolomHari(dataGridView1, 3);

            //txtRow2.Text = getRow(dataGridView1);
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
                int localIdPegawaiToDelete;
                int localIdShiftToDelete;

                localIdPegawaiToDelete = Jdwl_C.getIdPegawai(txtID.Text);
                localIdShiftToDelete = Jdwl_C.getIdShift(txtID2.Text,txtRow2.Text);


                DialogResult dr = MessageBox.Show("Apakah anda yakin ingin mengapus " + getKolom(dataGridView1,1) + " dari data jadwal?"
                    ,"Pertanyaan",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    DialogResult drX = MessageBox.Show("Data tersebut tidak akan bisa dikembalikan lagi, apakah anda yakin ingin melanjutkan?"
                       , "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    if(drX == DialogResult.Yes)
                    {
                        Jdwl_C.deleteJadwal(localIdPegawaiToDelete,localIdShiftToDelete);
                        DialogResult drY = MessageBox.Show("Jadwal " + getKolom(dataGridView1, 1) + " telah dihapus dari database"
                       , "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                txtID.Clear();
                txtID2.Clear();
                txtRow.Clear();
                txtRow2.Clear();
                this.enable();

            }

        }

        private void Pengelolaan_Load(object sender, EventArgs e)
        {
            tambahJadwalBeautician1.Visible = false;
            tambahJadwalDokter1.Visible = false;
            setDataGridView(this.dataGridView1);
            button1.Enabled = false;
        }

        private void tambahPromo1_Load(object sender, EventArgs e)
        {

        }

        private void PengelolaanJadwal_Leave(object sender, EventArgs e)
        {
            
        }

        private void PengelolaanJadwal_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            this.Hide();
            KKUI frm = new KKUI();
            frm.ShowDialog();
            this.Close();
             * */
        }

        private void PengelolaanJadwal_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            hideStart();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            //this.searchDataGridView(dataGridView1, this.txtCari.Text);
            //if (txtCari.Text == "")
            //{
                this.setDataGridView(dataGridView1);
            //}
        }

    }
}
