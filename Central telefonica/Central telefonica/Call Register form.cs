using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Central_telefonica
{
    public partial class Call_Register_form : Form
    {
        public Call_Register_form(string Total_precio,string Total_calls)
        {
            InitializeComponent();
            Precio_total_label.Text = Total_precio;
            Total_llamada_label.Text=Total_calls;

        }
        internal void InitGrig(Llamada llamada)
        {
            Register_view.Rows.Add(llamada.num_origen, llamada.num_destino, llamada.duracion, llamada.costo);
        }
    }
}
