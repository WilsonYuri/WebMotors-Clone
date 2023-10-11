using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WebMotors
{
    internal class UserDAO
    {
        public void DeleteUser(int Id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM SignUp_Info WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
                MessageBox.Show("Usuário deletado");
            }
        }
        public void UpdateUser()
        {

        }

        public bool IsValidEmail(string email)
        {
            // Define a expressão regular para validar um endereço de e-mail
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Cria um objeto Regex com a expressão regular
            Regex regex = new Regex(pattern);

            // Usa o método Match para verificar se o email corresponde ao padrão
            return regex.IsMatch(email);
        }

        public void InsertUser(User user)
        {
            string email = user.Email;

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO SignUp_Info VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password, @CPF, @DateOfBirth)";

            sqlCommand.Parameters.AddWithValue("@FirstName", user.Firstname);
            sqlCommand.Parameters.AddWithValue("@LastName", user.Lastname);
            sqlCommand.Parameters.AddWithValue("@Email", user.Email);
            sqlCommand.Parameters.AddWithValue("@Password", user.PassWord);
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@CPF", user.Cpf);
            sqlCommand.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);

            if (IsValidEmail(email))
            {
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("O endereço de e - mail é inválido");

            }

        }

        public List <User> SelectUser()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT Id, FirstName, LastName, Email, PhoneNumber, CPF, DateOfBirth FROM SignUp_Info";

            List <User> Users;

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    User user = new User(
                        (string)dr["Id"],
                        (string)dr["FirstName"],
                        (string)dr["LastName"],
                        (string)dr["Email"],
                        (string)dr["PhoneNumber"],
                        (string)dr["CPF"],
                        (DateTime)dr["DateOfBirth"]
                        );


                }
                dr.Close();

                return Users;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return null;
        }
    }
}
