using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_CS.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabajo_CS
{
    public partial class Cliente : Form
    {
        string IdGlobal = "";

        List<Cliente> clientes = new List<Cliente>();
        public Cliente()
        {
            InitializeComponent();
        }
        /*void ListarClientes()
        {
            lvClienteLista.Items.Clear();
            foreach (Cliente cliente in GlobalVar.clientes)
            {
                lvClienteLista.Items.Add(new ListViewItem(cliente.itemView()));
            }
        }*/

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre valido");
                txNombre.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txApellidos.Text))
            {
                MessageBox.Show("Ingrese apellidos validos");
                txApellidos.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txDineroD.Text))
            {
                MessageBox.Show("Ingrese un nombre valido");
                txDineroD.Focus();
                return;
            }

            decimal D;
            bool isOk = decimal.TryParse(txDineroD.Text,out D);
            if (!isOk)
            {
                MessageBox.Show("Ingresa dinero valido");
                txDineroD.Focus();
                return;
            }
            Cliente cliente = new Cliente()
            {
                txNombre = txNombre,
                txApellidos = txApellidos,
                txDineroD = txDineroD
            };

            clientes.Add(cliente);
            MessageBox.Show("Cliente agregado");
            /*
            if (String.IsNullOrEmpty(IdGlobal))
            {
                GlobalVar.clientes.Add(cliente);
                MessageBox.Show("Cliente Almacenado");

            }
            else
            {
                Cliente cliente_modificar
                    = GlobalVar.clientes.Where(x => x.Id == IdGlobal).FirstOrDefault()!;
                cliente_modificar.Nombre = tx_nombre.Text;
                cliente_modificar.Apellidos = tx_apellido.Text;
                cliente_modificar.DineroDisponible = Convert.ToDecimal(tx_dinero.Text);
                IdGlobal = "";
            }*/

        }

        private void lvClienteLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvClienteLista.View = View.Details;
            lvClienteLista.GridLines = true;
            lvClienteLista.Columns.Add("Id");
            lvClienteLista.Columns.Add("Nombre");
            lvClienteLista.Columns.Add("Apellido");
            lvClienteLista.Columns.Add("Dinero");


            foreach (ColumnHeader column in lvClienteLista.Columns)
            {
                column.Width = 100;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = listView1.SelectedItems[0].Text;
            Cliente cliente_eliminar = GlobalVar.clientes.Where(x => x.Id == id).FirstOrDefault()!;
            GlobalVar.clientes.Remove(cliente_eliminar);
            ListarClientes();
            MessageBox.Show("Elemento Eliminado");
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = listView1.SelectedItems[0].Text;
            Cliente cliente_eliminar = GlobalVar.clientes.Where(x => x.Id == id).FirstOrDefault()!;
            GlobalVar.clientes.Remove(cliente_eliminar);
            ListarClientes();
            MessageBox.Show("Elemento Modificado");
        }
    }
}
