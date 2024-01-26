using Microsoft.AspNetCore.Mvc;

namespace Obosi.ng.Presentation.Controllers
{
    public class PermissionsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Permissions";
            return View();
        }
    }
}
