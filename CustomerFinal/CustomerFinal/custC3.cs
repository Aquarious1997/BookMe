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
    public partial class custC3 : Form
    {
        public custC3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cust1 frm = new cust1();
            frm.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            localhost.Service1 v = new localhost.Service1();
            bool islogin = false;
            bool isloginresult = false;
            v.cchangee(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text, out islogin, out isloginresult);
            if (islogin)
            {
                MessageBox.Show(" Your Password has been successfully change ");
                bunifuMetroTextbox1.Text = " ";
                bunifuMetroTextbox2.Text = " ";
                bunifuMetroTextbox3.Text = " ";


            }
            else
            {
                MessageBox.Show(" Incorrect Old Password");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
