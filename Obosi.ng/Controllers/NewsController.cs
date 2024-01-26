using Microsoft.AspNetCore.Mvc;

namespace Obosi.ng.Presentation.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "News";
            return View();
        }
    }
}
