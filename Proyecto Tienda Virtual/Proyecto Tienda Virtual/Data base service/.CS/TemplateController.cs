using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Tienda_Virtual.Data_base_service;
using Proyecto_Tienda_Virtual.Models;

namespace Proyecto_Tienda_Virtual.Controllers
{
    public class TemplateController : Controller
    {
        static int page {  get; set; }
        static Data_ImageViewModel images = new Data_ImageViewModel();
        // GET: TemplateController
        public ActionResult Index(int page = 0)
        {
            int itemsPerPage = 6;
            
            Data_base_services service = new Data_base_services();

            List<Data_image> allImages = service.Get_data();
            int totalItems = allImages.Count;
            int totalPages = (int)Math.Ceiling((double)totalItems / itemsPerPage);

            // Selecciona solo los elementos de la página actual
            images.DataImages = allImages.Skip(page * itemsPerPage).Take(itemsPerPage).ToList();
            images.CurrentPage = page;
            images.TotalPages = totalPages;
            CarryoutController car_count = new CarryoutController(null);
            TempData["items"] = car_count.Get_count_list();
            return View(images);
        }
        public IActionResult Add_car(int ItemID)
        {
            Data_base_services services = new Data_base_services();
            Carryout Car=new Carryout(services.Get_data(ItemID));
            CarryoutController carryoutController = new CarryoutController(Car);
            CarryoutController car_count = new CarryoutController(null);
            TempData["items"] = car_count.Get_count_list();
            TempData["MostrarToast"] = true;
            return View("Index",images);
        }

        // GET: TemplateController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TemplateController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TemplateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TemplateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TemplateController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TemplateController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TemplateController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
