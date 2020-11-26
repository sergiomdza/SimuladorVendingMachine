using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CajeroAutomático
{
    public class DBManager
    {
        MySqlConnection connection;
        private static DBManager instancia;

        private DBManager()
        {
            string connectionString = "Server=localhost;Database=vending_machine;Uid=root;Pwd=2212;";
            connection = new MySqlConnection(connectionString);
        }

        public static DBManager GetInstance()
        {
            if(instancia == null)
            {
                instancia = new DBManager();
            }
            return instancia;

        }
        public List<List<string>> GetProducts()
        {
            DataTable dataTableProductos = null;
            List<List<string>> dataProducts = new List<List<string>>();
            string query = "SELECT * FROM producto";

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter dataAdapterProducts = new MySqlDataAdapter(command);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    dataProducts.Add(
                        new List<string>
                        {
                            dataReader.GetString("codigo"),
                            dataReader.GetString("nombre"),
                            dataReader.GetString("costo"),                            
                        }
                    );
                }

                dataReader.Close();

                dataTableProductos = new DataTable();
                dataAdapterProducts.Fill(dataTableProductos);

                connection.Close();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Print(e.Message);
            }

            return dataProducts;
        }

        public void insertTransaccion(string experiencia, int costo)
        {
            string query = string.Format($"INSERT INTO transaccion (experiencia, costo) VALUES ('{experiencia}', {costo});");

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                }

                dataReader.Close();
                connection.Close();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Print(e.Message);
            }
        }
    }
}
