using Herencia_con_Interfaces;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humanoide androide = new Humanoide();
            androide.Hablar();
            androide.ProcesarDatos();
        }
    }
}