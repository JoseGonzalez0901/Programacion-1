using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Híbrida
{
    internal class Estudiante:Persona
    {
        public Estudiante(string nombre) : base(nombre) { }

        public void Estudiar()
        {
            Console.WriteLine($"{Nombre} está estudiando.");
        }
    }
}
