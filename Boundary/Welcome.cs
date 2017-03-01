using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iNBC.Boundary
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        public void setToolStripUser(string text)
        {
            this.toolStripUser.Text = text;
        }

    }
}
