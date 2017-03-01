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
using iNBC.Entity;
using System.Globalization;

namespace iNBC.Boundary.PendaftaranTransaksiUI
{
    public partial class PendaftaranTransaksi : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["LoginForm"];

        int todayTransaction = 1;

        TransactionControl TSC_C = new TransactionControl();
        CustomerControl CUS_C = new CustomerControl();
        JadwalControl JDWL_C = new JadwalControl();

        DateTime todayDate = System.DateTime.Now;

        DateTime currentTime = DateTime.Parse(System.DateTime.Now.ToString("HH:mm"));
        
        string todayIs = System.DateTime.Now.ToString("dddd");
        string hariIni;
        string currentShift;
        int IDofCurrentShift;




        public void translateHari()
        {
            if (todayIs.Equals("tuesday", StringComparison.InvariantCultureIgnoreCase))
            {
                hariIni = "Selasa";
            }

            else if (todayIs.Equals("wednesday", StringComparison.InvariantCultureIgnoreCase))
            {
                hariIni = "Rabu";
            }

            else if (todayIs.Equals("thursday", StringComparison.InvariantCultureIgnoreCase))
            {
                hariIni = "Kamis";
            }

            else if (todayIs.Equals("friday", StringComparison.InvariantCultureIgnoreCase))
            {
                hariIni = "Jumat";
            }

            else if (todayIs.Equals("saturday", StringComparison.InvariantCultureIgnoreCase))
            {
                hariIni = "Sabtu";
            }

            else if (todayIs.Equals("sunday", StringComparison.InvariantCultureIgnoreCase))
            {
                hariIni = "Minggu";
            }

            else
            {
                hariIni = todayIs;
            }
        }

        public void ShiftByNow()
        {
            string startS = "09:00";
            string limitShift1s = "14:59";
            string middleS = "15:00";
            string limitShift2s = "21:00";

            DateTime start = DateTime.Parse(startS);
            DateTime LimitShift1 = DateTime.Parse(limitShift1s);
            DateTime middle = DateTime.Parse(middleS);
            DateTime LimitShift2 = DateTime.Parse(limitShift2s);

            if (currentTime >= start && currentTime<LimitShift1)
            {
                currentShift = "Shift 1";
            }

            else if (currentTime >= middle && currentTime <= LimitShift2)
            {
                currentShift = "Shift 2";
            }

            else
            {
                currentShift = "No such shift";
            }
        }

        public PendaftaranTransaksi()
        {
            InitializeComponent();
            translateHari();
            ShiftByNow();
        }

        private void PendaftaranTransaksi_Load(object sender, EventArgs e)
        {
            txtIDcs.Text = ((LoginForm)f).txtID.Text;
            cmbDokter.DataSource = TSC_C.getDokterAvailable(currentShift, hariIni);
            cmbDokter.DisplayMember = "NAMAPGW";
            disabled();
            cekTanggal();
        }

        private void cekTanggal()
        {
            DateTime today = System.DateTime.Now;

            string StodayDate = today.ToString("dd/MM/yy");
            string SlastDate = TSC_C.ambilLastDate().ToString("dd/MM/yy");

            DateTime todayDate = DateTime.ParseExact(StodayDate, "dd/MM/yy", CultureInfo.InvariantCulture);
            DateTime lastDate = DateTime.ParseExact(SlastDate, "dd/MM/yy", CultureInfo.InvariantCulture);

            if (lastDate == todayDate)
            {
                string theLast = TSC_C.ambilLastIDTransaksi();
                string idLast = theLast.Substring(7);
                todayTransaction = int.Parse(idLast)+1;
            }

            else if(today > lastDate)
            {
                todayTransaction = 1;
            }

        }

