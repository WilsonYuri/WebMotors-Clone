namespace WebMotors
{
    partial class Management
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
            this.Overview = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PasswordManage = new System.Windows.Forms.Label();
            this.PasswordManagement = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.PasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Overview
            // 
            this.Overview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Email,
            this.PhoneNumber,
            this.CPF,
            this.DateOfBirth});
            this.Overview.HideSelection = false;
            this.Overview.Location = new System.Drawing.Point(35, 62);
            this.Overview.Name = "Overview";
            this.Overview.Size = new System.Drawing.Size(923, 480);
            this.Overview.TabIndex = 0;
            this.Overview.UseCompatibleStateImageBehavior = false;
            this.Overview.View = System.Windows.Forms.View.Details;
            this.Overview.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstName.Width = 113;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastName.Width = 109;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 116;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Phone Number";
            this.PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PhoneNumber.Width = 101;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            this.CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CPF.Width = 86;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Text = "Date Of Birth";
            this.DateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateOfBirth.Width = 107;
            // 
            // PasswordManage
            // 
            this.PasswordManage.AutoSize = true;
            this.PasswordManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordManage.Location = new System.Drawing.Point(21, 14);
            this.PasswordManage.Name = "PasswordManage";
            this.PasswordManage.Size = new System.Drawing.Size(53, 13);
            this.PasswordManage.TabIndex = 12;
            this.PasswordManage.Text = "Password";
            // 
            // PasswordManagement
            // 
            this.PasswordManagement.Location = new System.Drawing.Point(24, 33);
            this.PasswordManagement.Name = "PasswordManagement";
            this.PasswordManagement.PasswordChar = '*';
            this.PasswordManagement.Size = new System.Drawing.Size(441, 20);
            this.PasswordManagement.TabIndex = 11;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(208, 59);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 13;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Controls.Add(this.Submit);
            this.PasswordPanel.Controls.Add(this.PasswordManagement);
            this.PasswordPanel.Controls.Add(this.PasswordManage);
            this.PasswordPanel.Location = new System.Drawing.Point(272, 248);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(478, 102);
            this.PasswordPanel.TabIndex = 14;
            this.PasswordPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PasswordPanel_Paint);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 595);
            this.Controls.Add(this.PasswordPanel);
            this.Controls.Add(this.Overview);
            this.Name = "Management";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Management_Load);
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Overview;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader DateOfBirth;
        private System.Windows.Forms.Label PasswordManage;
        private System.Windows.Forms.TextBox PasswordManagement;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Panel PasswordPanel;
    }
}