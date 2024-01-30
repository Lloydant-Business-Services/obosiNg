using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class DashBoardController : Controller
    {
        private readonly IUnit unit;
        public DashBoardController(IUnit _unit)
        {
            unit = _unit;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "DashBoard";
            DashBoardViewModel model = new(unit);
            await model.GetDashBoard();
            return View(model);
        }
    }
}
