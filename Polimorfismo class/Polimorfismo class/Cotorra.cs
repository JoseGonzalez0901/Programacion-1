using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cotorra:Ave
    {
        public Cotorra(string especie,string comida):base(especie,comida)
        {
        this.Capacidad_de_volar = true;
        }
        public string Imitar()
        {
            return $"Soy {Especie} Puedo imitar voces";
        }

    }
}
