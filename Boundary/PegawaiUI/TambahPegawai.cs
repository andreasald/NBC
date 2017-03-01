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
using System.Text.RegularExpressions;


namespace iNBC
{
    public partial class TambahPegawai : UserControl
    {
        public TambahPegawai()
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

        PegawaiControl PC = new PegawaiControl();
        private void TambahPegawai_Load(object sender, EventArgs e)
        {
            
            cmbRolePgw.DataSource = PC.getNamaRole();
            cmbRolePgw.DisplayMember = "NAMA_ROLE";
            
        }

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

                    if (PC.unikUsername(txtUsername.Text) == txtUsername.Text)
                    {
                        DialogResult dr = MessageBox.Show("Username tersebut sudah ada, silahkan gunakan username yang lain", "iNBC",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int IDRole = PC.getIdRole(cmbRolePgw.Text);
                        iNBC.Entity.Pegawai P = new Entity.Pegawai(txtNama.Text, jenis_kelamin, txtTelp.Text, txtAlamat.Text, txtUsername.Text.ToUpper(), txtPass.Text, IDRole, status, 1);
                        PC.addPegawai(P);
                        clearall();
                        this.Hide();
                        PengelolaanPegawai myParent = (PengelolaanPegawai)this.Parent;
                        myParent.enable();
                        myParent.Show();
                    }
                }
            }
            else 
            {
                string usernameToEdit = txtUsername.Text;

                if (cektxt() == true)
                {
                    errorProvider1.Clear();


                    if (txtUsername.Text == PC.unikUsername(tempUsernametoEdit.Text))
                    {
                        int IDRole = PC.getIdRole(cmbRolePgw.Text);
                        iNBC.Entity.Pegawai P = new Entity.Pegawai(txtNama.Text, jenis_kelamin, txtTelp.Text, txtAlamat.Text, txtUsername.Text, txtPass.Text, IDRole, status, 1);

                        DialogResult dr = MessageBox.Show("Apakah anda yakin ingin mengubah data pegawai " + temp_pegawai, "Peringatan",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {
                            PC.editPegawai(P, int.Parse(txtID.Text));
                        }
                        clearall();
                        this.Hide();
                        PengelolaanPegawai myParent = (PengelolaanPegawai)this.Parent;
                        myParent.Enableedit();
                    }

                    else if (PC.unikUsername(txtUsername.Text) == txtUsername.Text)
                    {
                        DialogResult dr = MessageBox.Show("Username tersebut sudah ada, silahkan gunakan username yang lain", "iNBC",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        int IDRole = PC.getIdRole(cmbRolePgw.Text);
                        iNBC.Entity.Pegawai P = new Entity.Pegawai(txtNama.Text, jenis_kelamin, txtTelp.Text, txtAlamat.Text, txtUsername.Text, txtPass.Text, IDRole, status, 1);

                        DialogResult dr = MessageBox.Show("Apakah anda yakin ingin mengubah data pegawai " + temp_pegawai, "Peringatan",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {
                            PC.editPegawai(P, int.Parse(txtID.Text));
                        }
                        clearall();
                        this.Hide();
                        PengelolaanPegawai myParent = (PengelolaanPegawai)this.Parent;
                        myParent.Enableedit();
                    }
                    
                        
                        

                   
                }
            }
        }

        string jenis_kelamin;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)//JK Laki-laki
        {
            radioButton2.Checked = false;
            jenis_kelamin = radioButton1.Text;


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//JK perempuan
        {
            radioButton1.Checked = false;
            jenis_kelamin = radioButton2.Text;
        }


        string status;

        private void radioButton3_CheckedChanged(object sender, EventArgs e)//Tersedia
        {
            radioButton4.Checked = false;
            status = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)//Tidak Tersedia
        {
            radioButton3.Checked = false;
            status = radioButton4.Text;
        }

        private void cmbRolePgw_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearall();
            errorProvider1.Clear();
            this.Hide();
            PengelolaanPegawai myParent = (PengelolaanPegawai)this.Parent;
            myParent.enable();
        }



        private bool cekJenisKelamin()
        {
            bool temp = false;
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                temp = false;
            }
            else
            {
                temp = true;
            }
            return temp;

        }

