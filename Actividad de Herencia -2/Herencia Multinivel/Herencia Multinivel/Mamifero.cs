using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Multinivel
{
    internal class Mamifero : Animal
    {
        public void Amamantar()
        {
            Console.WriteLine("Este mamífero amamanta a sus crías.");
        }
    }
}
