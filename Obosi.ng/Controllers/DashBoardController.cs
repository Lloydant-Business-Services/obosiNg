using Microsoft.AspNetCore.Mvc;

namespace Obosi.ng.Presentation.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "DashBoard";
            return View();
        }
    }
}
