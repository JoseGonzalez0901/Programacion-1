using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_telefonica
{
    
    internal class Centralita
    {
        private int cont = 0;
        private double acum = 0.0f;
        List<Llamada> Llamada_register=new List<Llamada>();
        public int getTotalLLamadas() {  return cont; }
        public double getACum() { return acum; }

        public void registrarLlamada(Llamada llamada)
        {
            Llamada_register.Add(llamada);
        }

    }
}
