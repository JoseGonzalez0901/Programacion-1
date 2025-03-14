using System.Diagnostics;

namespace Central_telefonica
{
    public partial class Form1 : Form
    {
        Llamada Call_in = new Llamada();
        Llamada_provincial llamada_provincial = new Llamada_provincial();

        public Form1()
        {
            InitializeComponent();


        }



        private void Start_Click(object sender, EventArgs e)
        {

            Call_in.set_status(true);

            if (Call_in.isLocal(Num_dest.Text))
            {
                label1.BackColor = Color.Green;
                //Llamada llamada_local=new Llamada_Local();
            }
            else
            {
                label1.BackColor = Color.Green;
                llamada_provincial = new Llamada_provincial(Num_origin.Text, Num_dest.Text);
                llamada_provincial.llamada(Num_dest.Text, Num_dest.Text, "");
                
                llamada_provincial.startcall();
                llamada_provincial.set_status(true);

            }

            // Call_in.llamada(Num_destino_txbox.Text, zona);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            
            llamada_provincial.Stopcall();
            llamada_provincial.set_status(false);
            Call_in.set_status(false);

            if (Call_in.local)
            {

            }
            else
            {

                llamada_provincial.llamda_stop(llamada_provincial);

            }

            label1.BackColor = Color.Red;

        }

        private void Call_duration_Tick(object sender, EventArgs e)
        {
            if(Call_in.get_status_call())
            {
                if(Call_in.local)
                {

                }
                else
                {
                    Duracion_label.Text=llamada_provincial.get_duracion_call().ToString();
                }
                

            }
        }
    }
}
