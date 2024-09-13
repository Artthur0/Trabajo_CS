using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_CS.Clases;

namespace Trabajo_CS
{
    public partial class AgregarVehiculo : Form
    {

        List<Vehiculos> vehiculo = new List<Vehiculos>();

        
        public AgregarVehiculo()
        {
            InitializeComponent();
        }


        void ListarVehiculos()
        {
            listView1.Items.Clear();
            foreach (Vehiculos v in vehiculo)
            {
                listView1.Items.Add(new ListViewItem(v.itemView()));
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tx_mar.Text))
            {
                MessageBox.Show("Debes ingresar una marca");
                tx_mar.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_mod.Text))
            {
                MessageBox.Show("Debes ingresar un modelo");
                tx_mod.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tx_year.Text))
            {
                MessageBox.Show("Debes ingresar un año");
                tx_year.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tx_kil.Text))
            {
                MessageBox.Show("Debes ingresar Kilometros");
                tx_kil.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tx_pre.Text))
            {
                MessageBox.Show("Debes ingresar un precio");
                tx_pre.Focus();
                return;
            }

            
            int year, kil, pre;

            bool OkY = int.TryParse(tx_year.Text, out year);
            bool OKK = int.TryParse(tx_kil.Text, out kil);
            bool OkP = int.TryParse(tx_pre.Text, out pre);
            if (!OkY)
            {
                MessageBox.Show("Ingresa año valido");
                tx_year.Focus();
                return;
            }

            if (!OKK)
            {
                MessageBox.Show("Ingresa Kilometro valido");
                tx_kil.Focus();
                return;
            }

            if (!OkP)
            {
                MessageBox.Show("Ingresa precio valido");
                tx_pre.Focus();
                return;
            }

            Vehiculos v = new Vehiculos()
            {
                Marca = tx_mar.Text,
                Modelo = tx_mod.Text,
                Año = year ,
                Precio = pre,
                Kilometraje = kil
            };
            GlobalVar.veh.Add(v);
            MessageBox.Show("Vehiculo Almacenado");
            ListarVehiculos();
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
    }
}
