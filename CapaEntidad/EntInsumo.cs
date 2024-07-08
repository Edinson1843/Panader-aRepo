using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class EntInsumo
    {
        public string InsumosID { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string fecha_vencimiento { get; set; }
        public string cantidad { get; set; }
        public string estado { get; set; }
    }
    /*[InsumosID] int NOT NULL,
[nombre] varchar(20) NOT NULL,
[PedidoID] int NOT NULL,
[descripcion] text NOT NULL,
[fecha_vencimiento] varchar NOT NULL,
[cantidad] varchar(50) NOT NULL
    de debe agregar un atributo estado
*/
}
