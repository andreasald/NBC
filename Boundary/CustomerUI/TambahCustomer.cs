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
using System.Globalization;
using System.Text.RegularExpressions;


namespace iNBC
{
    public partial class TambahCustomer : UserControl
    {
        int todayCustomer;
        public const string MatchEmailPattern =
            @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

        public TambahCustomer()
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

        CustomerControl CUS_C = new CustomerControl();

        private void rOLEBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {

        }


        public string createcustomerid()
        {

            string temp = "";
            
            string bulandaftar = DateTime.Now.ToString("MM");
            string tahundaftar = DateTime.Now.ToString("yy");

            string tanggallahir = dateBirth.Value.ToString("dd");
            string bulanlahir = dateBirth.Value.ToString("MM");

            string tahunlahir = dateBirth.Value.ToString("yyyy");

            string todayCustomerS = todayCustomer.ToString();


            temp = bulandaftar + tahundaftar + tanggallahir + bulanlahir + tahunlahir + todayCustomerS;
            return temp;
        }

        public string createcustomerpassword()
        {
            string password;

            string tanggallahir = dateBirth.Value.ToString("dd");
            string bulanlahir = dateBirth.Value.ToString("MM");
            string tahunlahir = dateBirth.Value.ToString("yyyy");

            password = tanggallahir + bulanlahir + tahunlahir;

            return password;
        }


        public static bool IsEmail(string email)
        {
            if (email != null) return Regex.IsMatch(email, MatchEmailPattern);
            else return false;
        }

        private void button2_Click(object sender, EventArgs e) // Button Simpan
        {
            cekTanggal();
            if (flagperintah == 1)//tambah data
            {
                //txtKodePro.ReadOnly = false;
                if (cektxt() == true)
                {
                    if (System.DateTime.Now.Year - DateTime.Parse(dateBirth.Text).Year < 13)
                    {
                        DialogResult dr = MessageBox.Show("Umur customer minimal adalah 13 tahun, silahkan periksa kembali data yang dimasukan", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                         errorProvider1.Clear();

                    iNBC.Entity.Customer Cus = new Entity.Customer(createcustomerid(), txtNama.Text, DateTime.Parse(dateBirth.Text), cmbJK.Text, txtAlamat.Text, txtTelepon.Text, txtEmail.Text, txtAlergi.Text, System.DateTime.Now,0,createcustomerpassword(),1);
                    
                        try
                        {
                            CUS_C.addCustomer(Cus);
                            clearall();
                            todayCustomer++;
                            this.Hide();
                            PengelolaanCustomer myParent = (PengelolaanCustomer)this.Parent;
                            myParent.enable();
                            myParent.Show();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 2627)
                            {
                                DialogResult drErrorSQL = MessageBox.Show("Error pada customer ID", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
            }
            else 
            {
                //txtKodePro.ReadOnly = true;
                if (cektxt() == true)
                {

                  //  errorProvider1.Clear();

                    //iNBC.Entity.Promo Pro = new Entity.Promo(txtKodePro.Text, txtNama.Text, float.Parse(txtDiskon.Text), DateTime.Parse(dateStart.Text), DateTime.Parse(dateEnd.Text), cmbStatusPro.Text, 1);
                    
                    DialogResult dr = MessageBox.Show("Apakah anda yakin ingin mengubah data produk " + temp_promo, "iNBC",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        //PRO_C.editPromo(Pro, txtID.Text);

                        DialogResult drX = MessageBox.Show("Data Produk berhasil diubah", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                    clearall();
                    this.Hide();
                    PengelolaanCustomer myParent = (PengelolaanCustomer)this.Parent;
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

            if (cmbJK.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbJK, "silahkan pilih Jenis Kelamin Customer");
                cmbJK.Focus();
                temp = false;
            }

            if (dateBirth.Text == "")
            {
                errorProvider1.SetError(dateBirth, "silahkan isi Tanggal lahir customer");
                dateBirth.Focus();
                temp = false;
            }

            if (txtTelepon.Text == "")
            {
                errorProvider1.SetError(txtTelepon, "silahkan isi nomor telepon Customer");
                txtTelepon.Focus();
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

            if (IsEmail(txtEmail.Text) == false)
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
            txtNama.Text = "";
            txtTelepon.Text = "";
            txtID.Text = "";
            txtEmail.Text = "";
            txtAlergi.Text = "";
            txtAlamat.Text = "";
            cmbJK.SelectedIndex = -1;
            dateBirth.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearall();
        }

        string temp_promo = "";

        public void isiTextBox(string kode, string nama, string diskon, string startX, string endX, string status,string id)
        {
            //txtKodePro.Text = kode;
            temp_promo = nama;
            //txtNama.Text = nama;
            //txtDiskon.Text = diskon;
            //dateStart.Text = startX;
            //dateEnd.Text = endX;
            txtID.Text = id;
            //cmbStatusPro.Text = status;
        }


        private void cekTanggal()
        {
            DateTime today = DateTime.Now;

            string dateToday = today.ToString("MM/yyyy", CultureInfo.InvariantCulture);
            string dateX = CUS_C.lastDate().ToString("MM/yyyy", CultureInfo.InvariantCulture);

            DateTime dateTodayX = DateTime.ParseExact(dateToday, "MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dateLastX = DateTime.ParseExact(dateX, "MM/yyyy", CultureInfo.InvariantCulture);


            if (dateLastX == dateTodayX)
            {
                string ID_Omega = CUS_C.AmbilLastID();
                string sub = ID_Omega.Substring(12);

                todayCustomer = int.Parse(sub) + 1;
            }

            else if(dateTodayX>dateLastX)
            {
                todayCustomer = 1;
            }
        }

        private void TambahProduk_Load(object sender, EventArgs e)
        {
            cmbJK.Items.Add("Laki-laki");
            cmbJK.Items.Add("Perempuan");
            cekTanggal();
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

        private void txtTelepon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        
    }
}