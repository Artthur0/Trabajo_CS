using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_CS.clases;
using Trabajo_CS.Clases;

namespace Trabajo_CS.Clases
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public decimal DineroD { get; set; }

        public Cliente()
        {
            Guid guid = Guid.NewGuid();
            Id = guid.ToString();
        }
        public string[] itemView()
        {
            string[] data = {Id, Nombre,
                    Apellidos, Convert.ToString(DineroD) };
            return data;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Apellidos}";
        }

        public string mostrarDatos()
        {
            return $"{Nombre} - {Apellidos} - {DineroD}";
        }
        public void ComprarVehiculo(Vehiculos vehiculo, Inventario inventario)
        {
            if (DineroD >= vehiculo.Precio && inventario.ExisteVehiculo(vehiculo))
            {
                inventario.EliminarVehiculo(vehiculo);
                DineroD = DineroD - vehiculo.Precio;
                Console.WriteLine($"{Nombre} {Apellidos} compró el auto {vehiculo.Marca} {vehiculo.Modelo}");
            }
            else
            {
                Console.WriteLine("Compra Fallida. Verifica el inventario o el dinero disponible");
            }
        }

    }
}
