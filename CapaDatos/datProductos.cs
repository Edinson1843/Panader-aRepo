using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datProductos
    {
        //Esto se coloca en cada clase dat
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProductos _instancia = new datProductos();
        //privado para evitar la instanciación directa
        public static datProductos Instancia
        {
            get
            {
                return datProductos._instancia;
            }
        }
        #endregion singleton
        //Esto se coloca en cada clase dat

        #region metodos
        ////////////////////listado de Clientes
        public List<entStock> ListarProductos()
        {
            SqlCommand cmd = null;
            List<entStock> producto = new List<entStock>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarStock", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        entStock Cli = new entStock();
                        Cli.id_producto = dr["id_producto"].ToString();
                        Cli.nombrepro = dr["nombrepro"].ToString();
                        Cli.cantidad = Convert.ToInt32(dr["cantidad"]);
                        producto.Add(Cli);
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
            return producto;
        }
        #endregion metodos
    }
}
