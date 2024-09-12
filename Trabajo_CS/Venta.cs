using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabajo_CS
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            listView1.GridLines = true;

            listView1.Columns.Add("Cliente");

            listView1.Columns.Add("Vehiculo");

            listView1.Columns.Add("Precio");

            listView1.Columns.Add("Fecha");


            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = 100;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_dinero.Text) && !decimal.TryParse(tb_dinero.Text, out _))
            {
                MessageBox.Show("Debes ingresar un valor válido.");
                tb_dinero.Focus();
                return;
            }
        }

    }
}
