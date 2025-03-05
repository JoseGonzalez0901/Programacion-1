using Herencias;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro miCarro = new Carro("Toyota", "Corolla", 4);

            miCarro.MostrarInfo();
        }
    }
}