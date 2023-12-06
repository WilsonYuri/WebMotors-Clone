using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebMotors
{
    public partial class FormsLogin : Form
    {
        public FormsLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string email = email_login.Text;
            string password = password_login.Text;

            UserDAO userDAO = new UserDAO();

            User user = userDAO.LoginUser(email, password);

            if (user != null)
            {
                MessageBox.Show("Welcome, " + user.Firstname + "!");
            }
            else
            {
                // O nome de usuário e a senha estão incorretos
                MessageBox.Show("Email or password invalid, try again");
            }


        }

        private void email_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

