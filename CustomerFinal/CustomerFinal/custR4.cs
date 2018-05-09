using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerFinal
{
    public partial class custR4 : Form
    {
        public custR4()
        {
            InitializeComponent();
        }

        private void custR4_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cust1 frm = new cust1();
            frm.Show();
            this.Hide();
        }

       

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            localhost.Service1 v = new localhost.Service1();
            bool islogin = false;
            bool isloginresult = false;
            v.creset(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text, out islogin, out isloginresult);
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

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cust1 frm = new cust1();
            frm.Show();
            this.Hide();
        }
    }
}
