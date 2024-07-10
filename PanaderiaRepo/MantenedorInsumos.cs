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
    public partial class MantenedorInsumos : Form
    {
        public MantenedorInsumos()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
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
    }
}
