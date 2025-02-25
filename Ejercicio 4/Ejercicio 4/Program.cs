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
                string num = Console.ReadLine();
           int   num1 = int.Parse(num);
            if (num1<=10&&num1>=99)
            {
                    Console.WriteLine("La suma es " + ((num[0] - '0' + num[1]-'0') % 2 == 0 ? "par" : "impar"));
                    break;
            }
            else
            {
                Console.WriteLine("Intente de nuevo y ingrese un numero de dos digitos");
            }
            }
        }
    }
}