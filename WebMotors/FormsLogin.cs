using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand();
            command.Connection = connection.ReturnConnection();


            command.CommandText = "SELECT * FROM SignUp_Info WHERE Email = @Email AND Senha = @Password";

            command.Parameters.AddWithValue("@Nome", email_login.Text);
            command.Parameters.AddWithValue("@Senha", password_login.Text);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                // O nome de usuário e a senha estão corretos
                // Abrir o próximo formulário

            }
            else
            {
                // O nome de usuário e a senha estão incorretos
                MessageBox.Show("Email or password invalid");
            }


        }
    }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
