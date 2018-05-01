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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                PictureBox picture = control as PictureBox;
                if (picture != null)
                {
                    this.Controls.Remove(picture);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           

            if (bunifuMetroTextbox1.Text == " " || bunifuMetroTextbox2.Text == " "){
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();
        }
    }
}
