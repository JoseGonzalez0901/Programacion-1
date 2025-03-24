using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_telefonica
{

    public class Llamada:ILlamada
    {

        private static Stopwatch crono = Stopwatch.StartNew();
        [Key]  // Definir clave primaria
        public int Id { get; set; }
        [NotMapped]
        private  bool incall { get; set; }=false;
        [Column("Numero de origen")]
        public string num_origen { get ; set; }
        public double costo { get; set; }
        [Column("Numero de destino")]
        public string num_destino { get ; set ; }
        public double duracion { get; set; }
        
        
        
       public  enum Estado
        {
            Local=0,
            Fuera_de_rango=1,
            Internacional=2
        }
        
        public Llamada(string origen,string destino) 
        {
            this.num_origen=origen;
            this.num_destino=destino;
            crono.Stop();
        }
        public Llamada() { crono.Stop(); }
        public Estado isLocal(string num)
        {
            Llamada_provincial llamada_Provincial = new Llamada_provincial();
            
           
            if(num.Contains("+1"))
            {

                return Estado.Local;
            }
            foreach(var item in llamada_Provincial.franja)
            {
                if(num.Contains(item))
                {
                    return Estado.Internacional;
                }
            }
            MessageBox.Show("Llamada fuera de rango");
            return Estado.Fuera_de_rango;

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
                    duracion = Math.Round (crono.Elapsed.TotalSeconds,2);
                    if (!get_status_call()) 
                    {
                        crono.Restart();
                        crono.Stop();
                        break;
                    }
                       
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
