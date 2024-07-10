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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AreaVenta areaVenta = new AreaVenta();
            if (areaVenta != null)
            {
                areaVenta.Show();
            }
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AreaProduccion areaProducción = new AreaProduccion();
            if (areaProducción != null)
            {
                areaProducción.Show();
            }
            this.Hide();
        }
    }
}
