using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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


        public bool IsValidAll(string password, string email)
        {
            bool EmailValidated;
            bool passWordvalidated;
            // Validate strong password
            string passwordPattern = @"^(?=.*[A-Za-z])[A-Za-z]{8,}$";

            Regex validatePassword = new Regex(passwordPattern);

            if ((validatePassword.IsMatch(password)) == true)
            {
                passWordvalidated = true;
            }
            else
            {
                passWordvalidated = false;
            }

            string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex validateEmail = new Regex(EmailPattern);
            if ((validateEmail.IsMatch(email)) == true)
            {
                EmailValidated = true;
            }
            else
            {
                EmailValidated = false;
            }

            if ((EmailValidated == true) || (passWordvalidated == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public bool IsValidPhoneNumber(string phoneNumber)
        //{
        //    // Validate strong password
        //    string PhoneNumberPattern = ('/^(?:(?:\+|00)?(55)\s?)?(?:\(?([1-9][0-9])\)?\s?)?(?:((?:9\d|[2-9])\d{3})\-?(\d{4}))$/');


        //    Regex PhoneNumberRegex = new Regex(PhoneNumberPattern);

        //    return PhoneNumberRegex.IsMatch(phoneNumber);
        //}

        //public bool IsValidEmail(string email)

        // Define a expressão regular para validar um endereço de e-mail

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

        public void UpdateUser(User user)
        {
            string email = user.Email;
            string CPF = user.Cpf;
            string password = user.PassWord;

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE SignUp_Info SET   
            FirstName = @FirstName,
            LastName = @LastName, 
            Email = @Email,
            Password = @Password, 
            PhoneNumber = @PhoneNumber, 
            CPF = @CPF, 
             DateOfBirth = @DateOfBirth
             WHERE id = @id";

            sqlCommand.Parameters.AddWithValue("@FirstName", user.Firstname);
            sqlCommand.Parameters.AddWithValue("@LastName", user.Lastname);
            sqlCommand.Parameters.AddWithValue("@Email", user.Email);
            sqlCommand.Parameters.AddWithValue("@Password", user.PassWord);
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@CPF", user.Cpf);
            sqlCommand.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);


            if (IsValidAll(password, email) == true)
            {
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Password and/or email is invalid!");
            };
        }



        public void InsertUser(User user)
        {
            Criptografia cripto = new Criptografia();

            string email = user.Email;
            string CPF = user.Cpf;
            string password = user.PassWord;
            string phoneNumber = user.PhoneNumber;

            string senhaCriptografada = cripto.CriptografarSenha(password);

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO SignUp_Info VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password, @CPF, @DateOfBirth)";

            sqlCommand.Parameters.AddWithValue("@FirstName", user.Firstname);
            sqlCommand.Parameters.AddWithValue("@LastName", user.Lastname);

            if ((IsValidAll(password, email) == true) || (IsCpf(CPF) == true))
            {
                sqlCommand.Parameters.AddWithValue("@Email", user.Email);
                sqlCommand.Parameters.AddWithValue("@Password", senhaCriptografada);
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", (user.PhoneNumber));
                sqlCommand.Parameters.AddWithValue("@CPF", user.Cpf);
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("The Email, Password or CPF is invalid");
            };
        }

        public User LoginUser(string email, string senha)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"SELECT * FROM SignUp_Info WHERE email = @Email AND password = @Password";

            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Password", senha);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    User user = new User("FirstName", "LastName", "Email", "PhoneNumber", "Password", "CPF", DateTime.Parse("DateOfBirth"))
                    {
                        Firstname = reader.GetString(0),
                        Lastname = reader.GetString(1),
                        Email = reader.GetString(2),
                        PhoneNumber = reader.GetString(3),
                        PassWord = reader.GetString(4),
                        Cpf = reader.GetString(5),
                        DateOfBirth = reader.GetDateTime(6)
                    };
                    return user;
                }
            }
            return null;

        }


        public List<User> SelectUser()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT FirstName, LastName, Email, PhoneNumber, Password, CPF, DateOfBirth FROM Signup_info";

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
        public List<User> SelectCar()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT Plate, Color, Brand, Model, Year FROM Cars";

            List<User> Users = new List<User>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();
                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    User user = new User(
                    (string)dr["Plate"],
                    (string)dr["Color"],
                    (string)dr["Brand"],
                    (string)dr["Model"],
                    (string)dr["Year"]
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

        public void InsertCar(User user)
        {

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Cars VALUES (@Plate, @Color, @Brand, @Model, @Year)";

            sqlCommand.Parameters.AddWithValue("@Plate", user.Plate);
            sqlCommand.Parameters.AddWithValue("@Color", user.Color);
            sqlCommand.Parameters.AddWithValue("@Brand", user.Brand);
            sqlCommand.Parameters.AddWithValue("@Model", user.Model);
            sqlCommand.Parameters.AddWithValue("@Year", user.Year);
            sqlCommand.ExecuteNonQuery();
        }

        public void UpdateCar(User user)
        {

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Cars SET   
            @Plate, @Color, @Brand, @Model, @Year WHERE id = @id";

            sqlCommand.Parameters.AddWithValue("@Plate", user.Plate);
            sqlCommand.Parameters.AddWithValue("@Color", user.Color);
            sqlCommand.Parameters.AddWithValue("@Brand", user.Brand);
            sqlCommand.Parameters.AddWithValue("@Model", user.Model);
            sqlCommand.Parameters.AddWithValue("@Year", user.Year);
            sqlCommand.ExecuteNonQuery();
        }

        public void DeleteCar(int Id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Cars WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir carro no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
                MessageBox.Show("Carro deletado");
            }
        }

    }
}



