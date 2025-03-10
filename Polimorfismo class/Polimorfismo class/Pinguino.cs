using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pinguino:Ave
    {
        public Pinguino(string especie,string comida):base(especie,comida)
        {
            this.Capacidad_de_volar = false;
        }

        public string Deslizar()
        {
            return $"Soy {Especie} y puedo deslizarme por la nieve";
        }

    }
}
