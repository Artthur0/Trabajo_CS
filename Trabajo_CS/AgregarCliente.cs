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
    public partial class AgregarCliente : Form
    {
        string IdGlobal = "";


        public AgregarCliente()
        {
            InitializeComponent();
        }
        void ListarClientes()
        {
            lvClienteLista.Items.Clear();
            foreach (Cliente clie in GlobalVar.client)
            {
                lvClienteLista.Items.Add(new ListViewItem(clie.itemView()));
            }
        }

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
                Nombre = txNombre.Text,
                Apellidos = txApellidos.Text,
                DineroD = D
            };

            if (String.IsNullOrEmpty(IdGlobal))
            {
                GlobalVar.client.Add(cliente);
                MessageBox.Show("Cliente Almacenado");
            }
            else
            {
                // No usar el operador "!" para forzar nulabilidad.
                Cliente cliente_modificar = GlobalVar.client.Where(x => x.Id == IdGlobal).FirstOrDefault();

                // Verifica si se encontró un cliente antes de modificarlo.
                if (cliente_modificar != null)
                {
                    cliente_modificar.Nombre = txNombre.Text;
                    cliente_modificar.Apellidos = txApellidos.Text;

                    // Usa TryParse para manejar errores en la conversión de dinero.
                    decimal dineroDisponible;
                    if (decimal.TryParse(txDineroD.Text, out dineroDisponible))
                    {
                        cliente_modificar.DineroD = dineroDisponible;
                    }
                    else
                    {
                        MessageBox.Show("El valor ingresado en Dinero no es válido.");
                    }

                    IdGlobal = "";
                }
                else
                {
                    MessageBox.Show("No se encontró un cliente con ese ID.");
                }
            }


            ListarClientes();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //String id = lvClienteLista.SelectedItems[0].Text;
            //Cliente cliente_eliminar = GlobalVar.client.Where(x => x.Id == id).FirstOrDefault()!;
            //GlobalVar.client.Remove(cliente_eliminar);
            //ListarClientes();
            //MessageBox.Show("Elemento eliminado");
        }

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = lvClienteLista.SelectedItems[0].Text;
            Cliente cliente_eliminar = GlobalVar.clientes.Where(x => x.Id == id).FirstOrDefault()!;
            GlobalVar.clientes.Remove(cliente_eliminar);
            ListarClientes();
            MessageBox.Show("Elemento eliminado");
        }
    }
}
