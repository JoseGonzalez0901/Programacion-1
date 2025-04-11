using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Tienda_Virtual.Data_base_service;
using Proyecto_Tienda_Virtual.Models;
using System.IdentityModel.Tokens.Jwt;

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
            Current_Cart current_Cart = new Current_Cart();

           
            if (CarryoutViewModel.carryoutList.Any(i => i.ID == id))
            {
                int index = CarryoutViewModel.carryoutList.FindIndex(i => i.ID == id);
                current_Cart.Delete_Item(CarryoutViewModel.carryoutList[index].Current_ID,CarryoutViewModel.carryoutList[index]);
            }

            return View("Index",CarryoutViewModel);
        }

        public IActionResult Index()
        {
            JwtHelper jwtHelper = new JwtHelper();

            var key = jwtHelper.GetUserIdFromToken(Request);
            TempData["items"] = Get_count_list(key);

            TempData["view_button"] = "view";
            
            Set_current_cart();

            return View(CarryoutViewModel);
        }
        [HttpPost]
        public IActionResult ClearCar()
        {
            CarryoutViewModel.carryoutList?.Clear();
            return View("Index", CarryoutViewModel);
        }
        public int Get_count_list(string key)
        {
            Set_current_cart(key);
            return CarryoutViewModel.carryoutList.Count;
        }
        private void Set_current_cart(string key)
        {

            Current_Cart current_Cart = new Current_Cart();
            CarryoutViewModel.carryoutList = current_Cart.Get_current_cart(key);

        }
        private void Set_current_cart()
        {
            JwtHelper jwtHelper = new JwtHelper();

            var key = jwtHelper.GetUserIdFromToken(Request);
            
            Current_Cart current_Cart = new Current_Cart();
            CarryoutViewModel.carryoutList = current_Cart.Get_current_cart(key);
            
        }

        [HttpGet]
        public IActionResult AgregarProducto(int item)

        {
            Data_base_services services = new Data_base_services();
            Carryout Car = new Carryout(services.Get_data(item));

            JwtHelper jwtHelper = new JwtHelper();

            Car.Current_ID = jwtHelper.GetUserIdFromToken(Request);
            Current_Cart current_Cart = new Current_Cart(Car);
            Set_current_cart();
            return RedirectToAction("Index","Template");
        }
        public void Add_to_car(Carryout item)
        {
            //Car.Current_ID = "401bc559-04ba-43b7-8684-0d8eed835c7d"
            //Car.Current_ID = "63feb85a-4150-4d0e-a82f-6fce91f3726e"
            //userId = "63feb85a-4150-4d0e-a82f-6fce91f3726e"



        }

    }
}
