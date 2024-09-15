using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public void clientes(){
        
        
        
        
        }


    }
}
