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
            string criterioBusqueda = textBox4.Text.Trim();

            // Validar el criterio de búsqueda para evitar SQL Injection
            if (string.IsNullOrEmpty(criterioBusqueda))
            {
                MessageBox.Show("Por favor ingrese un criterio de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construir la consulta SQL utilizando LIKE
            string query = "SELECT id_Cliente, nombreCliente, apellidosCliente, telefono FROM Cliente " +
                           "WHERE nombreCliente LIKE @criterioBusqueda OR " +
                           "apellidosCliente LIKE @criterioBusqueda";

            // Usar parámetros de SQL para evitar SQL Injection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar el parámetro y usar % para la búsqueda con LIKE
                    command.Parameters.AddWithValue("@criterioBusqueda", "%" + criterioBusqueda + "%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }
            }/*using (var context = new PanaderiaContext())
            {
                var clientes = context.Clientes
                    .Select(c => new
                        {
                            c.id_Cliente,
                            c.nombreCliente,
                            c.apellidosCliente,
                            c.telefono
                    })
                        .ToList();

                dataGridView2.DataSource = clientes;
                
            }*/
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
            return;
        }
    }
}
