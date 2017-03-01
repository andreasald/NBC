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
    public partial class availablePromo : Form
    {



        public availablePromo()
        {
            InitializeComponent();
        }

        PembayaranControl PBY_C = new PembayaranControl();

        DateTime todayDate = System.DateTime.Now;

        DateTime currentTime = DateTime.Parse(System.DateTime.Now.ToString("HH:mm"));
        


        public void setDataGridView(DataGridView DG)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 12);
            
            DateTime today = System.DateTime.Now;
            string StodayDate = today.ToString("yyyy-MM-dd");

            DG.DataSource = PBY_C.getAvailablePromo(StodayDate);



            DG.Columns[0].HeaderText = "Kode Promo";
            DG.Columns[1].HeaderText = "Nama Promo";
            DG.Columns[2].HeaderText = "Diskon";

            DG.Columns[3].Visible = false;
            DG.Columns[4].Visible = false;
            DG.Columns[5].Visible = false;

            DG.Columns[0].Width = 100;
            DG.Columns[1].Width = 183;
            DG.Columns[2].Width = 50;
        }

       



        private void PendaftaranTransaksi_Load(object sender, EventArgs e)
        { 
            isiData(idTransaksi.Text);            
            cekTanggal();
            setDataGridView(this.dataGridView1);
        }

        private void cekTanggal()
        {
            DateTime today = System.DateTime.Now;

            string StodayDate = today.ToString("yyyy-MM-dd HH:mm:ss");
            //string SlastDate = TSC_C.ambilLastDate().ToString("dd/MM/yy");

            //DateTime todayDate = DateTime.Parse(StodayDate);
            //DateTime lastDate = DateTime.Parse(SlastDate);

            //if (lastDate == todayDate)
            //{
            //    string theLast = TSC_C.ambilLastIDTransaksi();
            //    string idLast = theLast.Substring(7);
            //    todayTransaction = int.Parse(idLast) + 1;
            //}

            //else if (lastDate < todayDate)
            //{
            //    todayTransaction = 1;
            //}

        }

        private void button5_Click(object sender, EventArgs e) // verifikasi button ya
        {
            
        }

        private void txtIDCustomer_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
        }


        //public string createIDtransaksi()
        //{
        //    string temp = "";

        //    string days = System.DateTime.Now.ToString("dd");
        //    string month = System.DateTime.Now.ToString("MM");
        //    string year = System.DateTime.Now.ToString("yy");

        //    temp = days + month + year + "-" + todayTransaction.ToString();

        //    return temp;

        //}

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {            
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



        private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void txtIDdtlPwt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        public void isiData(string idT)
        {
            
        }

        private void perawatan1_Load(object sender, EventArgs e)
        {

        }

        private void pilihPerawatan1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formEditPemeriksaan TransaksiKonsultasiDashBoard = new formEditPemeriksaan();
            this.WindowState = FormWindowState.Minimized;
            TransaksiKonsultasiDashBoard.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDtsc.Text = getKolom(dataGridView1, 0);
            txtRowTSC.Text = getRow(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDtsc.Text = getKolom(dataGridView1, 0);
            txtRowTSC.Text = getRow(dataGridView1);
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            txtIDtsc.Text = getKolom(dataGridView1, 0);
            txtRowTSC.Text = getRow(dataGridView1);
        }

    }
}