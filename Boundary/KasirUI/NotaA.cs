using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using iNBC.Control;
using iNBC.Entity;
using iNBC.Boundary.PendaftaranTransaksiUI;
using iNBC.Boundary.JadwalUI;
using iNBC.Boundary.KepalaKlinikUI;

namespace iNBC.Boundary.KasirUI
{
    public partial class NotaA : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["inputPembayaran"];
        System.Windows.Forms.Form fx = System.Windows.Forms.Application.OpenForms["LoginForm"];


        private PrintDocument printDocument1 = new PrintDocument();

        TransactionControl TSC_C = new TransactionControl();
        PembayaranControl PBY_C = new PembayaranControl();

        public NotaA()
        {
            InitializeComponent();
        }

        private void NotaA_Load(object sender, EventArgs e)
        {
          
            //int idPegawai = int.Parse(((LoginForm)fx).txtID.Text);

            int idPegawai = 5;
            string datenow = System.DateTime.Now.ToString("dd-MM-yy");
            string timenow = System.DateTime.Now.ToString("HH:mm");

            lblTglCetak.Text = datenow;
            lblJamCetak.Text = timenow;



            lblKasir.Text = PBY_C.AmbilNamaPegawai(idPegawai);

            lblIDTransaksi.Text = ((inputPembayaran)f).idTransaksi.Text;
            txtCekPDKKosong.Text = ((inputPembayaran)f).txtNamaPDK.Text;

            //lblIDTransaksi.Text = "011116-1";
            lblCus.Text = PBY_C.getNamaCustByIDT(lblIDTransaksi.Text);
            lblCusBawah.Text = PBY_C.getNamaCustByIDT(lblIDTransaksi.Text);
            lblDR.Text = PBY_C.getNamaDokterByIdt(lblIDTransaksi.Text);
            lblBTC.Text = TSC_C.getNamaBeauticianbyTransaksi(lblIDTransaksi.Text);
            lblPromo.Text = PBY_C.getKodePromo(lblIDTransaksi.Text);
            lblTotal.Text = PBY_C.AmbilTotalTransaksi(lblIDTransaksi.Text).ToString();

            listPWT.DataSource = TSC_C.tampilDetilPWTutkKasir(lblIDTransaksi.Text);
            listPWT.DisplayMember = "Nama Perawatan";

            listHargaPWT.DataSource = TSC_C.tampilDetilPWTutkKasir(lblIDTransaksi.Text);
            listHargaPWT.DisplayMember = "Harga @Perawatan";

            listJumlahPWT.DataSource = TSC_C.tampilDetilPWTutkKasir(lblIDTransaksi.Text);
            listJumlahPWT.DisplayMember = "Jumlah";

            listSubtotalPWT.DataSource = TSC_C.tampilDetilPWTutkKasir(lblIDTransaksi.Text);
            listSubtotalPWT.DisplayMember = "Subtotal";

            listpoinPWT.DataSource = TSC_C.tampilDetilPWTutkKasir(lblIDTransaksi.Text);
            listpoinPWT.DisplayMember = "Poin Needed";

            if (txtCekPDKKosong.Text != "")
            {
                listPDK.DataSource = TSC_C.tampilDetilPDKutkKasir(lblIDTransaksi.Text);
                listPDK.DisplayMember = "Nama Produk";

                listHargaPDK.DataSource = TSC_C.tampilDetilPDKutkKasir(lblIDTransaksi.Text);
                listHargaPDK.DisplayMember = "Harga Produk";


                listJumlahPDK.DataSource = TSC_C.tampilDetilPDKutkKasir(lblIDTransaksi.Text);
                listJumlahPDK.DisplayMember = "Jumlah";

                listSubTotalPDK.DataSource = TSC_C.tampilDetilPDKutkKasir(lblIDTransaksi.Text);
                listSubTotalPDK.DisplayMember = "Subtotal";

                lblSubtotalPDK.Text = PBY_C.getSubtotalPDKAllbyTSCID(lblIDTransaksi.Text).ToString();
            }

            lblSubtotalPWT.Text = PBY_C.getSubtotalPWTAllbyTSCID(lblIDTransaksi.Text).ToString();


            if (lblPromo.Text != "POIN")
            {

                if (txtCekPDKKosong.Text != "")
                {
                    int besarDisc = (int.Parse(lblSubtotalPDK.Text) + int.Parse(lblSubtotalPWT.Text)) - int.Parse(lblTotal.Text);

                    lblDiskon.Text = besarDisc.ToString();
                }

                else
                {
                    int besarDisc = int.Parse(lblSubtotalPWT.Text) - int.Parse(lblTotal.Text);

                    lblDiskon.Text = besarDisc.ToString();
                }

                
            }

            else
            {
                lblDiskon.Text = "0";
            }

            

            int poin = int.Parse(lblTotal.Text)/50000;

            lblPoin.Text = poin.ToString();

            lblCS.Text = PBY_C.getNamaPetugasCus(lblIDTransaksi.Text);

            

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            //                            kanan            | bawah             |kiri |   atas                   
            memoryGraphics.CopyFromScreen(this.Location.X+7, this.Location.Y-20,14   ,   -80  ,  s);
            printPreviewDialog1.ShowDialog();
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

    }
}
