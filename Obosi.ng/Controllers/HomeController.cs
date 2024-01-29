using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.ViewModels;
using System.Diagnostics;
using System.Security.Claims;

namespace Obosi.ng.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INews _news;
        private readonly IBlog _blog;
        private readonly ICalender _calender;
        private readonly Icalender _unit;
        private readonly IUser _user;

        public HomeController(ILogger<HomeController> logger, INews news, IBlog blog, ICalender calender, Icalender unit, IUser user)
        {
            _logger = logger;
            _news = news;
            _blog = blog;
            _calender = calender;
            _unit = unit;
            _user = user;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomePageViewModel(_news, _blog,_calender);
            await model.InitializeNewsAsync();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> SignIn()
        {
            var model = new HomePageViewModel(_unit);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(HomePageViewModel model)
        {
           var user = await _user.AuthenticateUser(model.Username, model.Password);
            if (user?.Id > 0)
            {
                var identity = new ClaimsIdentity(new[] {
                         new Claim(ClaimTypes.Email, user.Email),
                         new Claim(ClaimTypes.Role, user.Role.Name),
                         new Claim(ClaimTypes.GroupSid, user.RoleId.ToString()),
                         new Claim(ClaimTypes.Sid, user.Id.ToString())
                        }, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);
                if (!model.RememberPassword)
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                else
                    await HttpContext.SignInAsync(
                                            CookieAuthenticationDefaults.AuthenticationScheme, principal,
                                                new AuthenticationProperties
                                                {
                                                    IsPersistent = true
                                                });
                return RedirectToAction("Index", "DashBoard");

            }
            throw new Exception("User Not Found");
            
        }
        [HttpGet]
        public async Task<IActionResult> SignUp()
        {
            var model = new HomePageViewModel(_unit);
            await model.GetAllUmunna();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(HomePageViewModel model)
        {
            
            return View(model);
        }
    }
   
}