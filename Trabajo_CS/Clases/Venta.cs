﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_CS.Clases
{
    internal class Venta
    {
        public Vehiculos VehiculoVendido { get; set; }
        public Clientes Clientes { get; set; }
        public decimal PrecioVenta { get; set; }
        public DateTime FechaVenta { get; set; }

       

        public void MostrarDetalleVenta()
        {
            Console.WriteLine($"{FechaVenta} : {Clientes.Nombre} {Clientes.Apellidos} " +
                $"compró {VehiculoVendido.Marca} en ${PrecioVenta} ");
        }



    }
}
