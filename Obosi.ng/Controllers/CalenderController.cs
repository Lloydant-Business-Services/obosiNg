using Microsoft.AspNetCore.Mvc;

namespace Obosi.ng.Presentation.Controllers
{
    public class CalenderController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Calender";
            return View();
        }
    }
}
