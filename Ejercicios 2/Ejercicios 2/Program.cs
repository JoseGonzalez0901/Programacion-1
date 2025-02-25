using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Write("Ingrese un número de dos dígitos: ");
                int num1 = int.Parse(Console.ReadLine());
                if (num1 >= 10 && num1 <= 99)
                {
                    bool esPrimo = EsPrimo(num1);
                    Console.WriteLine("El número es " + (esPrimo ? "primo" : "no primo") + " y " + (num1 < 0 ? "negativo" : "positivo"));
                    break;
                }
                else
                {
                    Console.WriteLine("No es un digito de 2 digito, intente de nuevo");
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