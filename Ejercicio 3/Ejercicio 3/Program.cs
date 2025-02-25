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
                if (num1>=10&&num1<=99)
                {
                bool digitosPrimos = EsPrimo(num1 / 10) && EsPrimo(num1 % 10);
                Console.WriteLine("Ambos dígitos son primos: " + digitosPrimos);
                }
                else
                {
                    Console.WriteLine("Intente de nuevo y ingrese un numero de dos cifras");
                }
            }
        }
        static bool EsPrimo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}