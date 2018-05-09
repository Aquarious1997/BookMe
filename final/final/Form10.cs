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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            localhost.Service1 v = new localhost.Service1();
            bool is_exist = false; ;
            foreach (localhost.CustClass1 cust in v.showAll2())
            {
                if (cust.Name == bunifuMetroTextbox1.Text && cust.Password == bunifuMetroTextbox2.Text)
                {
                    is_exist = true;
                }
            }
            if (is_exist)
            {
                MessageBox.Show("Already exist Try something different ");

            }
            else
            {
                v.isad(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text, bunifuMetroTextbox4.Text);
                MessageBox.Show("ADDED");
                bunifuMetroTextbox1.Text = " ";
                bunifuMetroTextbox2.Text = " ";
                bunifuMetroTextbox3.Text = " ";
                bunifuMetroTextbox4.Text = " ";
            }
        }
    }
}
    

