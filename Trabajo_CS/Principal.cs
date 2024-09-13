using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_CS
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }



        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente formcliente = new Cliente();
            formcliente.MdiParent = this.MdiParent;
            formcliente.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarVehiculo formcliente = new AgregarVehiculo();
            formcliente.MdiParent = this.MdiParent;
            formcliente.Show();
        }

        private void crearVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta formcliente = new Venta();
            formcliente.MdiParent = this.MdiParent;
            formcliente.Show();
        }
    }
}
