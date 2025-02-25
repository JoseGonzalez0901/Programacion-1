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
                string num = Console.ReadLine();
                int num3 = int.Parse(num);
                if (num3 >= 100 && num3 <= 999)
                {
                    num3 = 0;
                    foreach (var item in num)
                    {
                        if(item-'0'>num3)
                        {
                            num3=item-'0';
                        }
                    }
                    Console.WriteLine("El numero mayor es:"+num3);
                    break;
                }
                else
                {
                    Console.WriteLine("Intente de nuevo y digite un numero de 3 digitos");
                }
            }
        }
    }
}
