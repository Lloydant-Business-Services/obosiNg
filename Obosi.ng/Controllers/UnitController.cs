using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.utility;
using Obosi.ng.Presentation.ViewModels;
using System.Globalization;

namespace Obosi.ng.Presentation.Controllers
{
    public class UnitController : Controller
    {
        private readonly IUnit unit;
        public UnitController(IUnit _unit)
        {
           unit = _unit;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Unit Types";
            UnitViewModel model = new(unit);
            await model.InitializeNewsAsync();
            return View(model);
        }
        public async Task<IActionResult> Units(string unittype)
        {
            int unitTypeId = Convert.ToInt16(StringEncryption.Decrypt(unittype));
            UnitViewModel model = new(unit);
            await model.GetUnitTypeList(unitTypeId);
            ViewBag.Title = "Unit Types";
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Title = "Unit Detaisl";
            UnitViewModel model = new(unit);
             model.Unit = await unit.GetUnit(id);
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Title = "Unit Types";
            return View();
        }
        [HttpPost]
        public IActionResult Create(UnitViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Unit Types";
            return View();
        }
        [HttpPost]
        public IActionResult Edit(UnitViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int id) { }

    }
}
