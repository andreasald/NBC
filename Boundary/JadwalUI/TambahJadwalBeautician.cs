using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iNBC.Control;
using iNBC.Entity;
using iNBC.Boundary;
using System.Data.SqlClient;


namespace iNBC
{
    public partial class TambahJadwalBeautician : UserControl
    {
        public TambahJadwalBeautician()
        {
            InitializeComponent();
        }

        int flagperintah = 0;
        public void setFlag(int flag)
        {
            flagperintah = flag;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        JadwalControl JDWL_C = new JadwalControl();

        private void rOLEBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Button Simpan
        {
            if (flagperintah == 1)//tambah data
            {
                if (cektxt() == true)
                {
                    errorProvider1.Clear();

                    int IDPeg = JDWL_C.getIdPegawai(cmbNamaBTC.Text);
                    int IDShift = JDWL_C.getIdShift(cmbShift.Text, cmbHari.Text);

                    iNBC.Entity.PegawaixShift PxS = new Entity.PegawaixShift(IDPeg, IDShift);

                    if (JDWL_C.cekNjumlahJaga(IDPeg) == 6)
                    {
                        DialogResult drErrorSQL = MessageBox.Show("Pegawai tersebut sudah mencapai maksimal batas pengambilan shift", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        try
                        {
                            JDWL_C.addJadwal(PxS);
                            clearall();
                            this.Hide();
                            PengelolaanJadwal myParent = (PengelolaanJadwal)this.Parent;
                            myParent.enable();
                            myParent.Show();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 2627)
                            {
                                DialogResult drErrorSQL = MessageBox.Show("Jadwal Tersebut sudah ada, silahkan inputkan jadwal yang lain", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                        
                }
            }
            else 
            {
               if (cektxt() == true)
                {

                    errorProvider1.Clear();

                    int IDPeg = JDWL_C.getIdPegawai(cmbNamaBTC.Text);
                    int IDShift = JDWL_C.getIdShift(cmbShift.Text, cmbHari.Text);

                    iNBC.Entity.PegawaixShift PxS = new Entity.PegawaixShift(IDPeg, IDShift); 
                    
                    DialogResult dr = MessageBox.Show("Apakah anda yakin ingin mengubah data jadwal beautician " + temp_promo, "iNBC",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            JDWL_C.editJadwal(PxS, int.Parse(txtID.Text),int.Parse(txtID2.Text));

                            DialogResult drX = MessageBox.Show("Data Jadwal berhasil diubah", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 2627)
                            {
                                DialogResult drErrorSQL = MessageBox.Show("Jadwal Tersebut sudah ada, silahkan inputkan jadwal yang lain", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    } 
                    clearall();
                    this.Hide();
                    PengelolaanJadwal myParent = (PengelolaanJadwal)this.Parent;
                    myParent.Enableedit();
                }
            }
        }

        private void cmbRolePgw_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearall();
            errorProvider1.Clear();
            this.Hide();
            PengelolaanJadwal myParent = (PengelolaanJadwal)this.Parent;
            myParent.enable();
        }

        private bool cektxt()
        {
            
            bool temp = true;


            if (cmbHari.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbHari, "silahkan pilih Dokter");
                cmbHari.Focus();
                temp = false;
            }

            if (cmbNamaBTC.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbNamaBTC, "silahkan pilih Hari");
                cmbNamaBTC.Focus();
                temp = false;
            }

            if (cmbShift.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbShift, "silahkan pilih Shift");
                cmbShift.Focus();
                temp = false;
            }

            
            return temp;
          
        }

        private void txtTelp_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void clearall()
        {
            
            cmbNamaBTC.SelectedIndex = -1;
            cmbHari.SelectedIndex = -1;
            cmbShift.SelectedIndex = -1;
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearall();
        }

        string temp_promo = "";

        public void isiTextBox(string Peg, string shift, string hari, string id, string id2)
        {
            int localIdPegawaiToChange;
            int localIdShiftToChange;


            cmbNamaBTC.Text = Peg;
            cmbHari.Text = hari;
            cmbShift.Text = shift;

            localIdPegawaiToChange = JDWL_C.getIdPegawai(id);
            localIdShiftToChange = JDWL_C.getIdShift(id2,hari);

            txtID.Text = localIdPegawaiToChange.ToString();
            txtID2.Text = localIdShiftToChange.ToString();
        }

        private void TambahProduk_Load(object sender, EventArgs e)
        {
            cmbNamaBTC.DataSource = JDWL_C.getNamaBeautician();
            cmbNamaBTC.DisplayMember = "NAMAPGW";

            cmbHari.Items.Add("Selasa");
            cmbHari.Items.Add("Rabu");
            cmbHari.Items.Add("Kamis");
            cmbHari.Items.Add("Jumat");
            cmbHari.Items.Add("Sabtu");
            cmbHari.Items.Add("Minggu");

            cmbShift.Items.Add("Shift 1");
            cmbShift.Items.Add("Shift 2");

        }

        private void txtDiskon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        
    }
}