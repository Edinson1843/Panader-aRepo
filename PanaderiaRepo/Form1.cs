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
            DataTable dataTableClientes = ClientRequest.GetClientes();
            ClientDataView.DataSource = dataTableClientes;
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            string id = IdClientTextBox.Text;
            string nombre = NameClientTextBox.Text;
            string apellido = LastNameClientTextBox.Text;
            string telefono = PhoneClientTextBox.Text;

            if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(telefono))
            {
                if (ClientRequest.AddClient(id, nombre, apellido, telefono))
                {
                    MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ActualizarListaClientes();
                }
                else
                {
                    MessageBox.Show("Error al agregar el cliente. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateClientButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteClientButton_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarListaClientes()
        {
            DataTable dataTableClientes = ClientRequest.GetClientes();
            ClientDataView.DataSource = dataTableClientes;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
