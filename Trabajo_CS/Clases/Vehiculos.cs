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
            string[] data = { Marca,
                    Modelo, Convert.ToString(Año), Convert.ToString(Kilometraje), Convert.ToString(Precio) };
            return data;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"{Marca} - {Modelo} - {Año} - {Kilometraje} - {Precio}");

        }

        public override string ToString()
        {
            return $"{Marca} - {Modelo} - {Año}";
        }

    }
}
