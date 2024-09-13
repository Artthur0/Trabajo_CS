using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_CS.Clases
{
    internal class Vehiculos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Año { get; set; }
        public int Precio { get; set; }
        public int Kilometraje { get; set; }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año},Precio:{Precio},Km:{Kilometraje}");

        }
        public string[] itemView()
        {
            string[] data = { Marca,
                    Modelo, Convert.ToString(Precio) };
            return data;
        }
    }
}
