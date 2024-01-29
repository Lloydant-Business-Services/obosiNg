using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Presentation.utility;
using System.Globalization;

namespace Obosi.ng.Presentation.Controllers
{
    public class UnitController : Controller
    {
        public UnitController()
        {
                
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Unit Types";
            return View();
        }
        public IActionResult Units(string unittype)
        {
            int unitTypeId = Convert.ToInt16(StringEncryption.Decrypt(unittype));
            ViewBag.Title = "Unit Types";
            return View();
        }

    }
}
