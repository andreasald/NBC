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
    public partial class TambahPromo : UserControl
    {
        public TambahPromo()
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

        string tanggalSelesaiPromo;

        PromoControl PRO_C = new PromoControl();

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
                txtKodePro.ReadOnly = false;
                if (cektxt() == true)
                {
                    errorProvider1.Clear();

                    iNBC.Entity.Promo Pro = new Entity.Promo(txtKodePro.Text, txtNama.Text, float.Parse(txtDiskon.Text), DateTime.Parse(dateStart.Text), DateTime.Parse(tanggalSelesaiPromo), cmbStatusPro.Text, 1);
                    DialogResult dr = MessageBox.Show(tanggalSelesaiPromo,"",MessageBoxButtons.OK);

                    
                        try
                        {
                            PRO_C.addPromo(Pro);
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
                txtKodePro.ReadOnly = true;
                if (cektxt() == true)
                {

                    errorProvider1.Clear();

                    iNBC.Entity.Promo Pro = new Entity.Promo(txtKodePro.Text, txtNama.Text, float.Parse(txtDiskon.Text), DateTime.Parse(dateStart.Text), DateTime.Parse(dateEnd.Text), cmbStatusPro.Text, 1);
                    
                    DialogResult dr = MessageBox.Show("Apakah anda yakin ingin mengubah data produk " + temp_promo, "iNBC",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        PRO_C.editPromo(Pro, txtID.Text);

                        DialogResult drX = MessageBox.Show("Data Produk berhasil diubah", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                    clearall();
                    this.Hide();
                    PengelolaanPromo myParent = (PengelolaanPromo)this.Parent;
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
            PengelolaanPromo myParent = (PengelolaanPromo)this.Parent;
            myParent.enable();
        }

        private bool cektxt()
        {
            bool temp = true;

            if (txtKodePro.Text == "")
            {
                errorProvider1.SetError(txtKodePro, "silahkan isi Kode Promo");
                txtKodePro.Focus();
                temp = false;
            }

            if (txtNama.Text == "")
            {
                errorProvider1.SetError(txtNama, "silahkan isi Nama Promo");
                txtNama.Focus();
                temp = false;
            }

            if (txtDiskon.Text == "")
            {
                errorProvider1.SetError(txtDiskon, "silahkan isi diskon Promo");
                txtDiskon.Focus();
                temp = false;
            }

            if (cmbStatusPro.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbStatusPro, "silahkan pilih Status Promo");
                cmbStatusPro.Focus();
                temp = false;
            }

            if (dateStart.Text == "")
            {
                errorProvider1.SetError(dateStart, "silahkan isi Tanggal Promosi Mulai Berlaku");
                dateStart.Focus();
                temp = false;
            }

            if (dateEnd.Text == "")
            {
                errorProvider1.SetError(dateEnd, "silahkan isi Tanggal Promosi Berhenti Berlaku");
                dateEnd.Focus();
                temp = false;
            }

            if (DateTime.Parse(dateStart.Text) > DateTime.Parse(dateEnd.Text))
            {
                DialogResult drErrorDate = MessageBox.Show("Tanggal Berakhir promo tidak bisa lebih awal dari Tanggal Mulai promo. Mohon Periksa kembali inputan Anda", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(dateEnd, "Tanggal Berakhir harus lebih besar dari Tanggal Mulai");
                errorProvider1.SetError(dateStart, "Tanggal Mulai harus lebih awal dari Tanggal Berakhir");
                dateStart.Focus();
                dateEnd.Focus();
                temp = false;
            }

            if (DateTime.Parse(dateStart.Text) < System.DateTime.Now)
            {
                if (DateTime.Parse(dateEnd.Text) < System.DateTime.Now)
                {
                    DialogResult drErrorDate = MessageBox.Show("Tanggal Mulai dan Berakhir promo tidak bisa lebih kecil dari hari ini. Mohon Periksa kembali inputan Anda", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorProvider1.SetError(dateEnd, "Tanggal Berakhir harus lebih besar dari Tanggal Mulai");
                    errorProvider1.SetError(dateStart, "Tanggal Mulai harus lebih awal dari Tanggal Berakhir");
                    dateStart.Focus();
                    dateEnd.Focus();
                    temp = false;
                }
            }

            if (txtDiskon.Text != "")
            {
                if (int.Parse(txtDiskon.Text) > 100)
                {
                    DialogResult drErrorDate = MessageBox.Show("Besar diskon maksimal adalah 100%", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorProvider1.SetError(dateEnd, "Besar diskon maksimal adalah 100%");
                    txtDiskon.Focus();
                    temp = false;
                }
            }

            if (DateTime.Parse(dateStart.Text) == DateTime.Parse(dateEnd.Text))
            {
                DateTime tanggalSelesai = DateTime.Parse(dateEnd.Text);
                tanggalSelesai = tanggalSelesai.AddHours(23);
                tanggalSelesai = tanggalSelesai.AddMinutes(59);
                tanggalSelesaiPromo = tanggalSelesai.ToString();
                temp =  true;

            }
            

            return temp;
          
        }

        private void txtTelp_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void clearall()
        {
            txtKodePro.Clear();
            txtNama.Clear();
            txtDiskon.Clear();
            dateEnd.ResetText();
            dateStart.ResetText();
            cmbStatusPro.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearall();
        }

        string temp_promo = "";

        public void isiTextBox(string kode, string nama, string diskon, string startX, string endX, string status,string id)
        {
            txtKodePro.Text = kode;
            temp_promo = nama;
            txtNama.Text = nama;
            txtDiskon.Text = diskon;
            dateStart.Text = startX;
            dateEnd.Text = endX;
            txtID.Text = id;
            cmbStatusPro.Text = status;
        }

        private void TambahProduk_Load(object sender, EventArgs e)
        {
            cmbStatusPro.Items.Add("Active");
            cmbStatusPro.Items.Add("Expired");
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