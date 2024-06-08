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
        }

        private void Seleccionar(object sender, EventArgs e)
        {

        }

        private void SeleccionarCliente(object sender, EventArgs e)
        {
            /*using (var context = new PanaderiaContext())
            {
                var clientes = context.Clientes
                    .Select(c => new
                        {
                            c.id_Cliente,
                            c.nombreCliente,
                            c.apellidosCliente,
                            c.telefono
                    })
                        .ToList();

                dataGridView2.DataSource = clientes;
                
            }*/
        }

    private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
