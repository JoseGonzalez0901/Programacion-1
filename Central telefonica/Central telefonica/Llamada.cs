using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_telefonica
{

    internal class Llamada
    {
        public string[] zona_horaria = { "+1", "+54" };
        public string num_origen { get; set; }
        public string num_destino { get; set; }
        public double duracion { get; set; }

        public bool incall { get; set; }=false;
        public Llamada(string input) 
        {
            this.num_origen=input;
        }
        public string analisis_zona_horaria(string num)
        {
            foreach (var item in zona_horaria)
            {
                if(num.Contains(item))
                {
                    return item;
                }

            }
            return string.Empty;

        }
       /* public TimeSpan llamada(string num,string franja) 
        {


            return crono.Elapsed;
        
        }*/
        public bool get_status_call()
        {
            return incall;
        }
        public void set_status(bool status)
        {
            incall = status;
        }
        public string get_numero_origen()
        {
            return num_origen;
        }
        public string get_numero_destino()
        {
            return num_destino;
        }
        
        public double Calcular_precio() { return 1.25f; }

    }
}
