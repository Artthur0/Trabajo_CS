using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_CS.Clases;

namespace Trabajo_CS.clases
{
    public class Inventario
    {
        private List<Vehiculos> Vehiculo   = new List<Vehiculos>();

        public void AgregarVehiculo(Vehiculos vehiculo)
        {
            if (!String.IsNullOrEmpty(vehiculo.Marca))
            {
                Vehiculo.Add(vehiculo);
            }
            
        }

        public bool ExisteVehiculo(Vehiculos vehiculo)
        {
            return Vehiculo.Contains(vehiculo);
        }
        public List<Vehiculos> Lista()
        {
            return Vehiculo;
        }

        public void EliminarVehiculo(Vehiculos vehiculo)
        {
            Vehiculo.Remove(vehiculo);
        }

        public void MostrarInventario()
        {
            foreach (var vehiculo in Vehiculo)
            {
                vehiculo.MostrarDetalles();
            }
        }


    }
}
