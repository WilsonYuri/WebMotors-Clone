using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WebMotors
{
    public partial class FormSignup : Form
    {
        private bool created = false;
        public FormSignup()
        {
            InitializeComponent();
        }

        public bool Created
        {
            get { return created; }
            set { created = value; }
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void Submit_Click(object sender, EventArgs e)
        {

            string email = EmailSignUp.Text;

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO SignUp_Info VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password, @CPF, @DateOfBirth)";

            sqlCommand.Parameters.AddWithValue("@FirstName", FirstNameSignUp.Text);
            sqlCommand.Parameters.AddWithValue("@LastName", LastNameSignUp.Text);
            sqlCommand.Parameters.AddWithValue("@Email", EmailSignUp.Text);
            sqlCommand.Parameters.AddWithValue("@Password", PasswordSignUp.Text);
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumberSignUp.Text);
            sqlCommand.Parameters.AddWithValue("@CPF", CPFSignUp.Text);
            sqlCommand.Parameters.AddWithValue("@DateOfBirth", DateOfBirthSignUp.Value);

            if (IsValidEmail(email))
            {
                sqlCommand.ExecuteNonQuery();
                Created = true;

                FirstNameSignUp.Clear();
                LastNameSignUp.Clear();
                EmailSignUp.Clear();
                PasswordSignUp.Clear();
                PhoneNumberSignUp.Clear();
                CPFSignUp.Clear();

                Close();
            }
            else
            {
                MessageBox.Show("O endereço de e - mail é inválido");

            }
        }
        private bool IsValidEmail(string email)
        {
            // Define a expressão regular para validar um endereço de e-mail
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Cria um objeto Regex com a expressão regular
            Regex regex = new Regex(pattern);

            // Usa o método Match para verificar se o email corresponde ao padrão
            return regex.IsMatch(email);
        }

        private void PhoneNumberSignUp_TextChanged(object sender, EventArgs e)
        {

        }

    }
}


