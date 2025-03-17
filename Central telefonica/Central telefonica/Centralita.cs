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
        public int getTotalLLamadas() {  return cont=Llamada_register.Count; }
        public double getACum() 
        { 
            foreach(Llamada item in Llamada_register)
            {
                acum += item.costo;
            }
            return acum;
        }

        public void registrarLlamada(Llamada llamada)
        {
            Llamada_register.Add(llamada);
            cont = Llamada_register.Count;
            acum += llamada.costo;
        }

        public void mostrarRegistro()
        {

            Call_Register_form call_Register_Form = new Call_Register_form(acum.ToString(),cont.ToString());
            foreach(Llamada llamada in Llamada_register)
            {
                call_Register_Form.InitGrig(llamada);
            }
        
            call_Register_Form.ShowDialog();
        }

    }
}
