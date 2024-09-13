using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_CS.Clases
{
    public class Vehiculos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public int Kilometraje { get; set; }
        public int Precio { get; set; }

        public string[] itemView()
        {
            return new string[] { Marca, Modelo, Año.ToString(), Kilometraje.ToString(), Precio.ToString() };
        }

        public Vehiculos()
        {
            Marca = "Toyota";
            Modelo = "Corolla";
            Año = 2020;
            Kilometraje = 15000;
            Precio = 20000;
        }
    }
}
