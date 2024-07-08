using System.ComponentModel;

namespace CapaEntidad
{
    public class EntProducto
    {
        public int ProductoID { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public string precio { get; set; }
        public string descripcion { get; set; }
        public string fecha { get; set; }
        public int estado { get; set; }

    }
    /*[ProductoID] int NOT NULL,
[BoletaventaID] int NOT NULL,
[ComprobantepagoID] int NOT NULL,
[nombre] varchar(50) NOT NULL,
[OrdenproduccionID] int NOT NULL,
[descripcion] varchar(255) NOT NULL,
[precio] varchar(30) NOT NULL,
[fecha] varchar(30) NOT NULL,
[estado] int NOT NULL
    Agregrar cantidad de producto
    */

}
