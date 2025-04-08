using Microsoft.AspNetCore.Mvc;
using Proyecto_Tienda_Virtual.Data_base_service;
using Proyecto_Tienda_Virtual.Models;

namespace Proyecto_Tienda_Virtual.Controllers
{
    public class CarryoutController : Controller
    {
        static CarryoutViewModel CarryoutViewModel { get; set; }
        public CarryoutController(Carryout To_car) 
        {
            if (CarryoutViewModel == null)
            {
                CarryoutViewModel = new CarryoutViewModel();  // Inicializar si es null
            }
            if (CarryoutViewModel.carryoutList == null)
            {
                CarryoutViewModel.carryoutList = new List<Carryout>();  // Inicializar la lista si es null
            }
            if(To_car!=null)
            {
            if(To_car.Header!=null)
            {
              Add_to_car(To_car);
            }
            }
        }
        [HttpPost]
        public IActionResult EliminarDelCarrito(int id)
        {
            if (CarryoutViewModel.carryoutList.Any(i => i.ID == id))
            {
                int index = CarryoutViewModel.carryoutList.FindIndex(i => i.ID == id);
                CarryoutViewModel.carryoutList.Remove(CarryoutViewModel.carryoutList[index]);
            }

            return View("Index",CarryoutViewModel);
        }

        public IActionResult Index()
        {
            TempData["items"] = Get_count_list();

                TempData["view_button"] = "view";
            
            return View(CarryoutViewModel);
        }
        [HttpPost]
        public IActionResult ClearCar()
        {
            CarryoutViewModel.carryoutList?.Clear();
            return View("Index", CarryoutViewModel);
        }
        public int Get_count_list()
        {
            return CarryoutViewModel.carryoutList.Count;
        }
        
        public void Add_to_car(Carryout item)
        {
            
            if (CarryoutViewModel.carryoutList.Any(i => i.ID == item.ID))
            {
                 int index = CarryoutViewModel.carryoutList.FindIndex(i => i.ID == item.ID);
                CarryoutViewModel.carryoutList[index].Cantidad += 1;
            }
            else
            {
                item.Cantidad += 1;
                CarryoutViewModel.carryoutList.Add(item);
            }

        }
        
    }
}
