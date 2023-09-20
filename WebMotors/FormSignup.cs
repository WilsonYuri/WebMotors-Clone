using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WebMotors
{
    public partial class FormSignup : Form
    {
        private int Id;


        private bool created = false;
        public FormSignup()
        {
            InitializeComponent();
            Overview.Visible = false;
            PasswordPanel.Visible = false;
            ManagementLabel.Visible = false;
            btnManage.Visible = false;
            // --
            SignInLabel.Visible = true;
            FirstNameSignUp.Visible = true;
            labelFirstName.Visible = true;
            FirstNameSignUp.Visible = true;
            labelLastName.Visible = true;
            LastNameSignUp.Visible = true;
            EmailLogin.Visible = true;
            EmailSignUp.Visible = true;
            PasswordLogin.Visible = true;
            PasswordSignUp.Visible = true;
            PhoneNumber.Visible = true;
            PhoneNumberSignUp.Visible = true;
            labelCPF.Visible = true;
            CPFSignUp.Visible = true;
            labelBirth.Visible = true;
            DateOfBirthSignUp.Visible = true;
            Submit.Visible = true;
        }

        public bool Created
        {
            get { return created; }
            set { created = value; }
        }



        private void FormSignup_Load(object sender, EventArgs e)
        {

            UpdateListView();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpdateListView()
        {
            Overview.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT Id, FirstName, LastName, Email, PhoneNumber, CPF, DateOfBirth FROM SignUp_Info";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["id"];
                    string FirstName = (string)dr["FirstName"];
                    string LastName = (string)dr["LastName"];
                    string Email = (string)dr["Email"];
                    string PhoneNumber = (string)dr["PhoneNumber"];
                    string CPF = (string)dr["CPF"];
                    DateTime DateOfBirth = (DateTime)dr["DateOfBirth"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(FirstName);
                    lv.SubItems.Add(LastName);
                    lv.SubItems.Add(Email);
                    lv.SubItems.Add(PhoneNumber);
                    lv.SubItems.Add(CPF);
                    lv.SubItems.Add(DateOfBirth.ToShortDateString());
                    Overview.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PasswordPanel.Visible = true;
            btnManage.Visible = true;

            //-- 

            SignInLabel.Visible = false;
            FirstNameSignUp.Visible = false;
            labelFirstName.Visible = false;
            FirstNameSignUp.Visible = false;
            labelLastName.Visible = false;
            LastNameSignUp.Visible = false;
            EmailLogin.Visible = false;
            EmailSignUp.Visible = false;
            PasswordLogin.Visible = false;
            PasswordSignUp.Visible = false;
            PhoneNumber.Visible = false;
            PhoneNumberSignUp.Visible = false;
            labelCPF.Visible = false;
            CPFSignUp.Visible = false;
            labelBirth.Visible = false;
            DateOfBirthSignUp.Visible = false;
            Submit.Visible = false;
        }

        private void FirstNameSignUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            string login = PasswordManagement.Text;
            if (login == "12345678")
            {
                Overview.Visible = true;
                btnManage.Visible = true;
                PasswordPanel.Visible = false;
                ManagementLabel.Visible = true;
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Overview.Visible = false;
            PasswordPanel.Visible = true;
            ManagementLabel.Visible = false;
            // --
            SignInLabel.Visible = true;
            FirstNameSignUp.Visible = true;
            labelFirstName.Visible = true;
            FirstNameSignUp.Visible = true;
            labelLastName.Visible = true;
            LastNameSignUp.Visible = true;
            EmailLogin.Visible = true;
            EmailSignUp.Visible = true;
            PasswordLogin.Visible = true;
            PasswordSignUp.Visible = true;
            PhoneNumber.Visible = true;
            PhoneNumberSignUp.Visible = true;
            labelCPF.Visible = true;
            CPFSignUp.Visible = true;
            labelBirth.Visible = true;
            DateOfBirthSignUp.Visible = true;
            Submit.Visible = true;

            Overview.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"UPDATE SignUp_Info SET   
             FirstName = @FirstName,
             LastName = @LastName, 
             Email = @Email,
             Password = @Password, 
             PhoneNumber = @PhoneNumber, 
             CPF = @CPF, 
             DateOfBirth = @DateOfBirth,
             WHERE id = @id";

            sqlCom.Parameters.AddWithValue("@FirstName", FirstNameSignUp.Text);
            sqlCom.Parameters.AddWithValue("@LastName", LastNameSignUp.Text);
            sqlCom.Parameters.AddWithValue("@Email", EmailSignUp.Text);
            sqlCom.Parameters.AddWithValue("@Password", PasswordSignUp.Text);
            sqlCom.Parameters.AddWithValue("@PhoneNumber", PhoneNumberSignUp.Text);
            sqlCom.Parameters.AddWithValue("@CPF", CPFSignUp.Text);
            sqlCom.Parameters.AddWithValue("@DateOfBirth", DateOfBirthSignUp.Value);
            sqlCom.Parameters.AddWithValue("@id", Id);

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["id"];
                    string FirstName = (string)dr["FirstName"];
                    string LastName = (string)dr["LastName"];
                    string Email = (string)dr["Email"];
                    string PhoneNumber = (string)dr["PhoneNumber"];
                    string CPF = (string)dr["CPF"];
                    DateTime DateOfBirth = (DateTime)dr["DateOfBirth"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(FirstName);
                    lv.SubItems.Add(LastName);
                    lv.SubItems.Add(Email);
                    lv.SubItems.Add(PhoneNumber);
                    lv.SubItems.Add(CPF);
                    lv.SubItems.Add(DateOfBirth.ToShortDateString());
                    Overview.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro "+ err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void Overview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = Overview.FocusedItem.Index;
                Id = int.Parse(Overview.Items[index].SubItems[0].Text);
                FirstNameSignUp.Text = Overview.Items[index].SubItems[1].Text;
                LastNameSignUp.Text = Overview.Items[index].SubItems[2].Text;
                EmailSignUp.Text = Overview.Items[index].SubItems[3].Text;
                PasswordSignUp.Text = Overview.Items[index].SubItems[4].Text;
                PhoneNumberSignUp.Text = Overview.Items[index].SubItems[5].Text;
                CPFSignUp.Text = Overview.Items[index].SubItems[6].Text;
                DateOfBirthSignUp.Value = Convert.ToDateTime(Overview.Items[index].SubItems[7].Text);

            }
            catch
            {
                MessageBox.Show("Error");
            }
    }
    }
}




