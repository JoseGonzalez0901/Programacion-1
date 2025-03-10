using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Alcon:Ave
    {
        public Alcon(string especie,string comida):base(especie,comida) 
        {
            this.Capacidad_de_volar = true;
        }
        public string Cazar()
        {
            return $"Soy {Especie} y puedo cazar";
        }
    }

}
