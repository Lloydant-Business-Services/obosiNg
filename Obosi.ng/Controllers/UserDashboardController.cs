using Microsoft.AspNetCore.Mvc;

namespace Obosi.ng.Presentation.Controllers
{
    public class UserDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
