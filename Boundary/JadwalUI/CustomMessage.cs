using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iNBC.Boundary.JadwalUI
{
    public partial class CustomMessage : Form
    {
        public CustomMessage()
        {
            InitializeComponent();
        }

        private void CustomMessage_Load(object sender, EventArgs e)
        {
           
        }

        static CustomMessage MsgBox;
        static DialogResult result = DialogResult.No;

        public static DialogResult Show(string message,string buttonText1,string buttonText2, string buttonText3)
        {
            MsgBox = new CustomMessage();
            MsgBox.label1.Text = message;
            MsgBox.button1.Text = buttonText1;
            MsgBox.button2.Text = buttonText2;
            MsgBox.button3.Text = buttonText3;
            MsgBox.ShowDialog();
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; MsgBox.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = DialogResult.No; MsgBox.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel; MsgBox.Close();
        }
    }
}
