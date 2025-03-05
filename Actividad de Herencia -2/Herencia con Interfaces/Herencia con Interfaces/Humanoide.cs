using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_con_Interfaces
{
    internal class Humanoide : IHumano, IRobot
    {
        public void Hablar()
        {
            Console.WriteLine("Hola, soy un humanoide.");
        }

        public void ProcesarDatos()
        {
            Console.WriteLine("Procesando datos...");
        }

    }
}
