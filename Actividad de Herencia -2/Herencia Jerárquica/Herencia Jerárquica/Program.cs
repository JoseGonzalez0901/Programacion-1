using Herencia_Jerárquica;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo = new Circulo(5);
            Rectangulo miRectangulo = new Rectangulo(4, 6);

            Console.WriteLine($"Área del círculo: {miCirculo.Area()}");
            Console.WriteLine($"Área del rectángulo: {miRectangulo.Area()}");
        }
    }
}