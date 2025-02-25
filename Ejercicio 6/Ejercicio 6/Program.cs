using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingrese un número de tres dígitos: ");
                int num3 = int.Parse(Console.ReadLine());
                if (num3 >= 100 && num3 <= 999)
                {
                    Console.WriteLine(EsMultiplo(num3));
                }
                else
                {
                    Console.WriteLine("Intente de nuevo y digite un numero de 3 digitos");
                }
            }
        }
        static string EsMultiplo(int num)
        {
            int c = num / 100, d = (num / 10) % 10, u = num % 10;
            return (c % d == 0 || c % u == 0 || d % u == 0) ? "Algún dígito es múltiplo de otro" : "Ningún dígito es múltiplo de otro";
        }
    }
}