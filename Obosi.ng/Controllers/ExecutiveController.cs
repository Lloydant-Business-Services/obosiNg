using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class ExecutiveController : Controller
    {
        private readonly IExecutive executive;
        private readonly IUnit unit;
        private readonly IUser user;
        public ExecutiveController(IExecutive _executive,IUnit _unit,IUser _user)
        {
            executive = _executive;
            unit = _unit;
            user = _user;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Executives";
            ExecutuveViewModel model = new ExecutuveViewModel(executive,unit,user);
            await model.InitializeExecutiveAsync();
            return View(model);
        }
        
        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Title = "Executives";
            ExecutuveViewModel model = new ExecutuveViewModel(executive, unit, user);
            await model.InitializeExecutiveAsync();
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Title = "Executives";
            ExecutuveViewModel model = new ExecutuveViewModel(executive, unit, user);
            await model.InitializeExecutiveAsync();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(ExecutuveViewModel model)
        {
            if(model.ExecutiveObject != null)
            {
                executive.CreateExecutive(model.ExecutiveObject);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Title = "Executives";
            ExecutuveViewModel model = new ExecutuveViewModel(executive, unit, user);
            await model.InitializeEditAsync(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(ExecutuveViewModel model)
        {
            if (model.ExecutiveObject != null)
            {
                executive.UpdateExecutive(model.ExecutiveObject);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await executive.DeleteExecutive(id);
            return RedirectToAction("Index");
        }
    }
}
