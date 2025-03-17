using System.Diagnostics;

namespace Central_telefonica
{
    public partial class Form1 : Form
    {
        Llamada Call_in = new Llamada();
        Llamada_provincial llamada_provincial = new Llamada_provincial();
        Llamada_local llamada_Local=new Llamada_local();
        Centralita centralita = new Centralita();
        Llamada.Estado estado = new Llamada.Estado();

        public Form1()
        {
            InitializeComponent();

        }



        private void Start_Click(object sender, EventArgs e)
        {
            
            if (Num_origin.Text != "" && Num_dest.Text != "")
            {

                    
                    estado = Call_in.isLocal(Num_dest.Text);
                    
                    if(estado!=Llamada.Estado.Fuera_de_rango)
                    {
                    Call_in.set_status(true);
                    label1.BackColor = Color.Green;
                }
                    if (estado==Llamada.Estado.Local)
                     {

                    llamada_Local=new Llamada_local(Num_origin.Text,Num_dest.Text);
                    llamada_Local.startcall();
                    llamada_Local.set_status(true);
                    llamada_Local.llamada(Num_dest.Text, Num_origin.Text,"");
                 
                    }
                    else if(estado==Llamada.Estado.Internacional)
                    {
                    llamada_provincial = new Llamada_provincial(Num_origin.Text, Num_dest.Text);
                    llamada_provincial.startcall();
                    llamada_provincial.set_status(true);
                    llamada_provincial.llamada(Num_origin.Text, Num_dest.Text, "");

                  

                    }
                else
                {
                    Duracion_label.Text = "???";
                    label1.BackColor = Color.Blue;
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos");
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (Call_in.get_status_call())
            {


                Call_in.set_status(false);
                llamada_provincial.set_status(false);

            if (Call_in.isLocal(Num_dest.Text)==Llamada.Estado.Local)
                {
                    double precio = llamada_Local.Calcular_precio();
                    llamada_Local.costo= Math.Round( precio,2);
                    centralita.registrarLlamada(llamada_Local);
                }
            else if(Call_in.isLocal(Num_dest.Text)==Llamada.Estado.Internacional)
                {
                    double precio = llamada_provincial.Calcular_precio(Num_dest.Text);
                    llamada_provincial.costo= Math.Round(precio, 2);
                    centralita.registrarLlamada(llamada_provincial);


                }

                label1.BackColor = Color.Red;
            }

        }


        private void Call_duration_Tick(object sender, EventArgs e)
        {
            if (Call_in.get_status_call())
            {
                if (estado==Llamada.Estado.Local)
                {
                    Duracion_label.Text=llamada_Local.get_duracion_call().ToString();

                }
                else if(estado == Llamada.Estado.Internacional)
                {
                    Duracion_label.Text = llamada_provincial.get_duracion_call().ToString();
                }



            }
        }

        private void Show_register_Click(object sender, EventArgs e)
        {
            centralita.mostrarRegistro();

        }
    }
}
