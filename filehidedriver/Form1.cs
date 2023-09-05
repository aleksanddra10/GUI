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
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == localHiddingRulesTable.Columns["Delete"].Index)
                {
                    // Ask the user for confirmation before deleting
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Delete Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Remove the selected row from the DataGridView
                        localHiddingRulesTable.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                if (e.ColumnIndex == localHiddingRulesTable.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = localHiddingRulesTable.Rows[e.RowIndex];

                    // Check if the selected row and cell values are not null
                    if (selectedRow != null && selectedRow.Cells["folder"].Value != null && selectedRow.Cells["Rule"].Value != null)
                    {
                        // Retrieve values of "Name" and "Rule" columns
                        string name = selectedRow.Cells["folder"].Value.ToString();
                        string rule = selectedRow.Cells["Rule"].Value.ToString();

                        // Assuming you have TextBox controls for editing
                        // You can display the values for editing in TextBoxes
                        inputFolderName.Text = name;
                        inputHiddingKeyword.Text = rule;

                        // Optionally, disable the "Edit" button while editing
                        if (localHiddingRulesTable.Columns.Contains("Edit"))
                        {
                            localHiddingRulesTable.Columns["Edit"].ReadOnly = true;
                        }
                        else
                        {
                            MessageBox.Show("The 'Edit' column was not found in the DataGridView.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected row or cell values are null.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Add a button to save changes
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the edited values from TextBoxes
                string newName = inputFolderName.Text;
                string newRule = inputHiddingKeyword.Text;

                // Update the selected row in the DataGridView
                if (localHiddingRulesTable.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = localHiddingRulesTable.SelectedRows[0];

                    // Check if the selected row and cell values are not null
                    if (selectedRow != null && selectedRow.Cells["folder"].Value != null && selectedRow.Cells["Rule"].Value != null)
                    {
                        selectedRow.Cells["folder"].Value = newName;
                        selectedRow.Cells["Rule"].Value = newRule;
                    }
                    else
                    {
                        MessageBox.Show("Selected row or cell values are null.");
                    }
                }

                // Optionally, re-enable the "Edit" button
                localHiddingRulesTable.Columns["Edit"].ReadOnly = false;

                // Clear the TextBoxes
                inputFolderName.Clear();
                inputHiddingKeyword.Clear();
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void globalRule_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == dataGridView1.Columns["EditRule"].Index)
                    {
                        // Edit button clicked, implement edit logic here
                        DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                        // Retrieve the "RulesName" value from the selected row
                        string rulesName = selectedRow.Cells["RulesName"].Value.ToString();

                        // Assuming you have TextBox controls for editing
                        // Display the value in a TextBox for editing
                        globalRule.Text = rulesName;
                    }
                    else if (e.ColumnIndex == dataGridView1.Columns["DeleteRule"].Index)
                    {
                        // Delete button clicked, ask for confirmation
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Delete Confirmation", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            // Remove the selected row from the DataGridView
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Add a button to save changes for editing
        private void btnSaveChanges_Click1(object sender, EventArgs e)
        {
            try
            {
                // Get the edited value from the TextBox
                string editedRulesName = globalRule.Text;

                // Update the selected row in the DataGridView if necessary
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Update the "RulesName" column value in the selected row
                    selectedRow.Cells["RulesName"].Value = editedRulesName;
                }

                // Clear the TextBox
                globalRule.Clear();
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show("Error: " + ex.Message);
            }
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
