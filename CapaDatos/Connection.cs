using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private const string connectionString = @"Data Source=DESKTOP-EH3FVT3\SQLEXPRESS;Initial Catalog=BD_Panaderia;Integrated Security=True";
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
