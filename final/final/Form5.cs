using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            localhost.Service1 v = new localhost.Service1();
            bool islogin = false;
            bool isloginresult = false;
            v.reset(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text, out islogin, out isloginresult);
            if (islogin)
            {
                MessageBox.Show(" Your Password has been successfully reset ");
                bunifuMetroTextbox1.Text = " ";
                bunifuMetroTextbox2.Text = " ";
                bunifuMetroTextbox3.Text = " ";
                
            }
            else
            {
                MessageBox.Show(" Incorrect Entries");
            }
        }
    }
}
