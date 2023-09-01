
namespace filehidedriver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.toggleStatus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.globalRule = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.saveGlobalRule = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.localHiddingRulesTable = new System.Windows.Forms.DataGridView();
            this.folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RulesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditRule = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteRule = new System.Windows.Forms.DataGridViewButtonColumn();
            this.inputFolderName = new System.Windows.Forms.TextBox();
            this.inputHiddingKeyword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.localHiddingRulesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.localHiddingRulesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.localHiddingRulesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.localHiddingRulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHiddingRulesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHiddingRulesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHiddingRulesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHiddingRulesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHiddingRulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Hiding Driver";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(2, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1505, 3);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hiding:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.status.Location = new System.Drawing.Point(139, 119);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(54, 27);
            this.status.TabIndex = 3;
            this.status.Text = "True";
            // 
            // toggleStatus
            // 
            this.toggleStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toggleStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleStatus.Location = new System.Drawing.Point(217, 115);
            this.toggleStatus.Name = "toggleStatus";
            this.toggleStatus.Size = new System.Drawing.Size(164, 31);
            this.toggleStatus.TabIndex = 4;
            this.toggleStatus.Text = "Change status";
            this.toggleStatus.UseVisualStyleBackColor = false;
            this.toggleStatus.Click += new System.EventHandler(this.toggleStatus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Global Hidding Rules";
            // 
            // globalRule
            // 
            this.globalRule.BackColor = System.Drawing.SystemColors.MenuBar;
            this.globalRule.Location = new System.Drawing.Point(50, 411);
            this.globalRule.Multiline = true;
            this.globalRule.Name = "globalRule";
            this.globalRule.Size = new System.Drawing.Size(533, 30);
            this.globalRule.TabIndex = 12;
            this.globalRule.TextChanged += new System.EventHandler(this.globalRule_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Add Global Rule";
            // 
            // saveGlobalRule
            // 
            this.saveGlobalRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saveGlobalRule.Location = new System.Drawing.Point(606, 411);
            this.saveGlobalRule.Name = "saveGlobalRule";
            this.saveGlobalRule.Size = new System.Drawing.Size(109, 30);
            this.saveGlobalRule.TabIndex = 14;
            this.saveGlobalRule.Text = "Add";
            this.saveGlobalRule.UseVisualStyleBackColor = false;
            this.saveGlobalRule.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.inputFolderName);
            this.panel1.Controls.Add(this.inputHiddingKeyword);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.localHiddingRulesTable);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1505, 860);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RulesName,
            this.EditRule,
            this.DeleteRule});
            this.dataGridView1.Location = new System.Drawing.Point(48, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 150);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // localHiddingRulesTable
            // 
            this.localHiddingRulesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localHiddingRulesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folder,
            this.Rule,
            this.Delete,
            this.Edit});
            this.localHiddingRulesTable.Location = new System.Drawing.Point(785, 219);
            this.localHiddingRulesTable.Name = "localHiddingRulesTable";
            this.localHiddingRulesTable.RowHeadersWidth = 51;
            this.localHiddingRulesTable.RowTemplate.Height = 24;
            this.localHiddingRulesTable.Size = new System.Drawing.Size(653, 222);
            this.localHiddingRulesTable.TabIndex = 19;
            this.localHiddingRulesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // folder
            // 
            this.folder.HeaderText = "Name";
            this.folder.MinimumWidth = 6;
            this.folder.Name = "folder";
            this.folder.Width = 110;
            // 
            // Rule
            // 
            this.Rule.HeaderText = "Rule";
            this.Rule.MinimumWidth = 6;
            this.Rule.Name = "Rule";
            this.Rule.Width = 110;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete ";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 110;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(779, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "Local Hidding Rules";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(746, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(3, 394);
            this.label8.TabIndex = 2;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // RulesName
            // 
            this.RulesName.HeaderText = "Rule Name";
            this.RulesName.MinimumWidth = 6;
            this.RulesName.Name = "RulesName";
            this.RulesName.Width = 150;
            // 
            // EditRule
            // 
            this.EditRule.HeaderText = "Edit";
            this.EditRule.MinimumWidth = 6;
            this.EditRule.Name = "EditRule";
            this.EditRule.Text = "Edit";
            this.EditRule.UseColumnTextForButtonValue = true;
            this.EditRule.Width = 150;
            // 
            // DeleteRule
            // 
            this.DeleteRule.HeaderText = "Delete";
            this.DeleteRule.MinimumWidth = 6;
            this.DeleteRule.Name = "DeleteRule";
            this.DeleteRule.Text = "Delete";
            this.DeleteRule.UseColumnTextForButtonValue = true;
            this.DeleteRule.Width = 150;
            // 
            // inputFolderName
            // 
            this.inputFolderName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputFolderName.Location = new System.Drawing.Point(785, 476);
            this.inputFolderName.Multiline = true;
            this.inputFolderName.Name = "inputFolderName";
            this.inputFolderName.Size = new System.Drawing.Size(533, 30);
            this.inputFolderName.TabIndex = 18;
            // 
            // inputHiddingKeyword
            // 
            this.inputHiddingKeyword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputHiddingKeyword.Location = new System.Drawing.Point(785, 538);
            this.inputHiddingKeyword.Multiline = true;
            this.inputHiddingKeyword.Name = "inputHiddingKeyword";
            this.inputHiddingKeyword.Size = new System.Drawing.Size(533, 30);
            this.inputHiddingKeyword.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(1209, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(781, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hidding Keyword";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(781, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Folder Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // localHiddingRulesBindingSource3
            // 
            this.localHiddingRulesBindingSource3.DataSource = typeof(filehidedriver.LocalHiddingRules);
            // 
            // localHiddingRulesBindingSource2
            // 
            this.localHiddingRulesBindingSource2.DataSource = typeof(filehidedriver.LocalHiddingRules);
            // 
            // localHiddingRulesBindingSource1
            // 
            this.localHiddingRulesBindingSource1.DataSource = typeof(filehidedriver.LocalHiddingRules);
            // 
            // localHiddingRulesBindingSource
            // 
            this.localHiddingRulesBindingSource.DataSource = typeof(filehidedriver.LocalHiddingRules);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(3, 616);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1502, 3);
            this.label10.TabIndex = 23;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 632);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 31);
            this.label11.TabIndex = 24;
            this.label11.Text = "Hidden Files";
            // 
            // Form1
            // 
            this.AccessibleName = "changeStatus";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1508, 860);
            this.Controls.Add(this.saveGlobalRule);
            this.Controls.Add(this.globalRule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toggleStatus);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHiddingRulesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHiddingRulesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHiddingRulesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHiddingRulesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHiddingRulesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button toggleStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox globalRule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveGlobalRule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource localHiddingRulesBindingSource;
        private System.Windows.Forms.BindingSource localHiddingRulesBindingSource1;
        private System.Windows.Forms.DataGridView localHiddingRulesTable;
        private System.Windows.Forms.BindingSource localHiddingRulesBindingSource2;
        private System.Windows.Forms.BindingSource localHiddingRulesBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn folder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rule;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RulesName;
        private System.Windows.Forms.DataGridViewButtonColumn EditRule;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteRule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputFolderName;
        private System.Windows.Forms.TextBox inputHiddingKeyword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

