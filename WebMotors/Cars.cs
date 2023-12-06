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
    public partial class Cars : Form
    {
        public int Id;

        public Cars()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAddPanel_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
            btnSubmitAddCar.Visible = true;
            btnEditCar.Visible = false;
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ListViewDoubleClick(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
            btnEditCar.Visible = true;

            int index;
            try
            {
                index = listView1.FocusedItem.Index;
                Id = int.Parse(listView1.Items[index].SubItems[0].Text);
                textBoxPlate.Text = listView1.Items[index].SubItems[1].Text;
                textBoxColor.Text = listView1.Items[index].SubItems[2].Text;
                textBoxBrand.Text = listView1.Items[index].SubItems[3].Text;
                textBoxModel.Text = listView1.Items[index].SubItems[4].Text;
                textBoxYear.Text = listView1.Items[index].SubItems[4].Text;

            }
            catch (Exception i)

            {
                MessageBox.Show(i.Message);
            }
        }

        private void btnSubmitAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(textBoxPlate.Text, textBoxColor.Text, textBoxBrand.Text, textBoxModel.Text, textBoxYear.Text);

                UserDAO userdao = new UserDAO();
                userdao.InsertCar(user);

                MessageBox.Show("Cadastro concluido com sucesso!");
                UpdateListView();
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        

        panelAdd.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void UpdateListView()
        {
            listView1.Items.Clear();
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            UserDAO userDAO = new UserDAO();
            List<User> user = userDAO.SelectUser();

            try
            {
                foreach (User users in user)
                {
                    ListViewItem lv = new ListViewItem(users.ID.ToString());
                    lv.SubItems.Add(users.Plate);
                    lv.SubItems.Add(users.Color);
                    lv.SubItems.Add(users.Brand);
                    lv.SubItems.Add(users.Model);
                    lv.SubItems.Add(users.Year);
                    listView1.Items.Add(lv);
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

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(textBoxPlate.Text, textBoxColor.Text, textBoxBrand.Text, textBoxModel.Text, textBoxYear.Text);

                UserDAO userdao = new UserDAO();
                userdao.UpdateCar(user);
            }

            catch (Exception error)
            {
                MessageBox.Show("Cadastro alterado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


            textBoxPlate.Clear();
            textBoxColor.Clear();
            textBoxBrand.Clear();
            textBoxModel.Clear();
            textBoxYear.Clear();
            UpdateListView();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
