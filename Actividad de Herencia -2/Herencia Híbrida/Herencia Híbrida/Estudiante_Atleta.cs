using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Híbrida
{
    internal class Estudiante_Atleta : Estudiante, IAtleta
    {
        public Estudiante_Atleta(string nombre) : base(nombre) { }

        public void Entrenar()
        {
            Console.WriteLine($"{Nombre} está entrenando.");
        }

        public void RutinaDiaria()
        {
            Console.WriteLine($"{Nombre} estudia y entrena todos los días.");
        }
    }
}
