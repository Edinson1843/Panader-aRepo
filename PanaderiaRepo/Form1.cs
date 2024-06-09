using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogicaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PanaderiaRepo
{
    public partial class Form1 : Form
    {
        private const string connectionString = @"Data Source=DESKTOP-LL44DJ3;Initial Catalog=BD_Panaderia;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            ActualizarListaClientes();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                EntCliente cli = new EntCliente();
                cli.Id = IdClientTextBox.Text.Trim();
                cli.Nombre = NameClientTextBox.Text.Trim();
                cli.Apellido = LastNameClientTextBox.Text.Trim();
                cli.Telefono = PhoneClientTextBox.Text.Trim();
                LogCliente.Instancia.InsertarCliente(cli);
                MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                EntCliente cli = new EntCliente();
                cli.Id = IdClientTextBox.Text.Trim();
                cli.Nombre = NameClientTextBox.Text.Trim();
                cli.Apellido = LastNameClientTextBox.Text.Trim();
                cli.Telefono = PhoneClientTextBox.Text.Trim();
                LogCliente.Instancia.EditarCliente(cli);
                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarVariables();
                ActualizarListaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteClientButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                string id = IdClientTextBox.Text.Trim();
                LogCliente.Instancia.EliminarCliente(id);
                MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            ActualizarListaClientes();
        }

        private void ActualizarListaClientes()
        {
            ClientDataView.DataSource = LogCliente.Instancia.ListarCliente();
        }

        private void LimpiarVariables()
        {
            IdClientTextBox.Text = "";
            NameClientTextBox.Text = "";
            LastNameClientTextBox.Text = "";
            PhoneClientTextBox.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StockDataView.DataSource = LogCliente.Instancia.ListarProducto();
        }

        private void ConsultarCliente(object sender, EventArgs e)
        {
            // Criterios de búsqueda
            string id = IdClientTextBox.Text.Trim();
            string nombre = NameClientTextBox.Text.Trim();
            string apellidos = LastNameClientTextBox.Text.Trim();
            string telefono = PhoneClientTextBox.Text.Trim();

            // Verificamos que al menos un criterio de búsqueda sea proporcionado
            if (string.IsNullOrEmpty(id) && string.IsNullOrEmpty(nombre) &&
                string.IsNullOrEmpty(apellidos) && string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Por favor ingrese al menos un criterio de búsqueda");
                return;
            }

            // Nombre del procedimiento almacenado
            string storedProcedure = "BuscarCliente";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Añadimos los parámetros del procedimiento almacenado
                    command.Parameters.AddWithValue("@id", string.IsNullOrEmpty(id) ? (object)DBNull.Value : id);
                    command.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(nombre) ? (object)DBNull.Value : nombre);
                    command.Parameters.AddWithValue("@apellidos", string.IsNullOrEmpty(apellidos) ? (object)DBNull.Value : apellidos);
                    command.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(telefono) ? (object)DBNull.Value : telefono);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }
            }

        }
        private void CleanConsulta(object sender, EventArgs e)
        {
            this.dataGridView2.DataSource = null;
            MessageBox.Show("Se limpio el panel de busqueda");
            return;
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}