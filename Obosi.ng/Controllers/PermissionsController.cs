using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class PermissionsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Permissions";
            return View();
        }
        public IActionResult Details(int id)
        {
            ViewBag.Title = "Permissions";
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Title = "Permissions";
            return View();
        }
        [HttpPost]
        public IActionResult Create(PermissionViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Permissions";
            return View();
        }
        [HttpPost]
        public IActionResult Edit(PermissionViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
       

    }
}
