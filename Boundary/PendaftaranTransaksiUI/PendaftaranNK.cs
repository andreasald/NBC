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

namespace iNBC.Boundary.PendaftaranTransaksiUI
{
    public partial class PendaftaranNK : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["LoginForm"];

        public PendaftaranNK()
        {
            InitializeComponent();
            translateHari();
            ShiftByNow();
        }

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
        string jkCustomer;




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

        public void setDataGridView(DataGridView DG)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 12);

            DG.DataSource = TSC_C.tampilDetilPWT(idTransaksi.Text);

            DG.Columns[0].HeaderText = "Nama Perawatan";
            DG.Columns[1].HeaderText = "Kuantitas";

            //DG.Columns["NAMA_PERAWATAN"].DisplayIndex = 0;
            //DG.Columns["QTYPWT"].DisplayIndex = 1;

            /*DG.Columns[0].HeaderText = "ID";
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
            */

            //DG.Columns[2].Width = 60;
            //DG.Columns[5].Width = 203;


            //DG.Columns[0].Visible = true;
            //DG.Columns[1].Visible = true;
            //DG.Columns[3].Visible = true;
            //DG.Columns[4].Visible = true;
        }

        private void PendaftaranTransaksi_Load(object sender, EventArgs e)
        {
            txtIDcs.Text = ((LoginForm)f).txtID.Text;
            perawatan1.Visible = false;
            //cmbBeautician.DataSource = TSC_C.getBeauticianAvailable(currentShift, hariIni);
            //cmbBeautician.DisplayMember = "NAMAPGW";
            cmbRuang.DataSource = TSC_C.getRoomsAvailable();
            cmbRuang.DisplayMember = "NO_RUANG";
            disabled();
            cekTanggal();
            idTransaksi.Text = createIDtransaksi();
            setDataGridView(this.dataGridView1);
            
        }

        private void cekTanggal()
        {
            DateTime today = System.DateTime.Now;

            string StodayDate = today.ToString("dd/MM/yy");
            string SlastDate = TSC_C.ambilLastDate().ToString("dd/MM/yy");

            DateTime todayDate = DateTime.Parse(StodayDate);
            DateTime lastDate = DateTime.Parse(SlastDate);

            if (lastDate == todayDate)
            {
                string theLast = TSC_C.ambilLastIDTransaksi();
                string idLast = theLast.Substring(7);
                todayTransaction = int.Parse(idLast)+1;
            }

            else if(lastDate < todayDate)
            {
                todayTransaction = 1;
            }

        }

        private void button5_Click(object sender, EventArgs e) // verifikasi button ya
        {

            if (TSC_C.statusTransaksiCustomer(txtIDCustomer.Text) == "Receivable" || TSC_C.statusTransaksiCustomer(txtIDCustomer.Text) == "InProgress")
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
                        txtIDCustomer.Enabled = false;
                        errorProvider1.Clear();
                        button5.Visible = false;
                        enabled();
                        rightProvider.Visible = true;

                        jkCustomer = TSC_C.getJenisKelaminCustomerByIDCus(txtIDCustomer.Text);

                        if (jkCustomer == "Perempuan")
                        {
                            cmbBeautician.DataSource = TSC_C.getBeauticianCewekAvailable(currentShift, hariIni);
                            cmbBeautician.DisplayMember = "NAMAPGW";
                        }

                        else if (jkCustomer == "Laki-laki")
                        {
                            cmbBeautician.DataSource = TSC_C.getBeauticianCowokAvailable(currentShift, hariIni);
                            cmbBeautician.DisplayMember = "NAMAPGW";
                        }

                        rightProvider.Visible = true;

                        iNBC.Entity.Transaksi T = new Entity.Transaksi(idTransaksi.Text, txtIDCustomer.Text, 0, "-", 23, System.DateTime.Now, txtKeluhan.Text, 0, "InProgress", 1);
                        TSC_C.addTransaksi(T);
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
            cmbBeautician.SelectedIndex = -1;
            txtKeluhan.Text = "";
        }

        public void disabled()
        {
            cmbBeautician.Enabled = false;
            txtKeluhan.Enabled = false;
            //btnReset.Enabled = false;
            btnSimpan.Enabled = false;
            cmbRuang.Enabled = false;
            dataGridView1.Enabled = false;
            btnPilih.Enabled = false;
        }

        public void enabled()
        {
            cmbBeautician.Enabled = true;
            txtKeluhan.Enabled = true;
            //btnReset.Enabled = true;
            btnSimpan.Enabled = true;
            cmbRuang.Enabled = true;
            dataGridView1.Enabled = true;
            btnPilih.Enabled = true;

            setDataGridView(this.dataGridView1);
            //dataGridView1.Rows[0].Selected = true;
        }

        public void disabledAfterPilih()
        {
            txtIDCustomer.Enabled = false;
            cmbBeautician.Enabled = false;
            txtKeluhan.Enabled = false;
            //btnReset.Enabled = false;
            btnSimpan.Enabled = false;
            cmbRuang.Enabled = false;
            dataGridView1.Enabled = false;
            btnPilih.Enabled = false;
        }

        public void enabledAfterPilih()
        {
            txtIDCustomer.Enabled = false;
            cmbBeautician.Enabled = true;
            txtKeluhan.Enabled = true;
            //btnReset.Enabled = true;
            btnSimpan.Enabled = true;
            cmbRuang.Enabled = true;
            dataGridView1.Enabled = true;
            btnPilih.Enabled = true;


            setDataGridView(this.dataGridView1);
            dataGridView1.Rows[0].Selected = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            rightProvider.Visible = false;
            clearAll();
            disabled();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cek() == true)
            {
                IDofCurrentShift = JDWL_C.getIdShift(currentShift, hariIni);

                iNBC.Entity.Transaksi T = new Entity.Transaksi(idTransaksi.Text, txtIDCustomer.Text, int.Parse(cmbRuang.Text), "-", IDofCurrentShift, System.DateTime.Now, txtKeluhan.Text, 0 , "Receivable", 2);
                TSC_C.updateDataTransaksi(T,idTransaksi.Text);
                

                int idPegawai = TSC_C.getIDPegawai(cmbBeautician.Text);
                
                iNBC.Entity.PegawaiXTransaksi PxTValue = new Entity.PegawaiXTransaksi(idTransaksi.Text, idPegawai);
                iNBC.Entity.PegawaiXTransaksi PxTValueCS = new Entity.PegawaiXTransaksi(idTransaksi.Text, int.Parse(txtIDcs.Text));
                TSC_C.addTransaksiXPegawai(PxTValue);
                TSC_C.addTransaksiXPegawai(PxTValueCS);

                //BIG REVOLUTION
                TSC_C.updateStatusPegawaiSelectedBy(TSC_C.getIDPegawai(cmbBeautician.Text));
                TSC_C.updateStatusRuanganSelectedBy(int.Parse(cmbRuang.Text));
                //BIG REVOLUTION

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

            if (cmbBeautician.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbBeautician, "Silahkan pilih dokter");
                temp =  false;
            }

            if (cmbRuang.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbRuang, "Silahkan pilih ruang");
                temp = false;
            }

            if (dataGridView1.RowCount == 0)
            {
                errorProvider1.SetError(dataGridView1, "Minimal harus ada 1 Perawataan");
                temp = false;
            }

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

        private void btnPilih_Click(object sender, EventArgs e)
        {
            disabledAfterPilih();
            perawatan1.isiTextBox(idTransaksi.Text);
            perawatan1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(TSC_C.ambilLastIDTransaksi() != null)
            {
                DialogResult dr = MessageBox.Show("Apakah anda yakin ingin membatalkan transaksi tersebut? Data perawatan yang sudah diambil juga akan dihapus.", "iNBC", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

                if (dr == DialogResult.Yes)
                {
                    if (TSC_C.getDetilTransakaiPerawatan(idTransaksi.Text) != null)
                    {
                        
                            TSC_C.deleteDetilPWTCanceledTransaction(idTransaksi.Text);
                            TSC_C.deleteCanceledTransaction(idTransaksi.Text);
                    }

                    else if (TSC_C.getDetilTransakaiPerawatan(idTransaksi.Text) == null)
                    {
                        TSC_C.deleteCanceledTransaction(idTransaksi.Text);
                    }

                    this.Hide();
                    this.Close();
                }

            }
            
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

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            txtIDdtlPwt.Text = getKolom(dataGridView1, 0);
            txtRowdtlPWT.Text = getRow(dataGridView1);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtIDdtlPwt.Text == "")
            {
                MessageBox.Show("Silahkan pilih data yang akan dihapus", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView1.Focus();
            }

            else 
            {
                string idPWTtoDelete = TSC_C.getIDPerawatan(txtIDdtlPwt.Text);
                TSC_C.deletePerawatanIni(idTransaksi.Text, idPWTtoDelete);
                setDataGridView(this.dataGridView1);
                dataGridView1.Rows[0].Selected = true;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIDdtlPwt.Text = getKolom(dataGridView1, 0);
            txtRowdtlPWT.Text = getRow(dataGridView1);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIDdtlPwt.Text = getKolom(dataGridView1, 0);
            txtRowdtlPWT.Text = getRow(dataGridView1);
        }

        private void dataGridView1_KeyUp_1(object sender, KeyEventArgs e)
        {
            txtIDdtlPwt.Text = getKolom(dataGridView1, 0);
            txtRowdtlPWT.Text = getRow(dataGridView1);
        }

        private void txtIDdtlPwt_TextChanged(object sender, EventArgs e)
        {

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