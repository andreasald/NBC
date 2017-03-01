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
    public partial class Perawatan : UserControl
    {

        TransactionControl TC = new TransactionControl();

        int flagperintah = 0;
        public void setFlag(int flag)
        {
            flagperintah = flag;
        }

        public Perawatan()
        {
            InitializeComponent();
        }

        private void Perawatan_Load(object sender, EventArgs e)
        {
            cmbPerawatan.DataSource = TC.getPerawatanNonMedisMain();
            cmbPerawatan.DisplayMember = "NAMA_PERAWATAN";
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            string idPerawatanyangdiambil = TC.getIDPerawatan(cmbPerawatan.Text);

            if (flagperintah == 0)
            {
                if (cekKosong() == true)
                {

                    if (TC.cekSudahDisana(txtID_TSC.Text, idPerawatanyangdiambil) == idPerawatanyangdiambil)
                    {
                        //int kuantitasLama = TC.getKuantitasX(idPerawatanyangdiambil,txtID_TSC.Text);
                        //int kuantitasBaru = kuantitasLama + int.Parse(txtKuantitas.Text);
                        //int qtyPWT = int.Parse(txtKuantitas.Text);
                        //float subTotalPWT = TC.getHargaPerawatan(idPerawatanyangdiambil) * qtyPWT;
                        //iNBC.Entity.DetilTransaksiPwt dtlPWT = new Entity.DetilTransaksiPwt(idPerawatanyangdiambil, txtID_TSC.Text, kuantitasBaru, subTotalPWT, 0);
                        //TC.updateDetilPWT(dtlPWT, idPerawatanyangdiambil);
                        //this.Hide();
                        //resetText();
                        //PendaftaranNK myParent = (PendaftaranNK)this.Parent;
                        //myParent.enabledAfterPilih();
                        //myParent.Show();
                        DialogResult DR = MessageBox.Show("Jumlah perawatan maksimal hanya 1 untuk setiap perawatan","iNBC",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }

                    else
                    {
                        string idPerawatan = TC.getIDPerawatan(cmbPerawatan.Text);
                        int qtyPWT = int.Parse(txtKuantitas.Text);
                        float subTotalPWT = TC.getHargaPerawatan(idPerawatan) * qtyPWT;

                        iNBC.Entity.DetilTransaksiPwt dtlPWT = new Entity.DetilTransaksiPwt(idPerawatan, txtID_TSC.Text, qtyPWT, subTotalPWT, 0);
                        TC.addDetilTransaksi(dtlPWT);
                        this.Hide();
                        resetText();
                        PendaftaranNK myParent = (PendaftaranNK)this.Parent;
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
 
            }
            
        }

        private bool cekKosong()
        {
            bool temp = true;

            if (cmbPerawatan.SelectedIndex == -1)
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
            cmbPerawatan.Text = perawatan;
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
            cmbPerawatan.SelectedIndex = -1;
            txtKuantitas.Text = "1";
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
