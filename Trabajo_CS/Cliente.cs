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
        public Cliente()
        {
            InitializeComponent();
        }
        void ListarClientes()
        {
            lvClienteLista.Items.Clear();
            foreach (Cliente cliente in GlobalVar.clientes)
            {
                lvClienteLista.Items.Add(new ListViewItem(cliente.itemView()));
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
            }

        }
    }
}
