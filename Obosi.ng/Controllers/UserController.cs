using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class UserController : Controller
    {   private readonly IUser user;
        private readonly IUnit unit;
        public UserController(IUser _user, IUnit _unit)
        {
            user = _user;
            unit = _unit;   
        }   
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Users";
            UserViewModel model = new(user, unit);
            await model.InitializeNewsAsync();
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Title = "Users";
            UserViewModel model = new(user, unit);
            model.User = await  user.GetUsersById(id);
            return View(model);
        }

        public async Task<IActionResult> UnApproveUsers()
        {
            ViewBag.Title = "Approve Users";
            UserViewModel model = new(user, unit);
            await model.InitializeNewsAsync();
            return View(model);
        }
        public async Task<IActionResult> ApproveUsers(string username,int unitId)
        {
            await user.ActivateUser(username, unitId);
            return RedirectToAction("UnApproveUsers");
        }
        
        
    }
}
