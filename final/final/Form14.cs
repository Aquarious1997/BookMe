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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form13 frm = new Form13();
            frm.Show();
            this.Hide();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            localhost.Service1 w = new localhost.Service1();
            comboBox1.DataSource = w.showName1();
            comboBox1.DisplayMember = "Name";
            comboBox2.DataSource = w.showName2();
            comboBox2.DisplayMember = "Name";
            comboBox3.DataSource = w.showName3();
            comboBox3.DisplayMember = "Name";
            
        }
        int d;
        int we = 400;
        int de = 900;
        int rt = 500;
        int rest;
        int rest1;
        int rest2;
        private void button1_Click(object sender, EventArgs e)
        {
            d = int.Parse(textBox1.Text);
            rest = d * we;
            rest1 = d * de;
            rest2 = d * rt;


            if (comboBox1.Text == "Daewoo" || comboBox1.Text == "Faisalmovers") {
                if (comboBox2.Text == "Lahore" || comboBox3.Text == "Faisalabad" || comboBox3.Text == "Lahore" || comboBox2.Text == "Faisalabad")
                {
                    textBox2.Text = rest.ToString();
                } }
            else if (comboBox1.Text == "Daewoo" || comboBox1.Text == "Faisalmovers") {
                if (comboBox2.Text == "Lahore" || comboBox3.Text == "Islamabad" || comboBox3.Text == "Lahore" || comboBox2.Text == "Islamabad")
                {
                    textBox2.Text = rest1.ToString();
                }
               }
           
            
            else if (comboBox1.Text == "Daewoo" || comboBox1.Text == "Faisalmovers")
            {
                if (comboBox2.Text == "Faisalabad" || comboBox3.Text == "Islamabad" || comboBox3.Text == "Faisalabad" || comboBox2.Text == "Islamabad")
                {
                    textBox2.Text = rest2.ToString();
                }
            }
            else if (comboBox1.Text == "Shuja")
            {
                if (comboBox2.Text == "Faisalabad" || comboBox3.Text == "Islamabad" || comboBox3.Text == "Faisalabad" || comboBox2.Text == "Islamabad")
                {
                    textBox2.Text = rest2.ToString();
                }

            }
            else if (comboBox1.Text == "Shuja")
            {
                if (comboBox2.Text == "Lahore" || comboBox3.Text == "Islamabad" || comboBox3.Text == "Lahore" || comboBox2.Text == "Islamabad")
                {
                    textBox2.Text = rest1.ToString();
                }

            }
            else if (comboBox1.Text == "Shuja")
            {
                if (comboBox2.Text == "Lahore" || comboBox3.Text == "Faisalabad" || comboBox3.Text == "Lahore" || comboBox2.Text == "Faisalabad")
                {
                    textBox2.Text = rest.ToString();
                }

            }
            else
            {
                MessageBox.Show(" Invalid Entries");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Booked");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 frm = new Form15();
            frm.Show();
            this.Hide();
            
        }
    }
}
