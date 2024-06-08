using System;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaLogica
{
    public class ClientRequest
    {
        public static DataTable GetClientes()
        {
            try
            {
                using (SqlConnection connection = Connection.GetConnection())
                {
                    string query = "SELECT id, nombre, apellido, telefono FROM Cliente";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al recuperar los datos de los clientes: " + ex.Message);
                return new DataTable();
            }
        }
    }
}