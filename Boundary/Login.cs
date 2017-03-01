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
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace iNBC.Boundary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        LoginControl LC = new LoginControl();

        private void btnLogin_Click(object sender, EventArgs e)
        {

            txtID.Text = LC.getIDPegawaiYangLogin(txtUsername.Text).ToString();

            if (txtID.Text=="" || txtPass.Text=="")
            {
                MessageBox.Show("Silahkan lengkapi form yang tersedia", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                if (LC.cekLogin(txtUsername.Text, txtPass.Text) == true)
                {
                    int role = LC.GetRoleUser(txtUsername.Text, txtPass.Text);
                    if (role == 1)
                    {
                        this.Hide();
                        KKUI KKUI = new KKUI();
                        KKUI.ShowDialog();
                        this.Close();
                    }

                    if (role == 2)
                    {
                        this.Hide();
                        PengelolaanPegawai kelola = new PengelolaanPegawai();
                        kelola.setToolStripUser("Pengguna: Admin - " + txtUsername.Text);
                        kelola.ShowDialog();
                        this.Close();
                    }

                    if (role == 3)
                    {
                        this.Hide();
                        CSUI wlc = new CSUI();
                        //wlc.setToolStripUser("Pengguna: Customer Service - " + txtUsername.Text);
                        wlc.ShowDialog();
                        this.Close();
                    }

                    if (role == 4)
                    {
                        this.Hide();
                        Pemeriksaan wlc = new Pemeriksaan();
                        wlc.setToolStripUser("Pengguna: Dokter - " + txtUsername.Text);
                        wlc.ShowDialog();
                        this.Close();
                    }

                    if (role == 5)
                    {
                        this.Hide();
                        Pembayaran wlc = new Pembayaran();
                        wlc.setToolStripUser("Pengguna: Kasir - " + txtUsername.Text);
                        wlc.ShowDialog();
                        this.Close();
                    }

                    if (role == 6)
                    {
                        this.Hide();
                        BTCUI wlc = new BTCUI();
                       // wlc.setToolStripUser("Pengguna: Beautician - " + txtUsername.Text);
                        wlc.ShowDialog();
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Role tersebut tidak tersedia");
                    }
                }

                else
                {
                    MessageBox.Show("Maaf, username / password salah", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s]");

            if (e.KeyChar == 39)
            {
                e.Handled = true;
            }

            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 39)
            {
                e.Handled = true;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
