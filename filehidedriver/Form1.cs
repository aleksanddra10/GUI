using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filehidedriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            localHiddingRulesTable.AutoGenerateColumns = false;
            localHiddingRulesTable.Rows.Add("Folder A", "*confidential*");
            localHiddingRulesTable.Rows.Add("Folder B", "*confidential*");
            localHiddingRulesTable.Rows.Add("Folder C", "*Private*");
            localHiddingRulesTable.Rows.Add("Folder D", "*confidential*");
            localHiddingRulesTable.Rows.Add("Folder E", "*Private*");

            //LocalHiddingRules shr = new LocalHiddingRules("shaan", "private");

            //localHiddingRulesBindingSource3.Add(shr);
            //localHiddingRulesBindingSource3.Add(new LocalHiddingRules("Folder B", "*confidential*"));
            //localHiddingRulesBindingSource3.Add(new LocalHiddingRules("Folder C", "*Private*"));
            //localHiddingRulesBindingSource3.Add(new LocalHiddingRules("Folder D", "*Private*"));
            //localHiddingRulesBindingSource3.Add(new LocalHiddingRules("Folder E", "*Private*"));
            //localHiddingRulesBindingSource3.Add(new LocalHiddingRules("Folder F", "*Private*"));
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Rows.Add("FirstName");
            dataGridView1.Rows.Add("LastName");
            dataGridView1.Rows.Add("Age");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toggleStatus_Click(object sender, EventArgs e)
        {
            if (status.Text.Equals("True"))
            {
                status.Text = "False";
            }
            else
            {
                status.Text = "True";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void globalRule_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(globalRule.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            localHiddingRulesTable.Rows.Add(inputFolderName.Text,inputHiddingKeyword.Text);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
