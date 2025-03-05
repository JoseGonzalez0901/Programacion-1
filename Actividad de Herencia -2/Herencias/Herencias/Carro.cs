using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    internal class Carro:vehiculo
    {
        public int Puertas { get; set; }

        public Carro(string marca, string modelo, int puertas) : base(marca, modelo)
        {
            Puertas = puertas;
        }

        public new void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Puertas: {Puertas}");
        }
    }
}
