using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Obosi.ng.Presentation.Controllers
{
    public class UnitController : Controller
    {
        public UnitController()
        {
                
        }
        public IActionResult Index(string Unit)
        {
            ViewBag.Title = "Units";
            return View();
        }
    }
}
