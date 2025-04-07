namespace Proyecto_Tienda_Virtual.Models
{
    public class Data_ImageViewModel
    {
        public List<Data_image> DataImages { get; set; }
        public Data_image data_Image { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
