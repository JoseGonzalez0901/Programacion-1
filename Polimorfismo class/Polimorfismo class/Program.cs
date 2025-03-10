using ConsoleApp2;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gallina Gallina = new Gallina("Gallina", "Maiz");

            Alcon Alcon = new Alcon("Alcon Pelegrino", "Avez");

            Pato pato = new Pato("Pato", "Pan");

            Pinguino pinguino = new Pinguino("pinguino", "Peces");

            Cotorra cotorra = new Cotorra("Cotorra", "Semillas");
            Console.WriteLine(Gallina.Poner_huevo(5));
            Console.WriteLine(Alcon.Volar());
            Console.WriteLine(pato.Nadar());
            Console.WriteLine(Gallina.Cacareo());
            Console.WriteLine(pinguino.Deslizar());
            Console.WriteLine(cotorra.Imitar());
        }
    }
}