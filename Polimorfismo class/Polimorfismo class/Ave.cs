using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Ave
    {
        public string pluma {  get; set; }
        public string pico {  get; set; }
        public string Alas {  get; set; }
        public string Especie {  get; set; }
        public bool Capacidad_de_volar {  get; set; }
        
        public string Comida { get; set; }
        public Ave(string especie,string comida)
        {
            Especie = especie;
            Comida = comida;
        }
        public string Poner_huevo(int huevos)
        {
            return $"Soy una {Especie} y puse: " + huevos + " Huevos";
        }

        public string Volar()
        {
            if(Capacidad_de_volar==true)
            {
                return $"Soy {Especie} y puedo volar";
            }
            else
            {
                return $"Soy {Especie} y no puedo volar";
            }
            
        }
        public string Comer()
        {
            return $"Soy {Especie} y Como {Comida}";
        }
    }
}
