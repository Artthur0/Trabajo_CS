using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_CS.Clases
{
    public class Ventas
    {
        public Vehiculos VehiculoVendido { get; set; }
        public Cliente Clientes { get; set; }
        public decimal PrecioVenta { get; set; }
        public DateTime FechaVenta { get; set; }

       static void Concesionario()
       {
            RegistrarVenta(Vehiculos vehiculo, Cliente cliente)
            {
                if (cliente.DineroDisponible >= vehiculo.Precio && Inventario.ExisteVehiculo(vehiculo))
                {
                    Venta nuevaVenta = new Venta()
                    {
                        VehiculoVendido = vehiculo,
                        Cliente = cliente,
                        PrecioVenta = vehiculo.Precio,
                        FechaVenta = DateTime.Now

                    };

                    VentasRealizadas.Add(nuevaVenta);
                    cliente.ComprarVehiculo(vehiculo, Inventario);
                }
                else
                {
                    MessageBox.Show("Verifique tener el monto o que el vehiculo se encuentre disponible");
                }
            }

            public void MostrarHistorialVentas()
            {
                foreach (var venta in VentasRealizadas)
                {
                    venta.MostrarDetalleVenta();
                }
            }

        }

        public void MostrarDetalleVenta()
        {
            Console.WriteLine($"{FechaVenta} : {Clientes.Nombre} {Clientes.Apellidos} " +
                $"compró {VehiculoVendido.Marca} en ${PrecioVenta} ");
        }



    }
}
