namespace ContractManagementSystem.Forms
{
    partial class Form_AssignWork
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAssignDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.Label();
            this.cmbContractor = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.txtCACost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTsAmount = new System.Windows.Forms.Label();
            this.txtWorkTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.txtAssignDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.cmbContractor);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbYear);
            this.panel1.Controls.Add(this.txtCACost);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTsAmount);
            this.panel1.Controls.Add(this.txtWorkTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtAssignDate
            // 
            this.txtAssignDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtAssignDate.Location = new System.Drawing.Point(715, 297);
            this.txtAssignDate.Name = "txtAssignDate";
            this.txtAssignDate.Size = new System.Drawing.Size(200, 37);
            this.txtAssignDate.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(144, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Teal;
            this.txtAddress.Location = new System.Drawing.Point(277, 246);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(61, 28);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.Text = "Abc";
            this.txtAddress.Click += new System.EventHandler(this.txtAddress_Click);
            // 
            // cmbContractor
            // 
            this.cmbContractor.FormattingEnabled = true;
            this.cmbContractor.Location = new System.Drawing.Point(277, 199);
            this.cmbContractor.Name = "cmbContractor";
            this.cmbContractor.Size = new System.Drawing.Size(638, 38);
            this.cmbContractor.TabIndex = 10;
            this.cmbContractor.SelectedIndexChanged += new System.EventHandler(this.cmbContractor_SelectedIndexChanged);
            this.cmbContractor.Leave += new System.EventHandler(this.cmbContractor_Leave);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(794, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(656, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2020-21",
            "2021-22",
            "2022-23",
            "2023-24",
            "2024-25"});
            this.cmbYear.Location = new System.Drawing.Point(277, 345);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(177, 38);
            this.cmbYear.TabIndex = 8;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbTypes_SelectedIndexChanged);
            // 
            // txtCACost
            // 
            this.txtCACost.Location = new System.Drawing.Point(277, 292);
            this.txtCACost.Name = "txtCACost";
            this.txtCACost.Size = new System.Drawing.Size(269, 37);
            this.txtCACost.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(552, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Assign Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(185, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(143, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "CA Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(38, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Select Contractor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(120, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ts Amount:";
            // 
            // txtTsAmount
            // 
            this.txtTsAmount.AutoSize = true;
            this.txtTsAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTsAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTsAmount.ForeColor = System.Drawing.Color.Teal;
            this.txtTsAmount.Location = new System.Drawing.Point(277, 161);
            this.txtTsAmount.Name = "txtTsAmount";
            this.txtTsAmount.Size = new System.Drawing.Size(61, 28);
            this.txtTsAmount.TabIndex = 6;
            this.txtTsAmount.Text = "Abc";
            // 
            // txtWorkTitle
            // 
            this.txtWorkTitle.AutoSize = true;
            this.txtWorkTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtWorkTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkTitle.ForeColor = System.Drawing.Color.Teal;
            this.txtWorkTitle.Location = new System.Drawing.Point(277, 118);
            this.txtWorkTitle.Name = "txtWorkTitle";
            this.txtWorkTitle.Size = new System.Drawing.Size(61, 28);
            this.txtWorkTitle.TabIndex = 6;
            this.txtWorkTitle.Text = "Abc";
            this.txtWorkTitle.Click += new System.EventHandler(this.txtWorkTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(129, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Work Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(377, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Assign work to Contractor";
            // 
            // Form_AssignWork
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(983, 466);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AssignWork";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AssignWork";
            this.Load += new System.EventHandler(this.Form_AssignWork_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.TextBox txtCACost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtWorkTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtTsAmount;
        private System.Windows.Forms.ComboBox cmbContractor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.DateTimePicker txtAssignDate;
    }
}