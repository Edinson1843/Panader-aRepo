using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace PanaderiaRepo
{
    public partial class Form1 : Form
    {
        private const string connectionString = @"Data Source=DESKTOP-LL44DJ3;Initial Catalog=BD_Panaderia;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            if (DB_Manager.ManageConnection())
            {
                MessageBox.Show("¡Conexión exitosa a la base de datos!", "Conexión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Seleccionar(object sender, EventArgs e)
        {

        }

        private void SeleccionarCliente(object sender, EventArgs e)
        {
            // Criterios de búsqueda
            string idCliente = textBox7.Text.Trim();
            string nombreCliente = textBox4.Text.Trim();
            string apellidosCliente = textBox4.Text.Trim();
            string telefono = textBox8.Text.Trim();

            // Verifica que al menos un criterio de búsqueda sea proporcionado
            if (string.IsNullOrEmpty(idCliente) && string.IsNullOrEmpty(nombreCliente) &&
                string.IsNullOrEmpty(apellidosCliente) && string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Por favor ingrese al menos un criterio de búsqueda");
                return;
            }

            // Cadena de conexión (asegúrate de que la cadena de conexión sea correcta)
           // string connectionString = "your_connection_string_here";

            // Nombre del procedimiento almacenado
            string storedProcedure = "BuscarCliente";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Añade los parámetros del procedimiento almacenado
                    command.Parameters.AddWithValue("@id_Cliente", string.IsNullOrEmpty(idCliente) ? (object)DBNull.Value : idCliente);
                    command.Parameters.AddWithValue("@nombreCliente", string.IsNullOrEmpty(nombreCliente) ? (object)DBNull.Value : nombreCliente);
                    command.Parameters.AddWithValue("@apellidosCliente", string.IsNullOrEmpty(apellidosCliente) ? (object)DBNull.Value : apellidosCliente);
                    command.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(telefono) ? (object)DBNull.Value : telefono);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.dataGridView2.DataSource = null;
            MessageBox.Show("Se limpio el panel de busqueda");
            return;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
