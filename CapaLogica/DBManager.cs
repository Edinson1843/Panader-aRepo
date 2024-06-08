using System;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaLogica
{
    public class DB_Manager
    {
        public static bool ManageConnection()
        {
            try
            {
                using (SqlConnection connection = Connection.GetConnection())
                {
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return false;
            }
        }
    }
}