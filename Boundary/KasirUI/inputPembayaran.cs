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
using iNBC.Boundary.PendaftaranTransaksiUI;
using iNBC.Boundary.JadwalUI;
using iNBC.Boundary.KasirUI;

namespace iNBC.Boundary.PendaftaranTransaksiUI
{
    public partial class inputPembayaran : Form
    {
        public inputPembayaran()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Pembayaran"];

        TransactionControl TSC_C = new TransactionControl();
        
        PembayaranControl PBY_C = new PembayaranControl();

        CustomerControl CUS_C = new CustomerControl();

        DateTime todayDate = System.DateTime.Now;

        DateTime currentTime = DateTime.Parse(System.DateTime.Now.ToString("HH:mm"));

        double besarDiskon;
        double totalAwal;
        double totalAfterDisc;
        int reward;
        int isTheirBirthday;



        public void setDataGridView(DataGridView DG)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 12);

            DG.DataSource = TSC_C.tampilDetilPWTutkKasir(idTransaksi.Text);

            DG.Columns[0].HeaderText = "Nama Perawatan";
            DG.Columns[1].HeaderText = "Kuantitas";

            DG.Columns[0].Visible = false;
            DG.Columns[1].Visible = false;

        }

        public void setDataGridView2(DataGridView DG)
        {
            this.dataGridView2.DefaultCellStyle.Font = new Font("Calibri", 12);

            DG.DataSource = TSC_C.tampilDetilPDKutkKasir(idTransaksi.Text);

            DG.Columns[0].Visible = false;
            DG.Columns[1].Visible = false;
            DG.Columns[3].Visible = false;
            DG.Columns[2].Visible = false;

            DG.Columns[4].DisplayIndex = 0; //nama
            DG.Columns[2].DisplayIndex = 1; //kuantitas
        }



        private void cekBirthDay()
        {
            DateTime CustomerBornDate = DateTime.Parse(PBY_C.getTanggalLahirCustomerBy(idTransaksi.Text).ToString("dd MM"));
            DateTime currentDate      = DateTime.Parse(System.DateTime.Now.ToString("dd MM"));

            if (CustomerBornDate == currentDate)
            {
                PBY_C.setValidBirthday(1);
                isTheirBirthday = 1;
            }
            
            else 
            {
                PBY_C.setValidBirthday(0);
                isTheirBirthday = 0;
            }
        }


        private void PendaftaranTransaksi_Load(object sender, EventArgs e)
        { 
            isiData(idTransaksi.Text);
            idTransaksi.Text = ((Pembayaran)f).txtID.Text;
            txtTransaksi.Text = idTransaksi.Text;
            cekTanggal();
            cekBirthDay();
            if(isTheirBirthday == 1)
            {
                DialogResult dr = MessageBox.Show("Pelanggan ini berulang tahun hari ini! Berikan dia ucapan selamat dan informasi promo yang tersedia untuknya!","iNBC",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            setDataGridView(this.dataGridView1);
            setDataGridView2(this.dataGridView2);

            label7.Text = TSC_C.getTotalDuitPWT(idTransaksi.Text).ToString();
            label8.Text = TSC_C.getTotalDuitPDK(idTransaksi.Text).ToString();

            totalAwal = double.Parse(label7.Text) + double.Parse(label8.Text);

            txtTotal.Text = totalAwal.ToString();


            DateTime today = System.DateTime.Now;
            string StodayDate = today.ToString("yyyy-MM-dd");

            cmbKodePromo.DataSource = PBY_C.getAvailablePromo(StodayDate);
            cmbKodePromo.DisplayMember = "KODE_PROMO";

            txtTotal.Text = totalAwal.ToString();
            

            
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

        private string getKolomX(DataGridView dg, int i, int j)
        {
            return dg[dg.Columns[i].Index, j].Value.ToString();
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


        private void updateStockProdukHere()
        {
            int jumlahRow = dataGridView2.RowCount;


            //DialogResult drXX = MessageBox.Show(jumlahRow.ToString(), "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            for (int i = 0; i < jumlahRow; i++)
            {
                
                txtNamaPDK.Text = getKolomX(dataGridView2, 4, i);
                txtKuantitasPDK.Text = getKolomX(dataGridView2, 5, i);
                
                int idPDK = TSC_C.getIDProduk(txtNamaPDK.Text);
                //DialogResult dr = MessageBox.Show("ID Produk : "+idPDK.ToString(), "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                int stokPDKNow = TSC_C.getStockProdukNow(idPDK);
                //DialogResult drX = MessageBox.Show("Stok Saat ini "+stokPDKNow.ToString(), "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                int stokPDKBaru = stokPDKNow - int.Parse(txtKuantitasPDK.Text);

                //DialogResult drXY = MessageBox.Show("Stok baru" + stokPDKBaru.ToString(), "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                TSC_C.updateStockProduk(stokPDKBaru,idPDK);
            }
        }


        //private void diskonPerawatan()
        //{
        //    int jumlahRow = dataGridView1.RowCount;

        //    for (int i = 0; i < jumlahRow; i++)
        //    {

        //        txtNamaPWT.Text = getKolomX(dataGridView1, 0, i);
        //        int idPWT = int.Parse(TSC_C.getIDPerawatan(txtNamaPWT.Text));
        //        double subtotalMINI = PBY_C.getSubtotalSinglePWT(idPWT.ToString(),idTransaksi.Text);
        //        PBY_C.updateSubTotalPWTBy(subtotalMINI, idPWT.ToString(), idTransaksi.Text);
        //    }
        //}

        //private void diskonProduct()
        //{
        //    int jumlahRow = dataGridView2.RowCount;

        //    for (int i = 0; i < jumlahRow; i++)
        //    {

        //        txtNamaPDK.Text = getKolomX(dataGridView2, 4, i);
        //        int idPDK = int.Parse(TSC_C.getIDProduk(txtNamaPDK.Text));
        //        double subtotalMINI = PBY_C.getSubtotalSinglePWT(idPDK, idTransaksi.Text);
        //        PBY_C.updateSubTotalPWTBy(subtotalMINI, idPDK, idTransaksi.Text);
        //    }
        //}


        private void hitungPromo()
        {
            besarDiskon = PBY_C.getBesarDiskon(cmbKodePromo.Text)/100;
            totalAfterDisc = totalAwal - (totalAwal*besarDiskon);
            lblDisc.Text = PBY_C.getBesarDiskon(cmbKodePromo.Text).ToString() + "%";
            txtTotal.Text = totalAfterDisc.ToString();
        }


        private void makeReward()
        {
            if (totalAfterDisc >= 50000)
            {
                int totalForReward = int.Parse(totalAfterDisc.ToString());

                string idCust = TSC_C.getIDPelanggan(idTransaksi.Text);

                int poinSaatIni = int.Parse(CUS_C.getPoinCustomer(idCust).ToString());

                
                
                int poinAdd = totalForReward / 50000;

                reward = poinSaatIni+poinAdd;
                TSC_C.updatePoinCust(reward,idCust);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioNormal.Checked == true)
            {
                if (txtBayar.Text == "" || int.Parse(txtBayar.Text) <= 0 || int.Parse(txtBayar.Text) < int.Parse(txtTotal.Text))
                {
                    DialogResult dr = MessageBox.Show("Silahkan cek kembali besar uang yang diinputkan", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else
                {
                    if (dataGridView2.RowCount != 0)
                    {
                        
                        updateStockProdukHere();
                        TSC_C.setPayed(idTransaksi.Text);
                        TSC_C.updateTotalTransaksi(double.Parse(txtTotal.Text),idTransaksi.Text);
                        makeReward();
                        DialogResult dr = MessageBox.Show("Pembayaran disimpan Normal", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        int kembalian = int.Parse(txtBayar.Text) - int.Parse(txtTotal.Text);
                        txtKembalian.Text = kembalian.ToString();

                        DialogResult dX = CustomMessage.Show("Kembalian anda sebesar: "+kembalian, "Cetak Nota", "Transaksi Baru", "Ok");

                        if (dX == DialogResult.Yes)
                        {
                            NotaA TransaksiKonsultasiDashBoard = new NotaA();
                            this.WindowState = FormWindowState.Minimized;
                            TransaksiKonsultasiDashBoard.ShowDialog();
                            this.WindowState = FormWindowState.Normal;
                        }

                        if (dX == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (dX == DialogResult.Cancel)
                        {
                            this.Close();
                        }

                        
                    }

                    else if (dataGridView2.RowCount == 0)
                    {
                        TSC_C.setPayed(idTransaksi.Text);
                        TSC_C.updateTotalTransaksi(double.Parse(txtTotal.Text), idTransaksi.Text);
                        makeReward();
                        DialogResult dr = MessageBox.Show("Pembayaran disimpan Normal", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        int kembalian = int.Parse(txtBayar.Text) - int.Parse(txtTotal.Text);
                        txtKembalian.Text = kembalian.ToString();

                        DialogResult dX = CustomMessage.Show("Kembalian anda sebesar: " + kembalian, "Cetak Nota", "Transaksi Baru", "Ok");

                        if (dX == DialogResult.Yes)
                        {
                            NotaA TransaksiKonsultasiDashBoard = new NotaA();
                            this.WindowState = FormWindowState.Minimized;
                            TransaksiKonsultasiDashBoard.ShowDialog();
                            this.WindowState = FormWindowState.Normal;
                            
                        }

                        if (dX == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (dX == DialogResult.Cancel)
                        {
                            this.Close();
                        }
                    }

                    else
                    {
                        DialogResult drX = MessageBox.Show("HAHAHAHA Error Normal!", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }

            else if (radioPoin.Checked == true)
            {
                if (txtBayar.Text == "" || int.Parse(txtBayar.Text) <= 0 || int.Parse(txtBayar.Text) < int.Parse(txtTotal.Text))
                {
                    DialogResult dr = MessageBox.Show("Silahkan cek kembali besar uang yang diinputkan", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else
                {
                    if (dataGridView2.RowCount != 0)
                    {
                        updateStockProdukHere();
                        TSC_C.setPayed(idTransaksi.Text);
                        TSC_C.updateTotalTransaksi(double.Parse(txtTotal.Text), idTransaksi.Text);
                        TSC_C.updateKodePromoInTransaksi("POIN",idTransaksi.Text);
                        makeReward();
                        DialogResult dr = MessageBox.Show("Pembayaran disimpan POIN", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        int kembalian = int.Parse(txtBayar.Text) - int.Parse(txtTotal.Text);
                        txtKembalian.Text = kembalian.ToString();

                        DialogResult dX = CustomMessage.Show("Kembalian anda sebesar: " + kembalian, "Cetak Nota", "Transaksi Baru", "Ok");

                        if (dX == DialogResult.Yes)
                        {
                            NotaA TransaksiKonsultasiDashBoard = new NotaA();
                            this.WindowState = FormWindowState.Minimized;
                            TransaksiKonsultasiDashBoard.ShowDialog();
                            this.WindowState = FormWindowState.Normal;
                        }

                        if (dX == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (dX == DialogResult.Cancel)
                        {
                            this.Close();
                        }
                    }

                    else if (dataGridView2.RowCount == 0)
                    {
                        TSC_C.setPayed(idTransaksi.Text);
                        TSC_C.updateTotalTransaksi(double.Parse(txtTotal.Text), idTransaksi.Text);
                        makeReward();
                        DialogResult dr = MessageBox.Show("Pembayaran disimpan Normal", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        int kembalian = int.Parse(txtBayar.Text) - int.Parse(txtTotal.Text);
                        txtKembalian.Text = kembalian.ToString();

                        DialogResult dX = CustomMessage.Show("Kembalian anda sebesar: " + kembalian, "Cetak Nota", "Transaksi Baru", "Ok");

                        if (dX == DialogResult.Yes)
                        {
                            NotaA TransaksiKonsultasiDashBoard = new NotaA();
                            this.WindowState = FormWindowState.Minimized;
                            TransaksiKonsultasiDashBoard.ShowDialog();
                            this.WindowState = FormWindowState.Normal;
                        }

                        if (dX == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (dX == DialogResult.Cancel)
                        {
                            this.Close();
                        }
                    }

                    else
                    {
                        DialogResult drX = MessageBox.Show("HAHAHAHA Error POIN!", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }

            else if (radioPromo.Checked == true)
            {
                if (txtBayar.Text == "" || int.Parse(txtBayar.Text) <= 0 || int.Parse(txtBayar.Text) < int.Parse(txtTotal.Text))
                {
                    DialogResult dr = MessageBox.Show("Silahkan cek kembali besar uang yang diinputkan", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else
                {
                    if (dataGridView2.RowCount != 0)
                    {
                        updateStockProdukHere();
                        
                        
                        TSC_C.setPayed(idTransaksi.Text);
                        TSC_C.updateKodePromoInTransaksi(cmbKodePromo.Text, idTransaksi.Text);
                        TSC_C.updateTotalTransaksi(double.Parse(txtTotal.Text), idTransaksi.Text);
                        makeReward();
                        DialogResult dr = MessageBox.Show("Pembayaran disimpan Promo", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        int kembalian = int.Parse(txtBayar.Text) - int.Parse(txtTotal.Text);
                        txtKembalian.Text = kembalian.ToString();

                        DialogResult dX = CustomMessage.Show("Kembalian anda sebesar: " + kembalian, "Cetak Nota", "Transaksi Baru", "Ok");

                        if (dX == DialogResult.Yes)
                        {
                            NotaA TransaksiKonsultasiDashBoard = new NotaA();
                            this.WindowState = FormWindowState.Minimized;
                            TransaksiKonsultasiDashBoard.ShowDialog();
                            this.WindowState = FormWindowState.Normal;
                            
                        }

                        if (dX == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (dX == DialogResult.Cancel)
                        {
                            this.Close();
                        }
                    }

                    else if (dataGridView2.RowCount == 0)
                    {
                        TSC_C.setPayed(idTransaksi.Text);
                        TSC_C.updateKodePromoInTransaksi(cmbKodePromo.Text, idTransaksi.Text);
                        TSC_C.updateTotalTransaksi(double.Parse(txtTotal.Text), idTransaksi.Text);
                        makeReward();
                        DialogResult dr = MessageBox.Show("Pembayaran disimpan Normal", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        int kembalian = int.Parse(txtBayar.Text) - int.Parse(txtTotal.Text);
                        txtKembalian.Text = kembalian.ToString();

                        DialogResult dX = CustomMessage.Show("Kembalian anda sebesar: " + kembalian, "Cetak Nota", "Transaksi Baru", "Ok");

                        if (dX == DialogResult.Yes)
                        {
                            NotaA TransaksiKonsultasiDashBoard = new NotaA();
                            this.WindowState = FormWindowState.Minimized;
                            TransaksiKonsultasiDashBoard.ShowDialog();
                            this.WindowState = FormWindowState.Normal;
                        }

                        if (dX == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (dX == DialogResult.Cancel)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        DialogResult drX = MessageBox.Show("HAHAHAHA Error Promo!", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }

            else
            {
                DialogResult dr = MessageBox.Show("Silahkan pilih metode pembayaran","iNBC",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
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

        private void radioPoin_CheckedChanged(object sender, EventArgs e)
        {
            btnPilihItem.Visible = true;
            txtTotal.Text = totalAwal.ToString();
            lblDisc.Visible = false;
            label12.Visible = false;
            cmbKodePromo.Enabled = false;
        }

        private void btnPilihItem_Click(object sender, EventArgs e)
        {
            potongPoin CustomerDashBoard = new potongPoin();
            this.WindowState = FormWindowState.Minimized;
            CustomerDashBoard.ShowDialog();
            this.WindowState = FormWindowState.Normal;
            
            setDataGridView(this.dataGridView1);
            setDataGridView2(this.dataGridView2);

            label7.Text = TSC_C.getTotalDuitPWT(idTransaksi.Text).ToString();
            label8.Text = TSC_C.getTotalDuitPDK(idTransaksi.Text).ToString();
            double total = double.Parse(label7.Text) + double.Parse(label8.Text);

            txtTotal.Text = total.ToString();


        }

        private void radioPromo_CheckedChanged(object sender, EventArgs e)
        {
            btnPilihItem.Visible = false;
            cmbKodePromo.Enabled = true;
            lblDisc.Visible = true;
            label12.Visible = true;
        }

        private void radioNormal_CheckedChanged(object sender, EventArgs e)
        {
            btnPilihItem.Visible = false;
            txtTotal.Text = totalAwal.ToString();
            lblDisc.Visible = false;
            label12.Visible = false;
            cmbKodePromo.Enabled = false;
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtNamaPDK.Text = getKolom(dataGridView2, 4);
            txtKuantitasPDK.Text = getKolom(dataGridView2, 5);

        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtNamaPDK.Text = getKolom(dataGridView2, 4);
            txtKuantitasPDK.Text = getKolom(dataGridView2, 5);
        }

        private void dataGridView2_KeyUp_1(object sender, KeyEventArgs e)
        {

        }

        private void cmbKodePromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            hitungPromo();
            txtTotal.Text = totalAfterDisc.ToString();
        }

        private void txtBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

    }
}