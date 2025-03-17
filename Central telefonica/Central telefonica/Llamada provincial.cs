using Central_telefonica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_telefonica
{

internal class Llamada_provincial:Llamada
    {
       
        public double precio1 = 20f;
        public double precio2 = 25f;
        public double precio3 = 30f;
        public string[] franja= { "+54","+36","+408" };
        public Llamada_provincial(string origen, string destino):base(origen,destino)
        {

        }
        public Llamada_provincial() { }
        public virtual double Calcular_precio(string franja)
        {
            foreach(var item in  this.franja)
            {
                if (item.Contains(this.franja[0]))
                {
                    return precio1 * duracion;
                }
                else if (item.Contains(this.franja[1])) 
                { 
                    return precio2 * duracion;
                }
                else if (item.Contains(this.franja[2]))
                { 
                    return precio3 * duracion;
                }
            }
            
            return 0;
        }



    }
}
