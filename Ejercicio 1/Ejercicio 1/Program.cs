using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingrese un número de dos dígitos: ");
                int num1 = int.Parse(Console.ReadLine());
                if(num1>=10&&num1<=99)
                {
                    int suma = (num1 / 10) + (num1 % 10);
                    Console.WriteLine("La suma de sus dígitos es: " + suma);
                }
                else
                {
                    Console.WriteLine("Intente de nuevo y oingrese un numero de dos digitos");
                }
               
            }
        }
    }
}