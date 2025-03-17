using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_telefonica
{

    internal class Llamada:ILlamada
    {
        public string[] zona_horaria = { "+1", "+54" };

        private static Stopwatch crono = Stopwatch.StartNew();

        public  bool incall { get; set; }=false;
        public string num_origen { get ; set; }
        public string num_destino { get ; set ; }
        public double duracion { get; set; }
        
        public bool local=false;
        public double precio = 0.0f;

        public Llamada(string origen,string destino) 
        {
            this.num_origen=origen;
            this.num_destino=destino;
            crono.Stop();
        }
        public Llamada() { crono.Stop(); }
        public bool isLocal(string num)
        {
            if(num.Contains("+1"))
            {

                return local=true;
            }
            return local=false;

        }
        public void startcall()
        {
            if (!get_status_call())
            {
           
                crono.Start();
            }
        }
        public void Stopcall()
        {
        
                
                crono.Restart();
                crono.Stop();
            
        }
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
        private Thread hilo;
        public void llamada(string Num_origen, string Num_dest, string franja)
        {
            
            hilo = new Thread(() =>
            {
             
                while (true)
                {
                    duracion = crono.Elapsed.TotalSeconds;
                    if (!get_status_call()) { break; }
                       

                   

                    Thread.Sleep(100);
                }
               

            });

            hilo.IsBackground = true;
            hilo.Start();
            

        }
        public double get_duracion_call()
        {
            return duracion;
        }
        public void llamda_stop(Llamada llamada)
        {

            
            //llamada.Calcular_precio(duracion,"");
        }

        public double Calcular_precio(double duracion, string franja)
        {
            return duracion * 1.25f;
        }
    }
}
