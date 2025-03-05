using Herencia_Multinivel;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato miGato = new Gato();

            miGato.Comer();
            miGato.Amamantar();
            miGato.Maullar();
        }
    }
}