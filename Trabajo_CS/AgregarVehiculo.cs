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

namespace Trabajo_CS
{
    public partial class AgregarVehiculo : Form
    {
        public AgregarVehiculo()
        {
            InitializeComponent();
        }

        private void AgregarVehiculo_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Marca");
            listView1.Columns.Add("Modelo");
            listView1.Columns.Add("Año");
            listView1.Columns.Add("Kilometraje");
            listView1.Columns.Add("Precio");


            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = 100;
            }


        }



        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
