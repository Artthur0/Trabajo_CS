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

       

        public void MostrarDetalleVenta()
        {
            Console.WriteLine($"{FechaVenta} : {Clientes.Nombre} {Clientes.Apellidos} " +
                $"compró {VehiculoVendido.Marca} en ${PrecioVenta} ");
        }



    }
}
