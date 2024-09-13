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
        {/*
            if (String.IsNullOrEmpty(tx_mar.Text))
            {
                MessageBox.Show("Debes ingresar un nombre");
                tx_mar.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_mod.Text))
            {
                MessageBox.Show("Debes ingresar un apellido");
                tx_mod.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tx_year.Text))
            {
                MessageBox.Show("Debes ingresar un dinerillo");
                tx_year.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tx_kil.Text))
            {
                MessageBox.Show("Debes ingresar un dinerillo");
                tx_kil.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tx_pre.Text))
            {
                MessageBox.Show("Debes ingresar un dinerillo");
                tx_pre.Focus();
                return;
            }

            
            int num;

            bool Ok = int.TryParse(tx_year.Text, out num);
            if (!Ok)
            {
                MessageBox.Show("Ingresa dinero valido");
                tx_year.Focus();
                return;
            }

            Cliente cliente = new Cliente()
            {
                Nombre = tx_nombre.Text,
                Apellidos = tx_apellido.Text,
                DineroDisponible = lukas
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

            ListarClientes();*/
        }
}
}
