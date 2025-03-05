using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{

    internal class vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
        }

    }
}
