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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
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

            /*Cliente cliente = new Cliente()
            {
                Icon
                Nombre = txNombre.Text,
                Apellidos = txApellidos.Text,
                DineroD = D
            };*/

        }
    }
}
