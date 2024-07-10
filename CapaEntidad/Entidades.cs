using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntCliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Estado { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int DNI { get; set; }
    }

    public class EntContrato
    {
        public int ContratoID { get; set; }
        public int Cantidad { get; set; }
        public int Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }

    public class EntContratoCliente
    {
        public int ClienteID { get; set; }
        public int ContratoID { get; set; }
    }

    public class EntCronogramaPago
    {
        public int CronogramaPagoID { get; set; }
        public int ContratoID { get; set; }
        public DateTime FechaPagos { get; set; }
        public string MetodoPago { get; set; }
    }

    public class EntOrdenProduccion
    {
        public int OrdenProduccionID { get; set; }
        public string NombreEmpleado { get; set; }
        public int Cantidad { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaSalida { get; set; }
        public int Estado { get; set; }
    }

    public class EntPedido
    {
        public int PedidoID { get; set; }
        public int Estado { get; set; }
        public int OrdenProduccionID { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEntrega { get; set; }
    }

    public class EntProducto
    {
        public int ProductoID { get; set; }
        public int Estado { get; set; }
        public int OrdenProduccionID { get; set; }
        public string Nombre { get; set; }
        public int PrecioUnidad { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public DateTime Vencimiento { get; set; }
        public decimal Precio { get; set; }
    }

    public class EntComprobantePago
    {
        public int ComprobantePagoID { get; set; }
        public int CronogramaPagoID { get; set; }
        public int Monto { get; set; }
        public int PedidoID { get; set; }
        public DateTime Fecha { get; set; }
        public int Estado { get; set; }
    }

    public class EntBoletaVenta
    {
        public int BoletaVentaID { get; set; }
        public int ComprobantePagoID { get; set; }
        public int ClienteID { get; set; }
        public int MontoTotal { get; set; }
        public string Fecha { get; set; }
    }

    public class EntInsumos
    {
        public int InsumosID { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Estado { get; set; }
    }

    public class EntProductoInsumos
    {
        public int InsumosID { get; set; }
        public int ProductoID { get; set; }
    }
}
