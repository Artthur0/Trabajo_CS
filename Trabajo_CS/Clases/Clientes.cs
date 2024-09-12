﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_CS.Clases
{
    internal class Clientes
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public decimal DineroD { get; set; }

        public Clientes()
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

    }
}
