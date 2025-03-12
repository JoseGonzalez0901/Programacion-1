using System.Diagnostics;

namespace Central_telefonica
{
    public partial class Form1 : Form
    {
        Llamada Call_in = new Llamada("+1829");
        Stopwatch crono = Stopwatch.StartNew();
        public Form1()
        {
            InitializeComponent();

            
        }

        
 
        private void Start_Click(object sender, EventArgs e)
        {
           

            Call_in.set_status(true);
            string zona=Call_in.analisis_zona_horaria(Num_destino_txbox.Text);
            crono.Start();
            label1.BackColor = Color.Green;
            // Call_in.llamada(Num_destino_txbox.Text, zona);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Call_in.set_status(false);
            crono.Stop();
            label1.BackColor = Color.Red;
            Duracion_label.Text=crono.Elapsed.ToString();  
        }
    }
}
