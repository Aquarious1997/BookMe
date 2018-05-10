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
            comboBox4.DataSource = w.showName4();
            comboBox4.DisplayMember = "Name";
        }
    }
}
