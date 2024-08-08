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
        private  readonly IHostEnvironment _hostingEnvironment;
        public UnitController(IUnit _unit, IHostEnvironment hostingEnvironment)
        {
           unit = _unit;
           _hostingEnvironment = hostingEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Unit Types";
            UnitViewModel model = new(unit);
            var userEmail = IdentityExtensions.GetEmail(User.Identity);
            await model.InitializeNewsAsync(userEmail);
            return View(model);
        }
        public async Task<IActionResult> Units(string Unit_Type)
        {
            int Unit_TypeId = Convert.ToInt16(StringEncryption.Decrypt(Unit_Type));
            UnitViewModel model = new(unit);
            var userEmail = IdentityExtensions.GetEmail(User.Identity);
            await model.GetUnit_TypeList(Unit_TypeId,userEmail);
            model.Unit_TypeId = Unit_TypeId;
            ViewBag.Title = model.Unit_Type.Name;
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Title = "Unit Details";
            UnitViewModel model = new(unit);
             model.Unit = await unit.GetUnit(id);
            return View();
        }
         
        
        public async Task<IActionResult> JoinUnit(int id)
        {
            ViewBag.Title = "Unit Types";
            UnitViewModel model = new(unit);
            model.Unit =await  unit.GetUnit(id);
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Create(int Unit_TypeId)
        {
            ViewBag.Title = "Create Unit";
            UnitViewModel model = new(unit);
            var userEmail = IdentityExtensions.GetEmail(User.Identity);
            await model.InitializeNewsAsync(userEmail);
            model.Unit = new();
            model.Unit.Unit_TypeId = Unit_TypeId;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(UnitViewModel model)
        {
            model.Unit.BackGroundImageUrl = await SaveImages.SaveImage(model.Image, _hostingEnvironment);
            await unit.CreateUnit(model.Unit);
            return RedirectToAction("Units", new { Unit_Type = StringEncryption.Encrypt(model.Unit.Unit_TypeId.ToString())});
        }
        [HttpGet]
        public async Task<IActionResult> CreateUnitType()
        {
            ViewBag.Title = "Create Unit Type";
            UnitViewModel model = new(unit);
            var userEmail = IdentityExtensions.GetEmail(User.Identity);
            await model.InitializeNewsAsync(userEmail);
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> CreateUnitType(UnitViewModel model)
        {
           await unit.CreateUnitType(model.Unit_Type);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> EditUnitType(int id)
        {
            ViewBag.Title = "Edit Unit Type";
            UnitViewModel model = new(unit);
            model.Unit_Type = await unit.GetUnitType(id);
            return View(model);
        }
        [HttpPost]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> EditUnitType(UnitViewModel model)
        {
            await unit.UpdateUnitType(model.Unit_Type);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Title = "Edit Unit";
            UnitViewModel model = new(unit);
            model.Unit = await unit.GetUnit(id);
            return View(model);
        }
        [HttpPost]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Edit(UnitViewModel model)
        {
            model.Unit.BackGroundImageUrl = await SaveImages.SaveImage(model.Image, _hostingEnvironment);
            await unit.UpdateUnit(model.Unit);
            return RedirectToAction("Units", new { Unit_Type = StringEncryption.Encrypt(model.Unit.Unit_TypeId.ToString())});
        }

    }
}
