using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class CalenderController : Controller
    { private readonly ICalender calender;
        public CalenderController(ICalender _calender)
        {
            calender = _calender;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Calender";
            CalenderViewModel model = new(calender);
            await model.InitializeNewsAsync();
            return View(model);
        }
    }
}
