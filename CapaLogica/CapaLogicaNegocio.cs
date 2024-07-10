using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CapaLogicaNegocio
    {
        public class LogicaNegocio
        {
            private static readonly LogicaNegocio _instancia = new LogicaNegocio();
            public static LogicaNegocio Instancia
            {
                get { return LogicaNegocio._instancia; }
            }

            // Cliente
            public List<EntCliente> ListarClientes()
            {
                return DatCliente.Instancia.ListarCliente();
            }

            public bool RegistrarCliente(EntCliente cliente)
            {
                return DatCliente.Instancia.RegistrarCliente(cliente);
            }

            public bool EliminarCliente(int ID_Cliente)
            {
                return DatCliente.Instancia.EliminarCliente(ID_Cliente);
            }

            public EntCliente BuscarCliente(int ID_Cliente)
            {
                return DatCliente.Instancia.BuscarCliente(ID_Cliente);
            }

            public EntCliente BuscarClientePorID(int clienteID)
            {
                return new DatCliente().BuscarClientePorID(clienteID);
            }

            public EntCliente BuscarClientePorDNI(string dniCliente)
            {
                return new DatCliente().BuscarClientePorDNI(dniCliente);
            }

            // Contrato
            public List<EntContrato> ListarContratos()
            {
                return DatContrato.Instancia.ListarContrato();
            }

            public bool RegistrarContrato(EntContrato contrato)
            {
                return DatContrato.Instancia.RegistrarContrato(contrato);
            }

            public bool EliminarContrato(int ContratoID)
            {
                return DatContrato.Instancia.EliminarContrato(ContratoID);
            }

            public EntContrato BuscarContrato(int ContratoID)
            {
                return DatContrato.Instancia.BuscarContrato(ContratoID);
            }

            // Contrato Cliente
            public List<EntContratoCliente> ListarContratoCliente()
            {
                return DatContratoCliente.Instancia.ListarContratoCliente();
            }

            public bool AsociarContratoCliente(int clienteID, int contratoID)
            {
                return DatContratoCliente.Instancia.RegistrarContratoCliente(clienteID, contratoID);
            }

            public bool EliminarAsociacionContratoCliente(int clienteID, int contratoID)
            {
                return DatContratoCliente.Instancia.EliminarContratoCliente(clienteID, contratoID);
            }
            public EntContratoCliente BuscarContratoCliente(int clienteID, int contratoID)
            {
                return DatContratoCliente.Instancia.BuscarContratoCliente(clienteID, contratoID);
            }

            // Cronograma de Pago
            public List<EntCronogramaPago> ListarCronogramaPago()
            {
                return DatCronogramaPago.Instancia.ListarCronogramaPago();
            }

            public bool RegistrarCronogramaPago(EntCronogramaPago cronograma)
            {
                return DatCronogramaPago.Instancia.RegistrarCronogramaPago(cronograma);
            }

            public bool EliminarCronogramaPago(int CronogramaPagoID)
            {
                return DatCronogramaPago.Instancia.EliminarCronogramaPago(CronogramaPagoID);
            }
            public EntCronogramaPago BuscarCronogramaPago(int CronogramaPagoID)
            {
                return DatCronogramaPago.Instancia.BuscarCronogramaPago(CronogramaPagoID);
            }

            // Orden de Producción
            public List<EntOrdenProduccion> ListarOrdenProduccion()
            {
                return DatOrdenProduccion.Instancia.ListarOrdenProduccion();
            }

            public bool RegistrarOrdenProduccion(EntOrdenProduccion orden)
            {
                return DatOrdenProduccion.Instancia.RegistrarOrdenProduccion(orden);
            }

            public bool EliminarOrdenProduccion(int OrdenProduccionID)
            {
                return DatOrdenProduccion.Instancia.EliminarOrdenProduccion(OrdenProduccionID);
            }
            public EntOrdenProduccion BuscarOrdenProduccion(int OrdenProduccionID)
            {
                return DatOrdenProduccion.Instancia.BuscarOrdenProduccion(OrdenProduccionID);
            }

            // Pedido
            public List<EntPedido> ListarPedidos()
            {
                return DatPedido.Instancia.ListarPedido();
            }

            public bool RegistrarPedido(EntPedido pedido)
            {
                return DatPedido.Instancia.RegistrarPedido(pedido);
            }

            public bool EliminarPedido(int ID_Pedido)
            {
                return DatPedido.Instancia.EliminarPedido(ID_Pedido);
            }

            public EntPedido BuscarPedido(int ID_Pedido)
            {
                return DatPedido.Instancia.BuscarPedido(ID_Pedido);
            }

            // Productos
            public List<EntProducto> ListarProductos()
            {
                return DatProducto.Instancia.ListarProducto();
            }

            public bool RegistrarProducto(EntProducto producto)
            {
                return DatProducto.Instancia.RegistrarProducto(producto);
            }

            public bool EliminarProducto(int boletaVentaID)
            {
                return DatProducto.Instancia.EliminarProducto(boletaVentaID);
            }
            public EntProducto BuscarProducto(int productoID)
            {
                return DatProducto.Instancia.BuscarProducto(productoID);
            }

            public List<EntProducto> BuscarProductoPorPrecioUnidad(int precioUnidad)
            {
                return DatProducto.Instancia.BuscarProductoPorPrecioUnidad(precioUnidad);
            }




            // Comprobante de Pago
            public List<EntComprobantePago> ListarComprobantePago()
            {
                return DatComprobantePago.Instancia.ListarComprobantePago();
            }

            public bool RegistrarComprobantePago(EntComprobantePago comprobantePago)
            {
                return DatComprobantePago.Instancia.RegistrarComprobantePago(comprobantePago);
            }

            public bool EliminarComprobantePago(int ComprobantePagoID)
            {
                return DatComprobantePago.Instancia.EliminarComprobantePago(ComprobantePagoID);
            }
            public EntComprobantePago BuscarComprobantePago(int ComprobantePagoID)
            {
                return DatComprobantePago.Instancia.BuscarComprobantePago(ComprobantePagoID);
            }

            // Boleta de Venta
            public List<EntBoletaVenta> ListarBoletasVenta()
            {
                return DatBoletaVenta.Instancia.ListarBoletaVenta();
            }

            public bool RegistrarBoletaVenta(EntBoletaVenta boletaVenta)
            {
                return DatBoletaVenta.Instancia.RegistrarBoletaVenta(boletaVenta);
            }

            public bool EliminarBoletaVenta(int BoletaVentaID)
            {
                return DatBoletaVenta.Instancia.EliminarBoletaVenta(BoletaVentaID);
            }
            public EntBoletaVenta BuscarBoletaVenta(int BoletaVentaID)
            {
                return DatBoletaVenta.Instancia.BuscarBoletaVenta(BoletaVentaID);
            }

            // Insumos
            public List<EntInsumos> ListarInsumos()
            {
                return DatInsumo.Instancia.ListarInsumo();
            }

            public bool RegistrarInsumo(EntInsumos insumo)
            {
                return DatInsumo.Instancia.RegistrarInsumo(insumo);
            }

            public bool EliminarInsumo(int insumoID)
            {
                return DatInsumo.Instancia.EliminarInsumo(insumoID);
            }
            public EntInsumos BuscarInsumo(int insumoID)
            {
                return DatInsumo.Instancia.BuscarInsumo(insumoID);
            }

            // Producto-Insumo
            public List<EntProductoInsumos> ListarProductoInsumo()
            {
                return DatProductoInsumo.Instancia.ListarProductoInsumo();
            }

            public bool AsociarInsumoProducto(int insumoID, int productoID)
            {
                return DatProductoInsumo.Instancia.RegistrarInsumoProducto(insumoID, productoID);
            }

            public bool EliminarAsociacionInsumoProducto(int insumoID, int productoID)
            {
                return DatProductoInsumo.Instancia.EliminarInsumoProducto(insumoID, productoID);
            }
            public EntProductoInsumos BuscarProductoInsumo(int insumoID, int productoID)
            {
                return DatProductoInsumo.Instancia.BuscarProductoInsumo(insumoID, productoID);
            }

        }
    }
}
