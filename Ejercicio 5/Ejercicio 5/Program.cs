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
                    string mayorPos = MayorPosicion(num3);
                    Console.WriteLine(mayorPos);
                }
                else
                {
                    Console.WriteLine("Intente de nuevo y digite un numero de 3 digitos");
                }
            }
        }
        static string MayorPosicion(int num)
        {
            int c = num / 100, d = (num / 10) % 10, u = num % 10;
            if (c >= d && c >= u) return "El mayor dígito está en la centena";
            if (d >= u) return "El mayor dígito está en la decena";
            return "El mayor dígito está en la unidad";
        }
    }
}