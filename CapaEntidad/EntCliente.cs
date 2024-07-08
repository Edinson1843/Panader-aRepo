namespace CapaEntidad
{
    public class EntCliente
    {
        public string ClienteID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string dni { get; set; }
        public string estado { get; set; }
    }
}
/* [ClienteID] int NOT NULL,
[nombre] varchar(20) NOT NULL,
[apellido] varchar(20) NOT NULL,
[dni] varchar(8) NOT NULL,
[telefono] varchar(9) NOT NULL,
[estado] int NOT NULL
*/