using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pato:Ave
    {
        public Pato(string especie,string comida):base(especie, comida)
        {

            this.Capacidad_de_volar = true;
        }
        public string Nadar()
        {
            return $"Soy {Especie} y puedo nadar";
        }
    }
}
