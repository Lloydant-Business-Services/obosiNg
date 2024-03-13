using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.utility;
using Obosi.ng.Presentation.ViewModels;
using System.Security.Claims;
using System.Security.Principal;

namespace Obosi.ng.Presentation.Controllers
{
    public class UserController : Controller
    {   private readonly IUser user;
        private readonly IUnit unit;
        private readonly IHostEnvironment _hostingEnvironment;
        public IConfiguration _Configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserController(IUser _user, IUnit _unit, IConfiguration Configuration, IHttpContextAccessor httpContextAccessor,
            IHostEnvironment hostingEnvironment)
        {
            user = _user;
            unit = _unit;
            _Configuration = Configuration;
            _httpContextAccessor = httpContextAccessor;
            _hostingEnvironment = hostingEnvironment;
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
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            ViewBag.Title = "View Profile";
            UserViewModel model = new(user, unit);
            var claimsPrincipal = _httpContextAccessor.HttpContext.User;
            string userEmail = claimsPrincipal.FindFirst(ClaimTypes.Email).Value;
            await model.InitializeNewsAsync(userEmail);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(UserViewModel model)
        {
            ViewBag.Title = "View Profile";
            model.User.PassportUrl =  await SaveImages.SaveImage(model.Image, _hostingEnvironment);
            if (model != null)
            {
                await user.UpdateUser(model.User);
            }
            var claimsPrincipal =  _httpContextAccessor.HttpContext.User;
            string userEmail = claimsPrincipal.FindFirst(ClaimTypes.Email).Value;
            model = new(user, unit);
            await model.InitializeNewsAsync(userEmail);
  
            return View(model);
        }

    }
}
