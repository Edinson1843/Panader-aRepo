using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaLogica.CapaLogicaNegocio;

namespace PanaderiaRepo
{
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
            ActualizarListaClientes();
        }
        private void atrasButton_Click(object sender, EventArgs e)
        {
            Form inicioForm = Application.OpenForms["AreaVenta"];

            if (inicioForm != null)
            {
                inicioForm.Show();
            }
            else
            {
                AreaVenta newInicioForm = new AreaVenta();
                newInicioForm.Show();
            }
            this.Hide();
        }

        private void ActualizarListaClientes()
        {
            dataGridView1.DataSource = LogicaNegocio.Instancia.ListarClientes();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    EntCliente cli = new EntCliente();
                    cli.Nombre = nombreTextBox.Text.Trim();
                    cli.Apellido = apellidoTextBox.Text.Trim();
                    cli.Telefono = telefonoTextBox.Text.Trim();
                    cli.Direccion = direccionTextBox.Text.Trim();
                    cli.DNI = Convert.ToInt32(dniTextBox.Text.Trim());
                    cli.Estado = 1;


                    LogicaNegocio.Instancia.RegistrarCliente(cli);
                    MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nombreTextBox.Text = "";
                    apellidoTextBox.Text = "";
                    telefonoTextBox.Text = "";
                    direccionTextBox.Text = "";
                    dniTextBox.Text = "";
                    ActualizarListaClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedId = idTextBox.Text.Trim() != "" ? Convert.ToInt32(idTextBox.Text.Trim()) : 0;

                DialogResult dialogResult = MessageBox.Show($"¿Está seguro de que desea eliminar el cliente con ID {selectedId}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    LogicaNegocio.Instancia.EliminarCliente(selectedId);
                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarListaClientes();
                    idTextBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string seleccion = busquedaComboBox.SelectedItem.ToString();

            switch (seleccion)
            {
                case "Listar Clientes":
                    dataGridView1.DataSource = LogicaNegocio.Instancia.ListarClientes();
                    break;

                case "ID":
                    if (int.TryParse(txtBusqueda.Text.Trim(), out int idCliente))
                    {
                        EntCliente cliente = LogicaNegocio.Instancia.BuscarCliente(idCliente);
                        if (cliente != null)
                        {
                            dataGridView1.DataSource = new List<EntCliente> { cliente };
                        }
                        else
                        {
                            MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "DNI":
                    string dniCliente = txtBusqueda.Text.Trim();
                    EntCliente clientePorDNI = LogicaNegocio.Instancia.BuscarClientePorDNI(dniCliente);
                    if (clientePorDNI != null)
                    {
                        dataGridView1.DataSource = new List<EntCliente> { clientePorDNI };
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("Seleccione una función válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }

}

