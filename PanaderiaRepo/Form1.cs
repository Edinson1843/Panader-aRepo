using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogicaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PanaderiaRepo
{
    public partial class Form1 : Form
    {
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
                string idCliente = IdClientTextBox.Text.Trim();
                LogCliente.Instancia.EliminarCliente(idCliente);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}