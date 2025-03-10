using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Gallina:Ave
    {
        
        public Gallina(string especie, string comida):base(especie, comida) 
        {
            this.Capacidad_de_volar = false;
        
        }
        public string Cacareo()
        {
            return $"Soy {Especie} y puedo Cacarear... CUCURUCU";
        }

        

    }
}
