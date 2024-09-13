using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_CS.Clases;

namespace Trabajo_CS.clases
{
    public class Concesionario
    {
        public string Nombre { get; set; }
        public Inventario Inventario { get; set; }
        public List<Ventas> VentasRealizadas = new List<Ventas>();

        public void RegistrarVenta(Vehiculos vehiculo, Clientes cliente)
        {
            if (cliente.DineroD >= vehiculo.Precio && Inventario.ExisteVehiculo(vehiculo))
            {
                Ventas nuevaVenta = new Ventas()
                {
                    VehiculoVendido = vehiculo,
                    Clientes = cliente,
                    PrecioVenta = vehiculo.Precio,
                    FechaVenta = DateTime.Now

                };

                VentasRealizadas.Add(nuevaVenta);
                cliente.ComprarVehiculo(vehiculo, Inventario);
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
}
