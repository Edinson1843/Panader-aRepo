using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    class DB_Connection
    {
        static void Main(string[] args)
        {
            SqlConnection connection = Connection.GetConnection();
            Connection.CloseConnection(connection);
            Console.ReadLine();
        }
    }
}