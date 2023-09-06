using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotors
{
    internal class Connection
    {
        //Propriedades ou atributos
        private readonly SqlConnection con;
        private readonly string DataBase = "RevendaDeCarros_Will";

        //Construtor
        public Connection() //LAB01-PC17\SQLEXPRESS
        {
            //Data Source=LAB01-PC17\SQLEXPRESS;Initial Catalog=RevendaDeCarros_Will;Integrated Security=True
            string stringConnection = @"Data Source="
                    + Environment.MachineName +
                    @"\SQLEXPRESS;Initial Catalog=" +
                    DataBase + ";Integrated Security=true";

            con = new SqlConnection(stringConnection);
            con.Open();   //Abrir a conexão com o banco de dados
        }
        //Tenta fechar a conexão com o banco
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        //Retorna a conexão que foi aberta
        public SqlConnection ReturnConnection()
        {
            return con;
        }

    }
}


