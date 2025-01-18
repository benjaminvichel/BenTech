using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace BenTech
{
    class DatabaseConnection
    {
        private readonly string connectionString;
        MySqlConnection connection;

        public DatabaseConnection()
        {
            // Lê a string de conexão do app.config
            connectionString = ConfigurationManager.ConnectionStrings["PousadaConnection"].ConnectionString;
        }
        public MySqlConnection ConnectToDatabase()
        {

            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Conexão com banco de dados bem-sucedida!");
                return connection;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                return null;
            }


        }
    }
}
