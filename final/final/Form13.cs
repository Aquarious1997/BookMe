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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();

        }
        DataTable rt = new DataTable();
        int selectedr;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form14 frm = new Form14();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 v = new localhost.Service1();
            //v.isad(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), nauman);
            v.isaf(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text, bunifuMetroTextbox4.Text, bunifuMetroTextbox5.Text);
            v.adname1(bunifuMetroTextbox1.Text);
            v.adname2(bunifuMetroTextbox2.Text);
            v.adname3(bunifuMetroTextbox3.Text);
            v.adname4(bunifuMetroTextbox4.Text);
            v.adname5(bunifuMetroTextbox5.Text);
            //      rt.Rows.Add(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text, bunifuMetroTextbox4.Text, bunifuMetroTextbox5.Text);
            rt.Rows.Add(bunifuMetroTextbox1.Text, bunifuMetroTextbox4.Text, bunifuMetroTextbox5.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text);
            dataGridView1.DataSource = rt;
            bunifuMetroTextbox1.Text = " "; bunifuMetroTextbox2.Text = " "; bunifuMetroTextbox3.Text = " ";
            bunifuMetroTextbox4.Text = " "; bunifuMetroTextbox5.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedr = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow r = dataGridView1.Rows[selectedr];
            bool ind = true;
            localhost.Service1 er = new localhost.Service1();
            er.deletepp(selectedr, ind);


            BindingSource yu = new BindingSource();
            yu.DataSource = er.showAll3();
            dataGridView1.DataSource = yu;

            er.delete1(selectedr, ind);
            er.delete2(selectedr, ind);
            er.delete3(selectedr, ind);
            er.delete4(selectedr, ind);
            er.delete5(selectedr, ind);
            bunifuMetroTextbox1.Text = " "; bunifuMetroTextbox2.Text = " "; bunifuMetroTextbox3.Text = " ";
            bunifuMetroTextbox4.Text = " "; bunifuMetroTextbox5.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            localhost.Service1 er = new localhost.Service1();
            BindingSource yu = new BindingSource();
            yu.DataSource = er.showAll3();
            dataGridView1.DataSource = yu;
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            rt.Columns.Add("Service", typeof(string));
            rt.Columns.Add("Bus", typeof(string));
            rt.Columns.Add("Capacity", typeof(string));
            rt.Columns.Add("Route", typeof(string));
            rt.Columns.Add("Routee", typeof(string));


            localhost.Service1 er = new localhost.Service1();
            dataGridView1.DataSource = rt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool fr = false;
            selectedr = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newdata = dataGridView1.Rows[selectedr];
            newdata.Cells[1].Value = bunifuMetroTextbox4.Text;
            newdata.Cells[2].Value = bunifuMetroTextbox5.Text;
            localhost.Service1 local = new localhost.Service1();
            local.updateItem(selectedr, fr, bunifuMetroTextbox4.Text, bunifuMetroTextbox5.Text);
            local.updateCapacity(bunifuMetroTextbox5.Text, selectedr, fr);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int ind;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = e.RowIndex;
            DataGridViewRow r = dataGridView1.Rows[ind];
            bunifuMetroTextbox1.Text = r.Cells[0].Value.ToString();
            bunifuMetroTextbox2.Text = r.Cells[3].Value.ToString();
            bunifuMetroTextbox3.Text = r.Cells[4].Value.ToString();
            bunifuMetroTextbox4.Text = r.Cells[1].Value.ToString();
            bunifuMetroTextbox5.Text = r.Cells[2].Value.ToString();


        }
    }
}
