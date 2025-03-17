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
        public Call_Register_form()
        {
           
            InitializeComponent();
            Register_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        internal void InitGrig(Llamada llamada)
        {
            Register_view.Rows.Add(llamada.num_origen, llamada.num_destino, llamada.duracion, llamada.precio);
        }
    }
}
