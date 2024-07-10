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
    public partial class AreaProduccion : Form
    {
        public AreaProduccion()
        {
            InitializeComponent();
        }
        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorInsumos insumos = new MantenedorInsumos();
            if (insumos != null)
            {
                insumos.Show();
            }
            this.Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorProducto productos = new MantenedorProducto();
            if (productos != null)
            {
                productos.Show();
            }
            this.Hide();
        }

        private void ordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenProduccionPedido orden = new OrdenProduccionPedido();
            if (orden != null)
            {
                orden.Show();
            }
            this.Hide();
        }
    }
}
