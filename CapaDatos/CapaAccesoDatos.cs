using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        //private const string connectionString = @"Data Source=DESKTOP-LL44DJ3;Initial Catalog=BD_Pan;Integrated Security=True"; //Batu
        private const string connectionString = @"Data Source=LAPTOP-L4A84CUQ\SQLEXPRESS;Initial Catalog=BD_Pan;Integrated Security=True"; //Clipper
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
                        EntCliente cli = new EntCliente();
                        cli.ClienteID = (int)dr["ClienteID"];
                        cli.Nombre = dr["nombre"].ToString();
                        cli.Apellido = dr["apellido"].ToString();
                        cli.DNI = (int)dr["dni"];
                        cli.Telefono = dr["telefono"].ToString();
                        cli.Estado = (int)dr["estado"];
                        cli.Direccion = dr["direccion"].ToString();
                        lista.Add(cli);
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

        public bool RegistrarCliente(EntCliente cli)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spRegistrarCliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", cli.Apellido);
                    cmd.Parameters.AddWithValue("@dni", cli.DNI);
                    cmd.Parameters.AddWithValue("@telefono", cli.Telefono);
                    cmd.Parameters.AddWithValue("@estado", cli.Estado);
                    cmd.Parameters.AddWithValue("@direccion", cli.Direccion);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public bool EliminarCliente(int clienteID)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarCliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public EntCliente BuscarCliente(int clienteID)
        {
            SqlCommand cmd = null;
            EntCliente cli = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spBuscarCliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        cli = new EntCliente();
                        cli.ClienteID = (int)dr["ClienteID"];
                        cli.Nombre = dr["nombre"].ToString();
                        cli.Apellido = dr["apellido"].ToString();
                        cli.DNI = (int)dr["dni"];
                        cli.Telefono = dr["telefono"].ToString();
                        cli.Estado = (int)dr["estado"];
                        cli.Direccion = dr["direccion"].ToString();
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
            return cli;
        }
        public EntCliente BuscarClientePorID(int clienteID)
        {
            SqlCommand cmd = null;
            EntCliente cli = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("BuscarClientePorID", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", clienteID);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        cli = new EntCliente();
                        cli.ClienteID = (int)dr["ClienteID"];
                        cli.Nombre = dr["nombre"].ToString();
                        cli.Apellido = dr["apellido"].ToString();
                        cli.DNI = (int)dr["dni"];
                        cli.Telefono = dr["telefono"].ToString();
                        cli.Estado = (int)dr["estado"];
                        cli.Direccion = dr["direccion"].ToString();
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
            return cli;
        }
        public EntCliente BuscarClientePorDNI(string dniCliente)
        {
            SqlCommand cmd = null;
            EntCliente cli = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("BuscarClientePorDNI", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DNI", dniCliente);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        cli = new EntCliente();
                        cli.ClienteID = (int)dr["ClienteID"];
                        cli.Nombre = dr["nombre"].ToString();
                        cli.Apellido = dr["apellido"].ToString();
                        cli.DNI = (int)dr["dni"];
                        cli.Telefono = dr["telefono"].ToString();
                        cli.Estado = (int)dr["estado"];
                        cli.Direccion = dr["direccion"].ToString();
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
            return cli;
        }
    }

    public class DatContrato
    {
        private static readonly DatContrato _instancia = new DatContrato();

        public static DatContrato Instancia
        {
            get { return _instancia; }
        }

        public List<EntContrato> ListarContrato()
        {
            SqlCommand cmd = null;
            List<EntContrato> lista = new List<EntContrato>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarContrato", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntContrato contrato = new EntContrato();
                        contrato.ContratoID = (int)dr["ContratoID"];
                        contrato.Estado = (int)dr["Estado"];
                        contrato.Fecha = (DateTime)dr["Fecha"];
                        contrato.Cantidad = (int)dr["Cantidad"];
                        lista.Add(contrato);
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

        public bool RegistrarContrato(EntContrato contrato)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spRegistrarContrato", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@estado", contrato.Estado);
                    cmd.Parameters.AddWithValue("@fecha", contrato.Fecha);
                    cmd.Parameters.AddWithValue("@cantidad", contrato.Cantidad);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public bool EliminarContrato(int contratoID)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarContrato", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ContratoID", contratoID);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public EntContrato BuscarContrato(int contratoID)
        {
            SqlCommand cmd = null;
            EntContrato contrato = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spBuscarContrato", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ContratoID", contratoID);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        contrato = new EntContrato();
                        contrato.ContratoID = (int)dr["ContratoID"];
                        contrato.Estado = (int)dr["Estado"];
                        contrato.Fecha = (DateTime)dr["Fecha"];
                        contrato.Cantidad = (int)dr["Cantidad"];
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
            return contrato;
        }
    }

    public class DatContratoCliente
    {
        private static readonly DatContratoCliente _instancia = new DatContratoCliente();

        public static DatContratoCliente Instancia
        {
            get { return _instancia; }
        }

        public List<EntContratoCliente> ListarContratoCliente()
        {
            SqlCommand cmd = null;
            List<EntContratoCliente> lista = new List<EntContratoCliente>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarContratoCliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntContratoCliente contratoCliente = new EntContratoCliente();
                        contratoCliente.ClienteID = (int)dr["ClienteID"];
                        contratoCliente.ContratoID = (int)dr["ContratoID"];
                        lista.Add(contratoCliente);
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

        public bool RegistrarContratoCliente(int clienteID, int contratoID)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spRegistrarContratoCliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                    cmd.Parameters.AddWithValue("@ContratoID", contratoID);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public bool EliminarContratoCliente(int clienteID, int contratoID)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarContratoCliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                    cmd.Parameters.AddWithValue("@ContratoID", contratoID);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public EntContratoCliente BuscarContratoCliente(int clienteID, int contratoID)
        {
            SqlCommand cmd = null;
            EntContratoCliente contratoCliente = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spBuscarContratoCliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                    cmd.Parameters.AddWithValue("@ContratoID", contratoID);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        contratoCliente = new EntContratoCliente();
                        contratoCliente.ClienteID = (int)dr["ClienteID"];
                        contratoCliente.ContratoID = (int)dr["ContratoID"];
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
            return contratoCliente;
        }
    }

    public class DatCronogramaPago
    {
        private static readonly DatCronogramaPago _instancia = new DatCronogramaPago();

        public static DatCronogramaPago Instancia
        {
            get { return _instancia; }
        }

        public List<EntCronogramaPago> ListarCronogramaPago()
        {
            SqlCommand cmd = null;
            List<EntCronogramaPago> lista = new List<EntCronogramaPago>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarCronogramapago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntCronogramaPago cronograma = new EntCronogramaPago();
                        cronograma.CronogramaPagoID = (int)dr["CronogramaPagoID"];
                        cronograma.ContratoID = (int)dr["ContratoID"];
                        cronograma.FechaPagos = (DateTime)dr["FechaPagos"];
                        cronograma.MetodoPago = dr["MetodoPago"].ToString();
                        lista.Add(cronograma);
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

        public bool RegistrarCronogramaPago(EntCronogramaPago cronograma)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spRegistrarCronogramapago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ContratoID", cronograma.ContratoID);
                    cmd.Parameters.AddWithValue("@FechaPagos", cronograma.FechaPagos);
                    cmd.Parameters.AddWithValue("@MetodoPago", cronograma.MetodoPago);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public bool EliminarCronogramaPago(int cronogramaPagoID)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarCronogramapago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CronogramaPagoID", cronogramaPagoID);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public EntCronogramaPago BuscarCronogramaPago(int cronogramaPagoID)
        {
            SqlCommand cmd = null;
            EntCronogramaPago cronograma = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spBuscarCronogramapago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CronogramaPagoID", cronogramaPagoID);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        cronograma = new EntCronogramaPago();
                        cronograma.CronogramaPagoID = (int)dr["CronogramaPagoID"];
                        cronograma.ContratoID = (int)dr["ContratoID"];
                        cronograma.FechaPagos = (DateTime)dr["FechaPagos"];
                        cronograma.MetodoPago = dr["MetodoPago"].ToString();
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
            return cronograma;
        }
    }

    public class DatOrdenProduccion
    {
        private static readonly DatOrdenProduccion _instancia = new DatOrdenProduccion();

        public static DatOrdenProduccion Instancia
        {
            get { return _instancia; }
        }

        public List<EntOrdenProduccion> ListarOrdenProduccion()
        {
            SqlCommand cmd = null;
            List<EntOrdenProduccion> lista = new List<EntOrdenProduccion>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarOrdenproduccion", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntOrdenProduccion orden = new EntOrdenProduccion();
                        orden.OrdenProduccionID = (int)dr["OrdenProduccionID"];
                        orden.NombreEmpleado = dr["NombreEmpleado"].ToString();
                        orden.Producto = dr["Producto"].ToString();
                        orden.Cantidad = (int)dr["Cantidad"];
                        lista.Add(orden);
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

        public bool RegistrarOrdenProduccion(EntOrdenProduccion orden)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spRegistrarOrdenproduccion", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreEmpleado", orden.NombreEmpleado);
                    cmd.Parameters.AddWithValue("@Producto", orden.Producto);
                    cmd.Parameters.AddWithValue("@Cantidad", orden.Cantidad);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public bool EliminarOrdenProduccion(int OrdenProduccionID)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarOrdenproduccion", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrdenProduccionID", OrdenProduccionID);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }
        public EntOrdenProduccion BuscarOrdenProduccion(int OrdenProduccionID)
        {
            SqlCommand cmd = null;
            EntOrdenProduccion orden = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spBuscarOrdenproduccion", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrdenProduccionID", OrdenProduccionID);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        orden = new EntOrdenProduccion();
                        orden.OrdenProduccionID = (int)dr["OrdenProduccionID"];
                        orden.NombreEmpleado = dr["NombreEmpleado"].ToString();
                        orden.Producto = dr["Producto"].ToString();
                        orden.Cantidad = (int)dr["Cantidad"];
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
            return orden;
        }
    }

    public class DatPedido
    {
        private static readonly DatPedido _instancia = new DatPedido();

        public static DatPedido Instancia
        {
            get { return _instancia; }
        }

        public List<EntPedido> ListarPedido()
        {
            SqlCommand cmd = null;
            List<EntPedido> lista = new List<EntPedido>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarPedido", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntPedido pedido = new EntPedido();
                        pedido.PedidoID = (int)dr["PedidoID"];
                        pedido.FechaEntrega = (DateTime)dr["FechaEntrega"];
                        pedido.Descripcion = dr["Descripcion"].ToString();
                        pedido.OrdenProduccionID = (int)dr["OrdenProduccionID"];
                        pedido.Cantidad = (int)dr["Cantidad"];
                        pedido.Estado = (int)dr["Estado"];
                        lista.Add(pedido);
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

        public bool RegistrarPedido(EntPedido pedido)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spRegistrarPedido", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaEntrega", pedido.FechaEntrega);
                    cmd.Parameters.AddWithValue("@Descripcion", pedido.Descripcion);
                    cmd.Parameters.AddWithValue("@OrdenProduccionID", pedido.OrdenProduccionID);
                    cmd.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);
                    cmd.Parameters.AddWithValue("@Estado", pedido.Estado);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public bool EliminarPedido(int PedidoID)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarPedido", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PedidoID", PedidoID);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public EntPedido BuscarPedido(int PedidoID)
        {
            SqlCommand cmd = null;
            EntPedido pedido = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spBuscarPedido", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PedidoID", PedidoID);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        pedido = new EntPedido();
                        pedido.PedidoID = (int)dr["PedidoID"];
                        pedido.FechaEntrega = (DateTime)dr["FechaEntrega"];
                        pedido.Descripcion = dr["Descripcion"].ToString();
                        pedido.OrdenProduccionID = (int)dr["OrdenProduccionID"];
                        pedido.Cantidad = (int)dr["Cantidad"];
                        pedido.Estado = (int)dr["Estado"];
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
            return pedido;
        }
    }
    public class DatProducto
    {
        private static readonly DatProducto _instancia = new DatProducto();

        public static DatProducto Instancia
        {
            get { return _instancia; }
        }

        public List<EntProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<EntProducto> lista = new List<EntProducto>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarProducto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntProducto producto = new EntProducto();
                        producto.ProductoID = (int)dr["ProductoID"];
                        producto.Nombre = dr["Nombre"].ToString();
                        producto.OrdenProduccionID = (int)dr["OrdenProduccionID"];
                        producto.Descripcion = dr["Descripcion"].ToString();
                        producto.PrecioUnidad = (int)dr["PrecioUnidad"];
                        producto.Cantidad = (int)dr["Cantidad"];
                        producto.Estado = (int)dr["Estado"];
                        producto.Vencimiento = (DateTime)dr["Vencimiento"];
                        lista.Add(producto);
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

        public bool RegistrarProducto(EntProducto producto)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spRegistrarProducto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@OrdenProduccionID", producto.OrdenProduccionID);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@PrecioUnidad", producto.PrecioUnidad);
                    cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                    cmd.Parameters.AddWithValue("@Estado", producto.Estado);
                    cmd.Parameters.AddWithValue("@Vencimiento", producto.Vencimiento);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public bool EliminarProducto(int ProductoID)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarProducto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", ProductoID);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public EntProducto BuscarProducto(int ProductoID)
        {
            SqlCommand cmd = null;
            EntProducto producto = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spBuscarProducto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", ProductoID);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        producto = new EntProducto();
                        producto.ProductoID = (int)dr["ProductoID"];
                        producto.Nombre = dr["Nombre"].ToString();
                        producto.OrdenProduccionID = (int)dr["OrdenProduccionID"];
                        producto.Descripcion = dr["Descripcion"].ToString();
                        producto.PrecioUnidad = (int)dr["PrecioUnidad"];
                        producto.Cantidad = (int)dr["Cantidad"];
                        producto.Estado = (int)dr["Estado"];
                        producto.Vencimiento = (DateTime)dr["Vencimiento"];
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

        public List<EntProducto> BuscarProductoPorPrecioUnidad(int precioUnidad)
        {
            SqlCommand cmd = null;
            List<EntProducto> productos = new List<EntProducto>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("BuscarProductoPorPrecioUnidad", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PrecioUnidad", precioUnidad);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntProducto producto = new EntProducto();
                        producto.ProductoID = (int)dr["ProductoID"];
                        producto.Nombre = dr["Nombre"].ToString();
                        producto.Descripcion = dr["Descripcion"].ToString();
                        producto.Cantidad = (int)dr["Cantidad"];
                        producto.Vencimiento = (DateTime)dr["Vencimiento"];
                        producto.Estado = (int)dr["Estado"];
                        producto.PrecioUnidad = (int)dr["PrecioUnidad"];
                        producto.OrdenProduccionID = (int)dr["OrdenProduccionID"];
                        productos.Add(producto);
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
            return productos;
        }


    }

    public class DatComprobantePago
    {
        private static readonly DatComprobantePago _instancia = new DatComprobantePago();

        public static DatComprobantePago Instancia
        {
            get { return _instancia; }
        }

        public List<EntComprobantePago> ListarComprobantePago()
        {
            SqlCommand cmd = null;
            List<EntComprobantePago> lista = new List<EntComprobantePago>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarComprobantepago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntComprobantePago comprobantePago = new EntComprobantePago();
                        comprobantePago.ComprobantePagoID = (int)dr["ComprobantePagoID"];
                        comprobantePago.CronogramaPagoID = (int)dr["CronogramaPagoID"];
                        comprobantePago.Monto = (int)dr["Monto"];
                        comprobantePago.PedidoID = (int)dr["PedidoID"];
                        comprobantePago.Fecha = (DateTime)dr["Fecha"];
                        lista.Add(comprobantePago);
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

        public bool RegistrarComprobantePago(EntComprobantePago comprobantePago)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spRegistrarComprobantepago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CronogramaPagoID", comprobantePago.CronogramaPagoID);
                    cmd.Parameters.AddWithValue("@Monto", comprobantePago.Monto);
                    cmd.Parameters.AddWithValue("@PedidoID", comprobantePago.PedidoID);
                    cmd.Parameters.AddWithValue("@Fecha", comprobantePago.Fecha);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public bool EliminarComprobantePago(int ComprobantePagoID)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarComprobantepago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ComprobantePagoID", ComprobantePagoID);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public EntComprobantePago BuscarComprobantePago(int ComprobantePagoID)
        {
            SqlCommand cmd = null;
            EntComprobantePago comprobantePago = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spBuscarComprobantepago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ComprobantePagoID", ComprobantePagoID);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        comprobantePago = new EntComprobantePago();
                        comprobantePago.ComprobantePagoID = (int)dr["ComprobantePagoID"];
                        comprobantePago.CronogramaPagoID = (int)dr["CronogramaPagoID"];
                        comprobantePago.Monto = (int)dr["Monto"];
                        comprobantePago.PedidoID = (int)dr["PedidoID"];
                        comprobantePago.Fecha = (DateTime)dr["Fecha"];
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
            return comprobantePago;
        }
    }

    public class DatBoletaVenta
    {
        private static readonly DatBoletaVenta _instancia = new DatBoletaVenta();

        public static DatBoletaVenta Instancia
        {
            get { return _instancia; }
        }

        public List<EntBoletaVenta> ListarBoletaVenta()
        {
            SqlCommand cmd = null;
            List<EntBoletaVenta> lista = new List<EntBoletaVenta>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarBoletaventa", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntBoletaVenta boletaVenta = new EntBoletaVenta();
                        boletaVenta.BoletaVentaID = (int)dr["BoletaVentaID"];
                        boletaVenta.ComprobantePagoID = (int)dr["ComprobantePagoID"];
                        boletaVenta.ClienteID = (int)dr["ClienteID"];
                        boletaVenta.MontoTotal = (int)dr["MontoTotal"];
                        boletaVenta.Fecha = (string)dr["Fecha"];
                        lista.Add(boletaVenta);
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

        public bool RegistrarBoletaVenta(EntBoletaVenta boletaVenta)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spRegistrarBoletaventa", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ComprobantePagoID", boletaVenta.ComprobantePagoID);
                    cmd.Parameters.AddWithValue("@ClienteID", boletaVenta.ClienteID);
                    cmd.Parameters.AddWithValue("@MontoTotal", boletaVenta.MontoTotal);
                    cmd.Parameters.AddWithValue("@Fecha", boletaVenta.Fecha);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public bool EliminarBoletaVenta(int BoletaVentaID)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarBoletaventa", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BoletaVentaID", BoletaVentaID);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }
        public EntBoletaVenta BuscarBoletaVenta(int BoletaVentaID)
        {
            SqlCommand cmd = null;
            EntBoletaVenta boletaVenta = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spBuscarBoletaventa", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BoletaVentaID", BoletaVentaID);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        boletaVenta = new EntBoletaVenta();
                        boletaVenta.BoletaVentaID = (int)dr["BoletaVentaID"];
                        boletaVenta.ComprobantePagoID = (int)dr["ComprobantePagoID"];
                        boletaVenta.ClienteID = (int)dr["ClienteID"];
                        boletaVenta.MontoTotal = (int)dr["MontoTotal"];
                        boletaVenta.Fecha = (string)dr["Fecha"];
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
            return boletaVenta;
        }
    }


    public class DatInsumo
    {
        private static readonly DatInsumo _instancia = new DatInsumo();

        public static DatInsumo Instancia
        {
            get { return _instancia; }
        }

        public List<EntInsumos> ListarInsumo()
        {
            SqlCommand cmd = null;
            List<EntInsumos> lista = new List<EntInsumos>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarInsumos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntInsumos insumo = new EntInsumos();
                        insumo.InsumosID = (int)dr["InsumoID"];
                        insumo.Nombre = dr["Nombre"].ToString();
                        insumo.Precio = (int)dr["Precio"];
                        insumo.Estado = (int)dr["Estado"];
                        insumo.Descripcion = dr["Descripcion"].ToString();
                        insumo.FechaVencimiento = (DateTime)dr["FechaVencimiento"];
                        lista.Add(insumo);
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

        public bool RegistrarInsumo(EntInsumos insumo)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spRegistrarInsumos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", insumo.Nombre);
                    cmd.Parameters.AddWithValue("@Precio", insumo.Precio);
                    cmd.Parameters.AddWithValue("@Estado", insumo.Estado);
                    cmd.Parameters.AddWithValue("@Descripcion", insumo.Descripcion);
                    cmd.Parameters.AddWithValue("@FechaVencimiento", insumo.FechaVencimiento);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public bool EliminarInsumo(int InsumosID)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarInsumos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InsumosID", InsumosID);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public EntInsumos BuscarInsumo(int InsumosID)
        {
            SqlCommand cmd = null;
            EntInsumos insumo = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spBuscarInsumos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InsumosID", InsumosID);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        insumo = new EntInsumos();
                        insumo.InsumosID = (int)dr["InsumoID"];
                        insumo.Nombre = dr["Nombre"].ToString();
                        insumo.Precio = (int)dr["Precio"];
                        insumo.Estado = (int)dr["Estado"];
                        insumo.Descripcion = dr["Descripcion"].ToString();
                        insumo.FechaVencimiento = (DateTime)dr["FechaVencimiento"];
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
            return insumo;
        }
    }

    public class DatProductoInsumo
    {
        private static readonly DatProductoInsumo _instancia = new DatProductoInsumo();

        public static DatProductoInsumo Instancia
        {
            get { return _instancia; }
        }

        public List<EntProductoInsumos> ListarProductoInsumo()
        {
            SqlCommand cmd = null;
            List<EntProductoInsumos> lista = new List<EntProductoInsumos>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarProductoInsumos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntProductoInsumos productoInsumo = new EntProductoInsumos();
                        productoInsumo.InsumosID = (int)dr["InsumosID"];
                        productoInsumo.ProductoID = (int)dr["ProductoID"];
                        lista.Add(productoInsumo);
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

        public bool RegistrarInsumoProducto(int insumoID, int productoID)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spRegistrarProductoInsumos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InsumosID", insumoID);
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }

        public bool EliminarInsumoProducto(int insumoID, int productoID)
        {
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarProductoInsumos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InsumosID", insumoID);
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        response = true;
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
            return response;
        }
        public EntProductoInsumos BuscarProductoInsumo(int insumoID, int productoID)
        {
            SqlCommand cmd = null;
            EntProductoInsumos productoInsumo = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spBuscarProductoInsumos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InsumosID", insumoID);
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        productoInsumo = new EntProductoInsumos();
                        productoInsumo.InsumosID = (int)dr["InsumosID"];
                        productoInsumo.ProductoID = (int)dr["ProductoID"];
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
            return productoInsumo;
        }
    }
}