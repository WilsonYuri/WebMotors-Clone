﻿namespace WebMotors
{
    partial class FormsLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.email_login = new System.Windows.Forms.TextBox();
            this.EmailLogin = new System.Windows.Forms.Label();
            this.PasswordLogin = new System.Windows.Forms.Label();
            this.password_login = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(68, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // email_login
            // 
            this.email_login.Location = new System.Drawing.Point(526, 243);
            this.email_login.Name = "email_login";
            this.email_login.Size = new System.Drawing.Size(227, 20);
            this.email_login.TabIndex = 1;
            this.email_login.TextChanged += new System.EventHandler(this.email_login_TextChanged);
            // 
            // EmailLogin
            // 
            this.EmailLogin.AutoSize = true;
            this.EmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLogin.Location = new System.Drawing.Point(523, 227);
            this.EmailLogin.Name = "EmailLogin";
            this.EmailLogin.Size = new System.Drawing.Size(32, 13);
            this.EmailLogin.TabIndex = 2;
            this.EmailLogin.Text = "Email";
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.AutoSize = true;
            this.PasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLogin.Location = new System.Drawing.Point(523, 296);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.Size = new System.Drawing.Size(53, 13);
            this.PasswordLogin.TabIndex = 4;
            this.PasswordLogin.Text = "Password";
            // 
            // password_login
            // 
            this.password_login.Location = new System.Drawing.Point(526, 315);
            this.password_login.Name = "password_login";
            this.password_login.PasswordChar = '●';
            this.password_login.Size = new System.Drawing.Size(227, 20);
            this.password_login.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormsLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordLogin);
            this.Controls.Add(this.password_login);
            this.Controls.Add(this.EmailLogin);
            this.Controls.Add(this.email_login);
            this.Controls.Add(this.label1);
            this.Name = "FormsLogin";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormsUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email_login;
        private System.Windows.Forms.Label EmailLogin;
        private System.Windows.Forms.Label PasswordLogin;
        private System.Windows.Forms.TextBox password_login;
        private System.Windows.Forms.Button button1;
    }
}