using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class UserController : Controller
    {   private readonly IUser user;
        public UserController(IUser _user)
        {
            user = _user;
        }   
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Users";
            UserViewModel model = new(user);
            await model.InitializeNewsAsync();
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Title = "Users";
            UserViewModel model = new(user);
            model.User = await  user.GetUsersById(id);
            return View(model);
        }
        
        
    }
}
