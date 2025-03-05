using Herencia_Híbrida;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante_Atleta persona1 = new Estudiante_Atleta("Carlos");
            persona1.Presentarse();
            persona1.Estudiar();
            persona1.Entrenar();
            persona1.RutinaDiaria();
        }
    }
}