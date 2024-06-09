using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        private const string connectionString = @"Data Source=DESKTOP-LL44DJ3;Initial Catalog=BD_Panaderia;Integrated Security=True";
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return _instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection(connectionString);
            return cn;
        }
    }
}

namespace CapaAccesoDatos
{
    public class DatCliente
    {
        private static readonly DatCliente _instancia = new DatCliente();
        public static DatCliente Instancia
        {
            get { return _instancia; }
        }

        public List<EntCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<EntCliente> lista = new List<EntCliente>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarCliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntCliente Cli = new EntCliente();
                        Cli.Id = dr["id"].ToString();
                        Cli.Nombre = dr["nombre"].ToString();
                        Cli.Apellido = dr["apellido"].ToString();
                        Cli.Telefono = dr["telefono"].ToString();
                        lista.Add(Cli);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean InsertarCliente(EntCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            SqlConnection cn = null;
            try
            {
                cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Cli.Id);
                cmd.Parameters.AddWithValue("@nombre", Cli.Nombre);
                cmd.Parameters.AddWithValue("@apellido", Cli.Apellido);
                cmd.Parameters.AddWithValue("@telefono", Cli.Telefono);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    inserta = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }
            return inserta;
        }

        public Boolean EditarCliente(EntCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEditarCliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", Cli.Id);
                    cmd.Parameters.AddWithValue("@nombre", Cli.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", Cli.Apellido);
                    cmd.Parameters.AddWithValue("@telefono", Cli.Telefono);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
            return edita;
        }
        /*
        public Boolean EliminarCliente(string Id)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarCliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", Id);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
            return delete;
        }
        */
    }
}