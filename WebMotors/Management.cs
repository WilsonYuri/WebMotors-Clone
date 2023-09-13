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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
            Overview.Visible = false;
            PasswordPanel.Visible = true;
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



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Management_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string login = PasswordManagement.Text;
            if (login == "12345678")
            {
                Overview.Visible = true;
                PasswordPanel.Visible = false;
            }
        }

        private void PasswordPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