        private bool cekStatus()
        {
            bool temp = false;
            if (radioButton3.Checked == false && radioButton4.Checked == false)
            {
                temp = false;
            }
            else
            {
                temp = true;
            }
            return temp;

        }


        private bool cektxt()
        {
            bool temp = true;

            if (txtNama.Text == "")
            {
                errorProvider1.SetError(txtNama, "silahkan isi Nama Pegawai");
                txtNama.Focus();
                temp = false;
            }

            if (txtAlamat.Text == "")
            {
                errorProvider1.SetError(txtAlamat, "silahkan isi Alamat Pegawai");
                txtAlamat.Focus();
                temp = false;
            }

            if (txtPass.Text == "")
            {
                errorProvider1.SetError(txtPass, "silahkan isi Password Pegawai");
                txtPass.Focus();
                temp = false;
            }

            if (txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "silahkan isi Username Pegawai");
                txtUsername.Focus();
                temp = false;
            }

            if (txtTelp.Text == "")
            {
                errorProvider1.SetError(txtTelp, "silahkan isi Nomor Telepon Pegawai");
                txtTelp.Focus();
                temp = false;
            }

            
            if (cekJenisKelamin()==false)
            {
                errorProvider1.SetError(lblJK, "silahkan pilih Jenis kelamin Pegawai");
                temp = false;
            }

            if (cekStatus() == false)
            {
                errorProvider1.SetError(lblStatus, "silahkan pilih Status Ketersedian Pegawai");
                temp = false;
            }

            if (cmbRolePgw.SelectedIndex == -1)
            {
                errorProvider1.SetError(lblStatus, "silahkan pilih Role Pegawai");
                temp = false;
            }

            return temp;

        }

        private void txtTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void clearall()
        {
            txtNama.Clear();
            txtAlamat.Clear();
            txtPass.Clear();
            txtTelp.Clear();
            txtUsername.Clear();
            cmbRolePgw.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearall();
        }


        private string cekSelectedJenisKelamin()
        {
            string jk="";
            if(radioButton1.Checked==true)
            {
                jk="Laki-Laki";
            }

            else if (radioButton2.Checked==true)
            {
                jk="Perempuan";
            }
            return jk;
        }

        private bool cekSelectedStatus()
        {
            bool jk = false;
            if (radioButton3.Checked == true)
            {
                jk = true;
            }

            else if (radioButton4.Checked == true)
            {
                jk = true;
            }
            return jk;
        }

        string temp_pegawai = "";

        public void isiTextBox(string nama, string jk, string alamat, string telp, string username, string pass, string role, string status, string id)
        {
            temp_pegawai = nama;
            txtNama.Text = nama;
            txtAlamat.Text = alamat;
            txtID.Text = id;
            txtPass.Text = pass;
            txtTelp.Text = telp;
            jenis_kelamin = jk;
            txtUsername.Text = username;
            if (jenis_kelamin == "Laki-Laki")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            if (jenis_kelamin == "Perempuan")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            
            cmbRolePgw.Text = role;

            if (status == "Tersedia")
            {
                radioButton3.Checked = true;
                radioButton4.Checked = false;
            }
            if (status == "Tidak Tersedia")
            {
                radioButton3.Checked = false;
                radioButton4.Checked = true;
            }

            tempUsernametoEdit.Text = username;

        }

        private void TambahPegawai_Load_1(object sender, EventArgs e)
        {
            cmbRolePgw.DataSource = PC.getNamaRole();
            cmbRolePgw.DisplayMember = "NAMA_ROLE";
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        
    }
}
