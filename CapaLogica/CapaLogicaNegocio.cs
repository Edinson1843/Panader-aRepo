using CapaAccesoDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogicaNegocio
{
    public class LogCliente
    {
        private static readonly LogCliente _instancia = new LogCliente();
        public static LogCliente Instancia
        {
            get { return _instancia; }
        }

        public List<EntCliente> ListarCliente()
        {
            return DatCliente.Instancia.ListarCliente();
        }

        public void InsertarCliente(EntCliente Cli)
        {
            DatCliente.Instancia.InsertarCliente(Cli);
        }

        public void EditarCliente(EntCliente Cli)
        {
            DatCliente.Instancia.EditarCliente(Cli);
        }
        
        public void EliminarCliente(string Cli)
        {
            DatCliente.Instancia.EliminarCliente(Cli);
        }
        
        public List<EntProducto> ListarProducto() {
            return DatCliente.Instancia.ListarProducto();
        }
    }
}
