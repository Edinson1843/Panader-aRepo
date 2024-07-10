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

        public List<Entidades> ListarCliente()
        {
            return DatCliente.Instancia.ListarCliente();
        }

        public void InsertarCliente(Entidades Cli)
        {
            DatCliente.Instancia.InsertarCliente(Cli);
        }

        public void EditarCliente(Entidades Cli)
        {
            DatCliente.Instancia.EditarCliente(Cli);
        }

        /*
        public void EliminarCliente(string Cli)
        {
            DatCliente.Instancia.EliminarCliente(Cli);
        }
        */
        public List<EntProducto> ListarProducto() {
            return DatCliente.Instancia.ListarProducto();
        }
    }
}