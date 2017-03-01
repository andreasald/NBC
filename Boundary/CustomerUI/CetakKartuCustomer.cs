using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iNBC.DataSetNBCTableAdapters;
using CrystalDecisions.CrystalReports.Engine;

namespace iNBC.Boundary.CustomerUI
{
    public partial class CetakKartuCustomer : Form
    {
        public CetakKartuCustomer()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["PengelolaanCustomer"];

        private CUSTOMERTableAdapter T_CSTMRx = new CUSTOMERTableAdapter();

        private void CetakKartuCustomer_Load(object sender, EventArgs e)
        {

            tempID.Text = ((PengelolaanCustomer)f).txtID.Text;

            int lengthID = tempID.Text.Length;

            string A = tempID.Text.Substring(0, 4);
            string B = tempID.Text.Substring(4, 4);
            string C = tempID.Text.Substring(8, 4);
            string D = tempID.Text.Substring(12, lengthID-12);

            string newID = A + ' ' + B + ' ' + C + ' ' + D;
            

            KartuCustomer krt = new KartuCustomer();
            DataTable data = new DataTable();
            data = T_CSTMRx.cetakByID(tempID.Text);
            krt.SetDataSource(data);

            TextObject to = (TextObject)krt.ReportDefinition.Sections["Section3"].ReportObjects["txtIDcusSpaced"];
            to.Text = newID;

            crystalReportViewer1.ReportSource = krt;
            crystalReportViewer1.Show();
        }
    }
}
