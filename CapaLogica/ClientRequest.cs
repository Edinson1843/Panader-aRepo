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

        public static bool AddClient(string id, string nombre, string apellido, string telefono)
        {
            try
            {
                using (SqlConnection connection = Connection.GetConnection())
                {
                    string query = "INSERT INTO Cliente (id, nombre, apellido, telefono) VALUES (@id, @nombre, @apellido, @telefono)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@telefono", telefono);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar el cliente: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateClient(string id, string nuevoNombre, string nuevoApellido, string nuevoTelefono)
        {
            try
            {
                using (SqlConnection connection = Connection.GetConnection())
                {
                    string query = "UPDATE Cliente SET nombre = @nuevoNombre, apellido = @nuevoApellido, telefono = @nuevoTelefono WHERE id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
                    command.Parameters.AddWithValue("@nuevoApellido", nuevoApellido);
                    command.Parameters.AddWithValue("@nuevoTelefono", nuevoTelefono);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el cliente: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteClient(string id)
        {
            try
            {
                using (SqlConnection connection = Connection.GetConnection())
                {
                    string query = "DELETE FROM Cliente WHERE id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el cliente: " + ex.Message);
                return false;
            }
        }
    }
}