using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_telefonica
{
    internal interface ILlamada
    {
        public string num_origen { get; set; }
        public string num_destino { get; set; }
        public string duracion { get; set; }
        public void llamada(string Num_origen,string NuM_dest,string franja);
        public double Calcular_precio(double duracion, string franja);

        public string get_numero_destino();

        public string get_numero_origen();

        public string get_duracion_call();


    }
}
