using System.ComponentModel.DataAnnotations;

namespace Proyecto_Tienda_Virtual.Models
{
    public class Data_image
    {
        [Key]
        public int ID { get; set; } 

        public string Url { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public float Precio { get; set; }

        public int Cantidad { get; set; }

    }
}
