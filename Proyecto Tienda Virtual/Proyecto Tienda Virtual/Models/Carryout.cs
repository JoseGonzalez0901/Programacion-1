namespace Proyecto_Tienda_Virtual.Models
{
    public class Carryout:Data_image
    {
        public string Current_ID { get; set; }
        public Carryout(Data_image Data)
        {
            this.Url = Data.Url;
            this.Content = Data.Content;
            this.Header = Data.Header;
            this.ID = Data.ID;
            this.Precio = Data.Precio;
            this.Cantidad = Data.Cantidad;
        }
        public Carryout() { }
    }
}
