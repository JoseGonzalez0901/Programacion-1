using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro número entero: ");
            int num6 = int.Parse(Console.ReadLine());
            int min = Math.Min(num1, num6);
            int max = Math.Max(num1, num6);
            if (max - min <= 10)
            {
                for (int i = min; i <= max; i++)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}