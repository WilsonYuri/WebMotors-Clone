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
            this.Submit = new System.Windows.Forms.Button();
            this.PasswordLogin = new System.Windows.Forms.Label();
            this.PasswordSignUp = new System.Windows.Forms.TextBox();
            this.EmailLogin = new System.Windows.Forms.Label();
            this.EmailSignUp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.FirstNameSignUp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameSignUp = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.PhoneNumberSignUp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CPFSignUp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateOfBirthSignUp = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(502, 534);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(69, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "SignIn";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(70, 110);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 13);
            this.label.TabIndex = 13;
            this.label.Text = "First Name";
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // FirstNameSignUp
            // 
            this.FirstNameSignUp.Location = new System.Drawing.Point(73, 126);
            this.FirstNameSignUp.Name = "FirstNameSignUp";
            this.FirstNameSignUp.Size = new System.Drawing.Size(211, 20);
            this.FirstNameSignUp.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name";
            // 
            // LastNameSignUp
            // 
            this.LastNameSignUp.Location = new System.Drawing.Point(305, 126);
            this.LastNameSignUp.Name = "LastNameSignUp";
            this.LastNameSignUp.Size = new System.Drawing.Size(209, 20);
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
            this.PhoneNumberSignUp.Size = new System.Drawing.Size(441, 20);
            this.PhoneNumberSignUp.TabIndex = 16;
            this.PhoneNumberSignUp.TextChanged += new System.EventHandler(this.PhoneNumberSignUp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "CPF";
            // 
            // CPFSignUp
            // 
            this.CPFSignUp.Location = new System.Drawing.Point(73, 332);
            this.CPFSignUp.Name = "CPFSignUp";
            this.CPFSignUp.Size = new System.Drawing.Size(441, 20);
            this.CPFSignUp.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date of Birth";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // FormSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 682);
            this.Controls.Add(this.DateOfBirthSignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPFSignUp);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.PhoneNumberSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameSignUp);
            this.Controls.Add(this.label);
            this.Controls.Add(this.FirstNameSignUp);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.PasswordLogin);
            this.Controls.Add(this.PasswordSignUp);
            this.Controls.Add(this.EmailLogin);
            this.Controls.Add(this.EmailSignUp);
            this.Controls.Add(this.label1);
            this.Name = "FormSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignup";
            this.Load += new System.EventHandler(this.FormSignup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label PasswordLogin;
        private System.Windows.Forms.TextBox PasswordSignUp;
        private System.Windows.Forms.Label EmailLogin;
        private System.Windows.Forms.TextBox EmailSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox FirstNameSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameSignUp;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.TextBox PhoneNumberSignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CPFSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateOfBirthSignUp;
    }
}