        private void button5_Click(object sender, EventArgs e) // verifikasi button ya
        {

            if (TSC_C.statusTransaksiCustomer(txtIDCustomer.Text) == "InProgress" || TSC_C.statusTransaksiCustomer(txtIDCustomer.Text) == "Receivable")
            {
                DialogResult dr = MessageBox.Show("Customer tersebut memiliki transaksi yang sedang berlangsung / belum lunas.", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                if (currentShift == "No such shift")
                {
                    DialogResult dr = MessageBox.Show("Pendaftaran hanya bisa dilakukan pada jam aktif klinik", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else
                {
                    if (CUS_C.tryVerify(txtIDCustomer.Text) == 1)
                    {
                        errorProvider1.Clear();
                        button5.Visible = false;
                        enabled();
                        rightProvider.Visible = true;
                    }
                    else
                    {
                        errorProvider1.SetError(button5, "ID Customer tidak valid");
                    }
                }
            }
        }

        private void txtIDCustomer_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void clearAll()
        {
            txtIDCustomer.Text = "";
            cmbDokter.SelectedIndex = -1;
            txtKeluhan.Text = "";
        }

        private void disabled()
        {
            cmbDokter.Enabled = false;
            txtKeluhan.Enabled = false;
            btnReset.Enabled = false;
            btnSimpan.Enabled = false;
        }

        private void enabled()
        {
            cmbDokter.Enabled = true;
            txtKeluhan.Enabled = true;
            btnReset.Enabled = true;
            btnSimpan.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            rightProvider.Visible = false;
            clearAll();
            disabled();
        }

        private void btnSimpan_Click(object sender, EventArgs e) //simapan transaksi
        {
            if (cek() == true)
            {
                IDofCurrentShift = JDWL_C.getIdShift(currentShift, hariIni);

                string idTransaksi = createIDtransaksi();

                iNBC.Entity.Transaksi T = new Entity.Transaksi(idTransaksi, txtIDCustomer.Text, 0, "-", IDofCurrentShift, System.DateTime.Now, "", 0, "InProgress", 2);
                todayTransaction++;
                TSC_C.addTransaksi(T);

                int idPegawai = TSC_C.getIDPegawai(cmbDokter.Text);

                iNBC.Entity.PegawaiXTransaksi PxTValueDKTR = new Entity.PegawaiXTransaksi(idTransaksi, idPegawai);
                iNBC.Entity.PegawaiXTransaksi PxTValueCS = new Entity.PegawaiXTransaksi(idTransaksi, int.Parse(txtIDcs.Text));
                TSC_C.addTransaksiXPegawai(PxTValueDKTR);
                TSC_C.addTransaksiXPegawai(PxTValueCS);
                //TSC_C.updateStatusPegawaiSelectedBy(TSC_C.getIDPegawai(cmbDokter.Text));

                clearAll();

                DialogResult dr = MessageBox.Show("Pendaftaran sukses", "iNBC",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private bool cek()
        {
            bool temp = true;

            if (txtIDCustomer.Text == "")
            {
                errorProvider1.SetError(txtIDCustomer, "Silahkan masukan ID Customer");
                temp =  false;
            }

            if (cmbDokter.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbDokter, "Silahkan pilih dokter");
                temp =  false;
            }


            //string currentDate = System.DateTime.Now.ToString("dd/MM/yyyy");
            //DateTime realCurrentdate = DateTime.ParseExact(currentDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            //if (TSC_C.statusTransaksiCustomer(txtIDCustomer.Text) == "InProgress")
            //{
            //    DialogResult dr = MessageBox.Show("Customer tersebut memiliki transaksi yang sedang berlangsung / belum lunas.", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    temp = false;
            //}
 
            return temp;
        }

        public string createIDtransaksi()
        {
            string temp = "";

            string days = System.DateTime.Now.ToString("dd");
            string month = System.DateTime.Now.ToString("MM");
            string year = System.DateTime.Now.ToString("yy");

            temp = days + month + year + "-" + todayTransaction.ToString();

            

            return temp;

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void txtIDCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}