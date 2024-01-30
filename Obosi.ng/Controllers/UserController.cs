using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Users";
            return View();
        }
        public IActionResult Details(int id)
        {
            ViewBag.Title = "Users";
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Title = "Users";
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Users";
            return View();
        }
        [HttpPost]
        public IActionResult Edit(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int id) 
        { }
    }
}
