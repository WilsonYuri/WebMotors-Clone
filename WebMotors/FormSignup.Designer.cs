namespace WebMotors
{
    partial class FormSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignup));
            this.Submit = new System.Windows.Forms.Button();
            this.PasswordLogin = new System.Windows.Forms.Label();
            this.PasswordSignUp = new System.Windows.Forms.TextBox();
            this.EmailLogin = new System.Windows.Forms.Label();
            this.EmailSignUp = new System.Windows.Forms.TextBox();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.FirstNameSignUp = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.LastNameSignUp = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.PhoneNumberSignUp = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.CPFSignUp = new System.Windows.Forms.TextBox();
            this.labelBirth = new System.Windows.Forms.Label();
            this.DateOfBirthSignUp = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManage = new System.Windows.Forms.Button();
            this.ManagementLabel = new System.Windows.Forms.Label();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.enter = new System.Windows.Forms.Button();
            this.PasswordManagement = new System.Windows.Forms.TextBox();
            this.PasswordManage = new System.Windows.Forms.Label();
            this.Overview = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(430, 452);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 11;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.AutoSize = true;
            this.PasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLogin.Location = new System.Drawing.Point(70, 206);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.Size = new System.Drawing.Size(53, 13);
            this.PasswordLogin.TabIndex = 10;
            this.PasswordLogin.Text = "Password";
            // 
            // PasswordSignUp
            // 
            this.PasswordSignUp.Location = new System.Drawing.Point(73, 225);
            this.PasswordSignUp.Name = "PasswordSignUp";
            this.PasswordSignUp.PasswordChar = '*';
            this.PasswordSignUp.Size = new System.Drawing.Size(441, 20);
            this.PasswordSignUp.TabIndex = 9;
            // 
            // EmailLogin
            // 
            this.EmailLogin.AutoSize = true;
            this.EmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLogin.Location = new System.Drawing.Point(70, 155);
            this.EmailLogin.Name = "EmailLogin";
            this.EmailLogin.Size = new System.Drawing.Size(32, 13);
            this.EmailLogin.TabIndex = 8;
            this.EmailLogin.Text = "Email";
            // 
            // EmailSignUp
            // 
            this.EmailSignUp.Location = new System.Drawing.Point(73, 171);
            this.EmailSignUp.Name = "EmailSignUp";
            this.EmailSignUp.Size = new System.Drawing.Size(441, 20);
            this.EmailSignUp.TabIndex = 7;
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SignInLabel.Location = new System.Drawing.Point(69, 62);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(61, 20);
            this.SignInLabel.TabIndex = 6;
            this.SignInLabel.Text = "SignIn";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(70, 110);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 13;
            this.labelFirstName.Text = "First Name";
            this.labelFirstName.Click += new System.EventHandler(this.label2_Click);
            // 
            // FirstNameSignUp
            // 
            this.FirstNameSignUp.Location = new System.Drawing.Point(73, 126);
            this.FirstNameSignUp.Name = "FirstNameSignUp";
            this.FirstNameSignUp.Size = new System.Drawing.Size(374, 20);
            this.FirstNameSignUp.TabIndex = 12;
            this.FirstNameSignUp.TextChanged += new System.EventHandler(this.FirstNameSignUp_TextChanged);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(499, 110);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 15;
            this.labelLastName.Text = "Last Name";
            // 
            // LastNameSignUp
            // 
            this.LastNameSignUp.Location = new System.Drawing.Point(502, 126);
            this.LastNameSignUp.Name = "LastNameSignUp";
            this.LastNameSignUp.Size = new System.Drawing.Size(374, 20);
            this.LastNameSignUp.TabIndex = 14;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(70, 260);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumber.TabIndex = 17;
            this.PhoneNumber.Text = "Phone Number";
            // 
            // PhoneNumberSignUp
            // 
            this.PhoneNumberSignUp.Location = new System.Drawing.Point(73, 279);
            this.PhoneNumberSignUp.Name = "PhoneNumberSignUp";
            this.PhoneNumberSignUp.Size = new System.Drawing.Size(211, 20);
            this.PhoneNumberSignUp.TabIndex = 16;
            this.PhoneNumberSignUp.TextChanged += new System.EventHandler(this.PhoneNumberSignUp_TextChanged);
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.Location = new System.Drawing.Point(70, 313);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 19;
            this.labelCPF.Text = "CPF";
            // 
            // CPFSignUp
            // 
            this.CPFSignUp.Location = new System.Drawing.Point(73, 332);
            this.CPFSignUp.Name = "CPFSignUp";
            this.CPFSignUp.Size = new System.Drawing.Size(211, 20);
            this.CPFSignUp.TabIndex = 18;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirth.Location = new System.Drawing.Point(70, 370);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(66, 13);
            this.labelBirth.TabIndex = 21;
            this.labelBirth.Text = "Date of Birth";
            this.labelBirth.Click += new System.EventHandler(this.label4_Click);
            // 
            // DateOfBirthSignUp
            // 
            this.DateOfBirthSignUp.CustomFormat = "";
            this.DateOfBirthSignUp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirthSignUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateOfBirthSignUp.Location = new System.Drawing.Point(73, 386);
            this.DateOfBirthSignUp.Name = "DateOfBirthSignUp";
            this.DateOfBirthSignUp.Size = new System.Drawing.Size(211, 20);
            this.DateOfBirthSignUp.TabIndex = 22;
            this.DateOfBirthSignUp.Value = new System.DateTime(2023, 8, 23, 12, 2, 29, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1819, 966);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(1779, 21);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(91, 39);
            this.btnManage.TabIndex = 25;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // ManagementLabel
            // 
            this.ManagementLabel.AutoSize = true;
            this.ManagementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagementLabel.Location = new System.Drawing.Point(35, 40);
            this.ManagementLabel.Name = "ManagementLabel";
            this.ManagementLabel.Size = new System.Drawing.Size(293, 20);
            this.ManagementLabel.TabIndex = 27;
            this.ManagementLabel.Text = "Management of the login database ";
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Controls.Add(this.enter);
            this.PasswordPanel.Controls.Add(this.PasswordManagement);
            this.PasswordPanel.Controls.Add(this.PasswordManage);
            this.PasswordPanel.Location = new System.Drawing.Point(708, 481);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(478, 102);
            this.PasswordPanel.TabIndex = 26;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(208, 59);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 13;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // PasswordManagement
            // 
            this.PasswordManagement.Location = new System.Drawing.Point(24, 33);
            this.PasswordManagement.Name = "PasswordManagement";
            this.PasswordManagement.PasswordChar = '*';
            this.PasswordManagement.Size = new System.Drawing.Size(441, 20);
            this.PasswordManagement.TabIndex = 11;
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
            // Overview
            // 
            this.Overview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.FirstName,
            this.LastName,
            this.Email,
            this.columnHeader1,
            this.CPF,
            this.DateOfBirth});
            this.Overview.HideSelection = false;
            this.Overview.Location = new System.Drawing.Point(39, 74);
            this.Overview.Name = "Overview";
            this.Overview.Size = new System.Drawing.Size(1831, 946);
            this.Overview.TabIndex = 24;
            this.Overview.UseCompatibleStateImageBehavior = false;
            this.Overview.View = System.Windows.Forms.View.Details;
            this.Overview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Overview_MouseDoubleClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 40;
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Phone Number";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 101;
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
            // FormSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.ManagementLabel);
            this.Controls.Add(this.PasswordPanel);
            this.Controls.Add(this.Overview);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DateOfBirthSignUp);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.CPFSignUp);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.PhoneNumberSignUp);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.LastNameSignUp);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.FirstNameSignUp);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.PasswordLogin);
            this.Controls.Add(this.PasswordSignUp);
            this.Controls.Add(this.EmailLogin);
            this.Controls.Add(this.EmailSignUp);
            this.Controls.Add(this.SignInLabel);
            this.Name = "FormSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignup";
            this.Load += new System.EventHandler(this.FormSignup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label PasswordLogin;
        private System.Windows.Forms.TextBox PasswordSignUp;
        private System.Windows.Forms.Label EmailLogin;
        private System.Windows.Forms.TextBox EmailSignUp;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox FirstNameSignUp;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox LastNameSignUp;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.TextBox PhoneNumberSignUp;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox CPFSignUp;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.DateTimePicker DateOfBirthSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Label ManagementLabel;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox PasswordManagement;
        private System.Windows.Forms.Label PasswordManage;
        private System.Windows.Forms.ListView Overview;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader DateOfBirth;
    }
}