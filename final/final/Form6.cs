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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            if (bunifuMetroTextbox1.Text == " " && bunifuMetroTextbox2.Text == " " && bunifuMetroTextbox3.Text == " " && bunifuMetroTextbox4.Text == " ")
            {
                MessageBox.Show(" Please fill all entries ");
            }
            else
            {
                

                    localhost.Service1 v = new localhost.Service1();
                    v.isadd(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text, bunifuMetroTextbox4.Text);
                
                
                    MessageBox.Show(bunifuMetroTextbox1.Text, "Successfully register ");
               
                
                    bunifuMetroTextbox1.Text = " ";
                    bunifuMetroTextbox2.Text = " ";
                    bunifuMetroTextbox3.Text = " ";
                    bunifuMetroTextbox4.Text = " ";
              


                }
            }
        

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
