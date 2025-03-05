using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Jerárquica
{
    internal class Circulo : FiguraGeometrica
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}
