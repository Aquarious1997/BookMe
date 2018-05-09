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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form11 frm = new Form11();
            frm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form12 frm = new Form12();
            frm.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form10 frm = new Form10();
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
    }
}
