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
    public partial class MantenedorProducto : Form
    {
        public MantenedorProducto()
        {
            InitializeComponent();
            ActualizarListaProductos();
        }
        private void atrasButton_Click(object sender, EventArgs e)
        {
            Form inicioForm = Application.OpenForms["ÁreaProducción"];

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

        private void ActualizarListaProductos()
        {
            dataGridView1.DataSource = LogicaNegocio.Instancia.ListarProductos();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    EntProducto producto = new EntProducto();
                    producto.Nombre = nombreTextBox.Text;
                    producto.Descripcion = descripcionTextBox.Text;
                    producto.PrecioUnidad = Convert.ToInt32(precioTextBox.Text);
                    producto.Cantidad = Convert.ToInt32(cantidadTextBox.Text);
                    producto.Vencimiento = dateTimePicker1.Value;
                    producto.OrdenProduccionID = 1;
                    producto.Estado = 1;

                    LogicaNegocio.Instancia.RegistrarProducto(producto);
                    MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nombreTextBox.Text = "";
                    descripcionTextBox.Text = "";
                    precioTextBox.Text = "";
                    cantidadTextBox.Text = "";
                    ActualizarListaProductos();
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
                    LogicaNegocio.Instancia.EliminarProducto(selectedId);
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarListaProductos();
                    idTextBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string seleccion = busquedaComboBox.SelectedItem.ToString();
            string inputBusqueda = txtBusqueda.Text.Trim();

            if (string.IsNullOrEmpty(inputBusqueda))
            {
                MessageBox.Show("Por favor, ingrese un valor de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (seleccion)
            {
                case "Listar Productos":
                    dataGridView1.DataSource = LogicaNegocio.Instancia.ListarProductos();
                    break;

                case "ID":
                    if (int.TryParse(inputBusqueda, out int idProducto))
                    {
                        EntProducto producto = LogicaNegocio.Instancia.BuscarProducto(idProducto);
                        if (producto != null)
                        {
                            dataGridView1.DataSource = new List<EntProducto> { producto };
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Precio":
                    if (int.TryParse(inputBusqueda, out int precioUnidad))
                    {
                        List<EntProducto> productosPorPrecioUnidad = LogicaNegocio.Instancia.BuscarProductoPorPrecioUnidad(precioUnidad);
                        dataGridView1.DataSource = productosPorPrecioUnidad;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un valor de Precio Unidad válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("Seleccione una opción de búsqueda válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
