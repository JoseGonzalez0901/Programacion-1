using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_telefonica
{
    internal class Llamada_local : Llamada
    {
        public double precio= 15;
        public Llamada_local(string origen, string destino) : base(origen, destino)
        {
        }
        public Llamada_local() { }  
        public virtual double Calcular_precio()
        {
            return duracion*precio;

        }



    }
}
