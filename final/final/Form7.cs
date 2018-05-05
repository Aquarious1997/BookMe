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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
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

                v.islogin(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, out islogin, out isloginresult);

                if (islogin)
                {

                    bunifuMetroTextbox1.Text = " ";
                    bunifuMetroTextbox2.Text = " ";
                    MessageBox.Show(" welcome ");
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show(" Invalid Name or Password  ");

                }
            }

        }
    }
}
