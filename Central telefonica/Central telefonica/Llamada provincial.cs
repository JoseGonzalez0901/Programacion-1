﻿using Central_telefonica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_telefonica
{

internal class Llamada_provincial:Llamada
    {
       
        public double precio1 = 1.25f;
        public double precio2 = 1.25f;
        public double precio3 = 1.25f;
        public string franja{ get; set; }
        public Llamada_provincial(string origen, string destino):base(origen,destino)
        {

        }
        public Llamada_provincial() { }
        public virtual double Calcular_precio(double duracion, string franja)
        {
            if (franja==this.franja)
            {
                return precio1 * duracion;
            }
            return 0;
        }



    }
}
