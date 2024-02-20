using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.utility;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class CalenderController : Controller
    { private readonly ICalender calender;
        private readonly IHostEnvironment _hostingEnvironment;
        private readonly IUnit unit;    
        public CalenderController(ICalender _calender, IHostEnvironment hostingEnvironment, IUnit _unit)
        {
            calender = _calender;
            _hostingEnvironment = hostingEnvironment;
            unit = _unit;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Calender";
            CalenderViewModel model = new(calender);
            await model.InitializeNewsAsync();
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Title = "Calender";
            CalenderViewModel model = new(calender);
            await model.InitializeNewsAsync();
            model.Calender_Asset = await calender.GetAssets(id);
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Title = "Calender";
            CalenderViewModel model = new(calender,unit);
            await model.InitializeNewsAsyncUnits();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CalenderViewModel model)
        {
            if (model.Calender_Asset != null)
            {
                await calender.CreateAsset(model.Calender_Asset);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Title = "Calender";
            CalenderViewModel model = new(calender,unit);
            await model.InitializeNewsAsyncUnits();
            model.Calender_Asset = await calender.GetAssets(id);
            return View(model);
        }
        [HttpPost]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Edit(CalenderViewModel model)
        {
            if (model.Calender_Asset != null)
            {
                await calender.UpdateAsset(model.Calender_Asset);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            ViewBag.Title = "Calender";
            CalenderViewModel model = new(calender);
            await model.InitializeNewsAsync();
            return View(model);
        }
    }
}
