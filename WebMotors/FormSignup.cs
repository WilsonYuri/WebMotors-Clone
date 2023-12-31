﻿using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
//using System.IdentityModel;

namespace WebMotors
{
    public partial class FormSignup : Form
    {
        public int Id;


        //private bool created = false;
        public FormSignup()
        {
            InitializeComponent();
            Overview.Visible = false;
            PasswordPanel.Visible = false;
            ManagementLabel.Visible = false;
            btnManage.Visible = false;
            btn_Submit_Edit.Visible = false;
            btn_delete.Visible = false;
            btnGerarPdf.Visible = false;
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

        //public bool Created
        //{
        //    get { return created; }
        //    set { created = value; }
        //}

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

        public void UpdateListView()
        {
            Overview.Items.Clear();
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            UserDAO userDAO = new UserDAO();
            List<User> user = userDAO.SelectUser();

            try
            {
                foreach (User userItem in user)
                {
                    ListViewItem lv = new ListViewItem(userItem.ID.ToString());
                    lv.SubItems.Add(userItem.Firstname);
                    lv.SubItems.Add(userItem.Lastname);
                    lv.SubItems.Add(userItem.Email);
                    lv.SubItems.Add(userItem.PhoneNumber);
                    lv.SubItems.Add(userItem.Cpf);
                    lv.SubItems.Add(userItem.DateOfBirth.ToShortDateString());
                    Overview.Items.Add(lv);
                }
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
            try
            {
                User user = new User(FirstNameSignUp.Text, LastNameSignUp.Text, EmailSignUp.Text, PhoneNumberSignUp.Text, PasswordSignUp.Text, CPFSignUp.Text, DateOfBirthSignUp.Value);

                UserDAO userdao = new UserDAO();
                userdao.InsertUser(user);

                MessageBox.Show("Cadastro concluido com sucesso!");
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

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
            btn_delete.Visible = false;
            btn_Submit_Edit.Visible = false;
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
                btnGerarPdf.Visible = true;

            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Overview.Visible = false;
            PasswordPanel.Visible = false;
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
            btn_Submit_Edit.Visible = true;

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
             DateOfBirth = @DateOfBirth
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
                MessageBox.Show("Erro " + err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void Overview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Overview.Visible = false;
            PasswordPanel.Visible = false;
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
            btn_Submit_Edit.Visible = true;
            btn_delete.Visible = true;

            int index;
            try
            {
                index = Overview.FocusedItem.Index;
                Id = int.Parse(Overview.Items[index].SubItems[0].Text);
                FirstNameSignUp.Text = Overview.Items[index].SubItems[1].Text;
                LastNameSignUp.Text = Overview.Items[index].SubItems[2].Text;
                EmailSignUp.Text = Overview.Items[index].SubItems[3].Text;
                //PasswordSignUp.Text = Overview.Items[index].SubItems[4].Text;
                PhoneNumberSignUp.Text = Overview.Items[index].SubItems[4].Text;
                CPFSignUp.Text = Overview.Items[index].SubItems[5].Text;
                DateOfBirthSignUp.Value = Convert.ToDateTime(Overview.Items[index].SubItems[6].Text);

            }
            catch (Exception i)

            {
                MessageBox.Show(i.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Overview.Visible = false;

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

        private void Overview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(FirstNameSignUp.Text, LastNameSignUp.Text, EmailSignUp.Text, PasswordSignUp.Text, PhoneNumberSignUp.Text, CPFSignUp.Text, DateOfBirthSignUp.Value);

                UserDAO userdao = new UserDAO();
                userdao.UpdateUser(user);
            }

            catch (Exception error)
            {
                MessageBox.Show("Cadastro alterado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            //Connection connection = new Connection();
            //SqlCommand sqlCommand = new SqlCommand();

            //sqlCommand.Connection = connection.ReturnConnection();
            //sqlCommand.CommandText = @"UPDATE SignUp_Info SET   
            // FirstName = @FirstName,
            // LastName = @LastName, 
            // Email = @Email,
            // Password = @Password, 
            // PhoneNumber = @PhoneNumber, 
            // CPF = @CPF, 
            // DateOfBirth = @DateOfBirth
            // WHERE id = @id";

            //sqlCommand.Parameters.AddWithValue("@FirstName", FirstNameSignUp.Text);
            //sqlCommand.Parameters.AddWithValue("@LastName", LastNameSignUp.Text);
            //sqlCommand.Parameters.AddWithValue("@Email", EmailSignUp.Text);
            //sqlCommand.Parameters.AddWithValue("@Password", PasswordSignUp.Text);
            //sqlCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumberSignUp.Text);
            //sqlCommand.Parameters.AddWithValue("@CPF", CPFSignUp.Text);
            //sqlCommand.Parameters.AddWithValue("@DateOfBirth", DateOfBirthSignUp.Value);
            //sqlCommand.Parameters.AddWithValue("@id", Id);

            //sqlCommand.ExecuteNonQuery();


            FirstNameSignUp.Clear();
            LastNameSignUp.Clear();
            EmailSignUp.Clear();
            PasswordSignUp.Clear();
            PhoneNumberSignUp.Clear();
            CPFSignUp.Clear();

            UpdateListView();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            Overview.Visible = true;
            btn_delete.Visible = false;

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
            btn_Submit_Edit.Visible = false;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            userDAO.DeleteUser(Id);

            UpdateListView();

            FirstNameSignUp.Clear();
            LastNameSignUp.Clear();
            EmailSignUp.Clear();
            PasswordSignUp.Clear();
            PhoneNumberSignUp.Clear();
            CPFSignUp.Clear();
        }

        private void PasswordManagement_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Connection connect = new Connection();
            SqlConnection connection = connect.ReturnConnection();

            string query = "SELECT * FROM SignUp_Info WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);

            //command.Parameters.AddWithValue("@ID", user.ID);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            Document document = new Document();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            PdfWriter.GetInstance(document, new FileStream(path + "/Relatorio.pdf", FileMode.Create));

            document.Open();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    document.Add(new Paragraph(row[column].ToString()));
                }
            }
            document.Close();
            connect.CloseConnection();

            MessageBox.Show("Relatório gerado com sucesso!");
        }

        private void ManagementLabel_Click(object sender, EventArgs e)
        {

        }
    }
}




