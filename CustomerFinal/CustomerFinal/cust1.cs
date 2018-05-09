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
    public partial class cust1 : Form
    {
        public cust1()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cust2R frm = new cust2R();
            frm.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == " " || bunifuMetroTextbox2.Text == " ")
            {
                MessageBox.Show(" Please Enter all entries");

            }
            else
            {
                localhost.Service1 v = new localhost.Service1();
                bool islogin = false;
                bool isloginresult = false;

                v.islog(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, out islogin, out isloginresult);

                if (islogin)
                {

                    bunifuMetroTextbox1.Text = " ";
                    bunifuMetroTextbox2.Text = " ";
                    MessageBox.Show(" welcome ");
                    

                }

                else
                {
                    MessageBox.Show(" Invalid Name or Password  ");

                }
            }

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            custC3 frm = new custC3();
            frm.Show();
            this.Hide();
        }

        private void cust1_Load(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            custR4 frm = new custR4();
            frm.Show();
            this.Hide();
        }
    }
}
