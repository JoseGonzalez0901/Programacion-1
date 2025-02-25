using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingrese un número de 4 dígitos: ");
                int num4 = int.Parse(Console.ReadLine());
                if (num4 >= 1000 && num4 <= 9999)
                {

                    Console.WriteLine("El segundo dígito es igual al penúltimo: " + ((num4 / 10) % 10 == (num4 / 100) % 10));
                    break;
                }
                else
                {
                    Console.WriteLine("Intente de nuevo y digite un numero de 4 digitos");
                }
            }
        }
    }
}