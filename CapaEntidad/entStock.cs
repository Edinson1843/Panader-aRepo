using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entStock
    {

        public string id_producto { get; set; }
        public string nombrepro { get; set; }
        public string tipo_producto { get; set; }
        public DateTime fecha_entrega { get; set; }
        public float precio_unitario { get; set; }
        public int cantidad { get; set; }

    }
}

