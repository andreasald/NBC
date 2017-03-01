using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iNBC.DataSetNBCTableAdapters;
using iNBC.Control;
using iNBC.Entity;

namespace iNBC.Boundary.PendaftaranTransaksiUI
{
    public partial class PilihProduk : UserControl
    {

        TransactionControl TC = new TransactionControl();

        int flagperintah = 0;
        public void setFlag(int flag)
        {
            flagperintah = flag;
        }

        public PilihProduk()
        {
            InitializeComponent();
        }

        private void Perawatan_Load(object sender, EventArgs e)
        {
            cmbProduk.DataSource = TC.getProduk();
            cmbProduk.DisplayMember = "NAMA_PRODUK";
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            int idProdukyangdiambil = TC.getIDProduk(cmbProduk.Text);

            if (flagperintah == 0)
            {
                if (cekKosong() == true)
                {

                    if (TC.cekSudahDisanaProduk(txtID_TSC.Text, idProdukyangdiambil) == idProdukyangdiambil)
                    {
                        int kuantitasLama = TC.getKuantitasPDK(idProdukyangdiambil, txtID_TSC.Text);
                        int kuantitasBaru = kuantitasLama + int.Parse(txtKuantitas.Text);
                        int qtyPDK = int.Parse(txtKuantitas.Text);
                        float subTotalPDK = TC.getHargaProduk(idProdukyangdiambil) * qtyPDK;
                        iNBC.Entity.DetilTransaksiPDK dtlPDK = new Entity.DetilTransaksiPDK(idProdukyangdiambil, txtID_TSC.Text, kuantitasBaru, subTotalPDK);
                        TC.updateDetilPDK(dtlPDK, idProdukyangdiambil);
                        this.Hide();
                        resetText();
                        inputPemeriksaan myParent = (inputPemeriksaan)this.Parent;
                        myParent.enabledAfterPilih();
                        myParent.Show();
                    }

                    else
                    {
                        int idProduk = TC.getIDProduk(cmbProduk.Text);
                        int qtyPDK = int.Parse(txtKuantitas.Text);
                        float subTotalPDK = TC.getHargaProduk(idProduk) * qtyPDK;

                        iNBC.Entity.DetilTransaksiPDK dtlPDK = new Entity.DetilTransaksiPDK(idProduk, txtID_TSC.Text, qtyPDK, subTotalPDK);
                        TC.addDetilTransaksiPDK(dtlPDK);
                        this.Hide();
                        resetText();
                        inputPemeriksaan myParent = (inputPemeriksaan)this.Parent;
                        myParent.enabledAfterPilih();
                        myParent.Show();
                    }
                }

                else
                {
                    DialogResult dr = MessageBox.Show("Silahkan lengkapi form yang tersedia", "iNBC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }

            else if (flagperintah == 1)
            {
                if (cekKosong() == true)
                {

                    if (TC.cekSudahDisanaProduk(txtID_TSC.Text, idProdukyangdiambil) == idProdukyangdiambil)
                    {
                        int kuantitasLama = TC.getKuantitasPDK(idProdukyangdiambil, txtID_TSC.Text);
                        int kuantitasBaru = kuantitasLama + int.Parse(txtKuantitas.Text);
                        int qtyPDK = int.Parse(txtKuantitas.Text);
                        float subTotalPDK = TC.getHargaProduk(idProdukyangdiambil) * qtyPDK;
                        iNBC.Entity.DetilTransaksiPDK dtlPDK = new Entity.DetilTransaksiPDK(idProdukyangdiambil, txtID_TSC.Text, kuantitasBaru, subTotalPDK);
                        TC.updateDetilPDK(dtlPDK, idProdukyangdiambil);
                        this.Hide();
                        resetText();
                        formEditPemeriksaan myParent = (formEditPemeriksaan)this.Parent;
                        myParent.enabledAfterPilih();
                        myParent.Show();
                    }

                    else
                    {
                        int idProduk = TC.getIDProduk(cmbProduk.Text);
                        int qtyPDK = int.Parse(txtKuantitas.Text);
                        float subTotalPDK = TC.getHargaProduk(idProduk) * qtyPDK;

                        iNBC.Entity.DetilTransaksiPDK dtlPDK = new Entity.DetilTransaksiPDK(idProduk, txtID_TSC.Text, qtyPDK, subTotalPDK);
                        TC.addDetilTransaksiPDK(dtlPDK);
                        this.Hide();
                        resetText();
                        formEditPemeriksaan myParent = (formEditPemeriksaan)this.Parent;
                        myParent.enabledAfterPilih();
                        myParent.Show();
                    }
                }
            }
            
        }

        private bool cekKosong()
        {
            bool temp = true;

            if (cmbProduk.SelectedIndex == -1)
            {
                temp = false;
            }

            if (txtKuantitas.Text == "")
            {

                temp = false;
            }

            return temp;
        }

        public void isiTextBox(string id)
        {
            txtID_TSC.Text = id;
        }

        public void isiTextBoxEdit(string perawatan, string qty, string id)
        {
            cmbProduk.Text = perawatan;
            txtKuantitas.Text = qty;
            txtID_TSC.Text = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            resetText();
        }

        private void resetText()
        {
            cmbProduk.SelectedIndex = -1;
            txtKuantitas.Text = "";
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void txtKuantitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
