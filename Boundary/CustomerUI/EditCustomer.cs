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
using System.Text.RegularExpressions;


namespace iNBC
{
    public partial class EditCustomer : UserControl
    {

        CustomerControl CUS_C = new CustomerControl();

        public const string MatchEmailPattern =
            @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

        public EditCustomer()
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

        PromoControl PRO_C = new PromoControl();

        private void rOLEBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {

        }

        public static bool IsEmail(string email)
        {
            if (email != null) return Regex.IsMatch(email, MatchEmailPattern);
            else return false;
        }

        private void button2_Click(object sender, EventArgs e) // Button Simpan
        {
            if (flagperintah == 1)//tambah data
            {
                //txtKodePro.ReadOnly = false;
                if (cektxt() == true)
                {
                    //errorProvider1.Clear();

                    //iNBC.Entity.Promo Pro = new Entity.Promo(txtKodePro.Text,txtNama.Text,float.Parse(txtDiskon.Text),DateTime.Parse(dateStart.Text),DateTime.Parse(dateEnd.Text),cmbStatusPro.Text,1);

                    
                        try
                        {
                            //PRO_C.addPromo(Pro);
                            clearall();
                            this.Hide();
                            PengelolaanPromo myParent = (PengelolaanPromo)this.Parent;
                            myParent.enable();
                            myParent.Show();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 2627)
                            {
                                DialogResult drErrorSQL = MessageBox.Show("Kode Promo Tersebut sudah pernah digunakan, silahkan inputkan kode promo yang lain", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                }
            }
            else 
            {
                //txtKodePro.ReadOnly = true;
                if (cektxt() == true)
                {
                    if (System.DateTime.Now.Year - DateTime.Parse(dateBirth.Text).Year < 13)
                    {
                        DialogResult dr = MessageBox.Show("Umur customer minimal adalah 13 tahun, silahkan periksa kembali data yang dimasukan", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        errorProvider1.Clear();

                        iNBC.Entity.Customer Cus = new Entity.Customer(txtID.Text, txtNama.Text, DateTime.Parse(dateBirth.Text), cmbJK.Text, txtAlamat.Text, txtTelpon.Text, txtEmail.Text, txtAlergi.Text, System.DateTime.Now, 0, txtPass.Text, 1);

                        DialogResult dr = MessageBox.Show("Apakah anda yakin ingin mengubah data customer " + temp_customer, "iNBC",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {
                            CUS_C.editCustomer(Cus, txtID.Text);

                            DialogResult drX = MessageBox.Show("Data Customer berhasil diubah", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        clearall();
                        this.Hide();
                        PengelolaanCustomer myParent = (PengelolaanCustomer)this.Parent;
                        myParent.Enableedit();
                    }
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
            PengelolaanCustomer myParent = (PengelolaanCustomer)this.Parent;
            myParent.enable();
        }

        private bool cektxt()
        {
            bool temp = true;

            if (txtNama.Text == "")
            {
                errorProvider1.SetError(txtNama, "silahkan isi Nama Customer");
                txtNama.Focus();
                temp = false;
            }


            if (txtPass.Text == "")
            {
                errorProvider1.SetError(txtPass, "silahkan isi Password Customer");
                txtPass.Focus();
                temp = false;
            }

            if (cmbJK.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbJK, "silahkan pilih Jenis Kelamin Customer");
                cmbJK.Focus();
                temp = false;
            }

            if (dateBirth.Text == "")
            {
                errorProvider1.SetError(dateBirth, "silahkan isi Tanggal lahir Customer");
                dateBirth.Focus();
                temp = false;
            }

            if (txtTelpon.Text == "")
            {
                errorProvider1.SetError(txtTelpon, "silahkan isi nomor telepon Customer");
                txtTelpon.Focus();
                temp = false;
            }

            if (txtAlamat.Text == "")
            {
                errorProvider1.SetError(txtAlamat, "silahkan isi alamat Customer");
                txtAlamat.Focus();
                temp = false;
            }

            if (txtEmail.Text == "")
            {
                errorProvider1.SetError(txtEmail, "silahkan isi email Customer");
                txtEmail.Focus();
                temp = false;
            }

            if (IsEmail(txtEmail.Text)==false)
            {
                errorProvider1.SetError(txtEmail, "format email salah");
                txtEmail.Focus();
                temp = false;
            }

            return temp;
          
        }

        private void txtTelp_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void clearall()
        {
            //txtKodePro.Clear();
            //txtNama.Clear();
            //txtDiskon.Clear();
            //dateEnd.ResetText();
            //dateStart.ResetText();
            //cmbStatusPro.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearall();
        }

        string temp_customer = "";

        public void isiTextBox(string nama, string tglLahir, string JK, string alamat, string telp,string email,string alergi, string password, string id)
        {
            temp_customer = nama;
            txtNama.Text = nama;
            dateBirth.Text = tglLahir;
            cmbJK.Text = JK;
            txtAlamat.Text = alamat;
            txtTelpon.Text = telp;
            txtEmail.Text = email;
            txtAlergi.Text = alergi;
            txtPass.Text = password;
            txtID.Text = id;
        }

        private void TambahProduk_Load(object sender, EventArgs e)
        {
            cmbJK.Items.Add("Laki-laki");
            cmbJK.Items.Add("Perempuan");
        }

        private void txtDiskon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTelpon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        
    }
}