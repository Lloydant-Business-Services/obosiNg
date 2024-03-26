using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class PermissionsController : Controller
    {
        private readonly IUnit _unit;
        private readonly IUser _user;
        public PermissionsController(IUnit unit, IUser user)
        {
                _unit = unit;
            _user = user;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Unit Admins";
			PermissionViewModel model = new PermissionViewModel(_user,_unit);  
            await model.InitializeUnitAdmins();
			return View(model);
        }
       
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Title = "Create Unit Admin";
            PermissionViewModel model = new PermissionViewModel(_user, _unit);
            await model.InitializeAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(PermissionViewModel model)
        {
            if (model != null)
            {
               await _unit.CreateAdmin(model.UnitObject);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async  Task<IActionResult> Delete(int id)
        {
            ViewBag.Title = "Permissions";
            await  _unit.DeleteAdmin(id);
            return RedirectToAction("Index");
        }
       
       

    }
}
