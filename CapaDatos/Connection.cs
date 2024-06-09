using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Connection
    {
        //Se debe actualizar el string @"Data Source=NOMBRE;Initial Catalog=BD_Panaderia;Integrated Security=True"
        //Donde NOMBRE es el nombre de la computadora donde se encuentra la base de datos
        private const string connectionString = @"Data Source=DESKTOP-JF8U25F;Initial Catalog=BD_Panaderia;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Conexión exitosa.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
            return connection;
        }

        public static void CloseConnection(SqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Conexión cerrada.");
            }
        }
    }
}