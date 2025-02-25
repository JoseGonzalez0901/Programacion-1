using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingrese un número de 5 dígitos: ");
                int num5 = int.Parse(Console.ReadLine());
                if (num5 >= 10000 && num5 <= 99999)
                {
                    
                    Console.WriteLine("El número es capicúa: " + EsCapicua(num5));
                    break;
                }
                else
                {
                    Console.WriteLine("Intente de nuevo y digite un numero de 5 digitos");
                }
            }
        }
        static bool EsCapicua(int num)
        {
            string s = num.ToString();
            return s == new string(s.Reverse().ToArray());
        }
    }
}