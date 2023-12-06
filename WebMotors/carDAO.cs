using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebMotors
{
        public class CarDAO
        {

            public List<Car> SelectCars()
                {
                Connection conn = new Connection();
                SqlCommand sqlCom = new SqlCommand();

                sqlCom.Connection = conn.ReturnConnection();
                sqlCom.CommandText = "SELECT Plate, Color, Brand, Model, Year FROM Cars";

                List<Car> Cars = new List<Car>();
                try
                {
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                    while (dr.Read())
                    {
                        Car cars = new Car(
                        (string)dr["Id"],
                        (string)dr["Plate"],
                        (string)dr["Color"],
                        (string)dr["Brand"],
                        (string)dr["Model"],
                        (string)dr["Year"]
                        );
                        Car.Add(cars);
                    }

                    dr.Close();
                    return Cars;
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

        public void AddCar(Car car)
            {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            string query = "INSERT INTO Cars (Plate, Color, Brand, Model, Year) VALUES (@Plate, @Color, @Brand, @Model, @Year)";
                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@Plate", car.Plate);
                command.Parameters.AddWithValue("@Color", car.Color);
                command.Parameters.AddWithValue("@Brand", car.Brand);
                command.Parameters.AddWithValue("@Model", car.Model);
                command.Parameters.AddWithValue("@Year", car.Year);

                command.ExecuteNonQuery();

                conn.Close();
            }

            public void UpdateCar(Car car)
            {
                conn.Open();

                string query = "UPDATE Cars SET Plate = @Plate, Color = @Color, Brand = @Brand, Model = @Model, Year = @Year WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@Id", car.Id);
                command.Parameters.AddWithValue("@Plate", car.Plate);
                command.Parameters.AddWithValue("@Color", car.Color);
                command.Parameters.AddWithValue("@Brand", car.Brand);
                command.Parameters.AddWithValue("@Model", car.Model);
                command.Parameters.AddWithValue("@Year", car.Year);

                command.ExecuteNonQuery();

                conn.Close();
            }

            public void DeleteCar(int id)
            {
                conn.Open();

                string query = "DELETE FROM Cars WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();

                conn.Close();
            }
        }


        public class ListViewUpdater
        {
            public void UpdateListView()
            {
                // Your code to update the ListView goes here.
            }
        }
    }



