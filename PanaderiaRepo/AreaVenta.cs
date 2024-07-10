using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaRepo
{
    public partial class AreaVenta : Form
    {
        public AreaVenta()
        {
            InitializeComponent();
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorCliente cliente = new MantenedorCliente();
            if (cliente != null)
            {
                cliente.Show();
            }
            this.Hide();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorProducto detalleProducto = new MantenedorProducto();
            if (detalleProducto != null)
            {
                detalleProducto.Show();
            }
            this.Hide();
        }

        private void directaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaDirecta detalleVenta = new VentaDirecta();
            if (detalleVenta != null)
            {
                detalleVenta.Show();
            }
            this.Hide();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaPedido detallePedido = new VentaPedido();
            if (detallePedido != null)
            {
                detallePedido.Show();
            }
            this.Hide();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido detallePedidos = new Pedido();
            if (detallePedidos != null)
            {
                detallePedidos.Show();
            }
            this.Hide();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Form inicioForm = Application.OpenForms["Inicio"];

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
    }
}
/*Atras_Click
Este método se ejecuta cuando se hace clic en algún botón o elemento llamado “Atras”. 
Primero, verifica si ya existe una instancia del formulario “Inicio”. 
Si existe, muestra esa instancia; de lo contrario, crea una nueva instancia de AreaVenta y la muestra
