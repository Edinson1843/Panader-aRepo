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
    public partial class VentaDirecta : Form
    {
        public VentaDirecta()
        {
            InitializeComponent();
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
        private void ActualizarListaVentas()
        {
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void agregarDetalleButton_Click(object sender, EventArgs e)
        {
        }
    }
}
