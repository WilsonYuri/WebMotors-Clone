using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WebMotors
{
    internal class UserDAO
    {

        public static bool IsCpf(string detectCpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            detectCpf = detectCpf.Trim();
            detectCpf = detectCpf.Replace(".", "").Replace("-", "");
            if (detectCpf.Length != 11)
                return false;
            tempCpf = detectCpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return detectCpf.EndsWith(digito);
        }


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
        public bool IsValidPassword(string password)
        {
            // Validate strong password
            string passwordPattern = ("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$");

            Regex validatePassword = new Regex(passwordPattern);

            return validatePassword.IsMatch(password);
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
            string CPF = user.Cpf;
            string password = user.PassWord;

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


            if (IsValidEmail(email) == true)
            {
                if (IsValidPassword(password) == true)
                { 
                
                    if (IsCpf(CPF) == true)
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("O endereço de e - mail é inválido");
                    }
                }
                else
                {
                    MessageBox.Show("A senha é inválida");
                }
            }
            else
            {
                MessageBox.Show("O CPF é inválido");
            };



        }

        public List<User> SelectUser()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT FirstName, LastName, Email, PhoneNumber, Password, CPF, DateOfBirth";

            List<User> Users = new List<User>();
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
                    Users.Add(user);
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
        
        
    

