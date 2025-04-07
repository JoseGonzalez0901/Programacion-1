using Proyecto_Tienda_Virtual.Data_base;  // <-- Agregar esta línea
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using Proyecto_Tienda_Virtual.Models;

namespace Proyecto_Tienda_Virtual.Data_base_service
{
    public class Data_base_services
    {
      

        public List<Data_image> Get_data()
        {
            List<Data_image> data = new List<Data_image>();
            using (var context = new AppDbContext()) // Ahora AppDbContext será reconocido
            {

                var callManager = new DatabaseManager<Data_image>(context);
                var return_BD = callManager.GetAll();

                    foreach (var item in return_BD)
                    {
                        Data_image data_image = (Data_image)item;
                        data.Add(data_image);
                    }
                
                
            }
            return data;
        }
        public Data_image Get_data(int id)
        {
            using (var context = new AppDbContext()) // Ahora AppDbContext será reconocido
            {
                var callManager = new DatabaseManager<Data_image>(context);
                var return_BD = callManager.GetById(id);
                return return_BD;
            }
            return new Data_image();
        }
    }
}
