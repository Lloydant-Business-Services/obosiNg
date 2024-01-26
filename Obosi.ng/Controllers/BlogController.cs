using Microsoft.AspNetCore.Mvc;

namespace Obosi.ng.Presentation.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Blogs";
            return View();
        }
    }
}
