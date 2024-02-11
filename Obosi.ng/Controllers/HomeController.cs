using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.utility;
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
        private readonly IUnit _unit;
        private readonly IUser _user;
        private readonly IMedia _media;
        private readonly IExecutive _executive;

        public HomeController(ILogger<HomeController> logger, INews news, IBlog blog, ICalender calender, IUnit unit, 
            IUser user, IMedia media, IExecutive executive)
        {
            _logger = logger;
            _news = news;
            _blog = blog;
            _calender = calender;
            _unit = unit;
            _user = user;
            _media = media;
            _executive = executive;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomePageViewModel(_news, _blog,_calender,_unit);
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
            var user = await _user.CreateUser(model.user,model.AkaId,model.UmunnaId,model.VillageId,model.ImeneId);
            if(user != null)
            {
                return RedirectToAction("Index", "DashBoard");
            }
            return View(model);
        }
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> AboutUs()
        {
            var model = new HomePageViewModel(_unit);
            return View(model);
        }
       
        public async Task<IActionResult> Executive()
        {
            var model = new HomePageViewModel(_unit);
            return View(model);
        }
        public async Task<IActionResult> Media()
        {
            var model = new HomePageViewModel(_unit);
            return View(model);
        }
        public async Task<IActionResult> MediaList()
        {
            var model = new HomePageViewModel(_unit);
            return View(model);
        }
       
        public async Task<IActionResult> Unit(string id)
        {
            int unitId = Convert.ToInt16(StringEncryption.Decrypt(id));
            var model = new HomePageViewModel(_unit,_calender,_media,_executive);
            await model.GetUnit(unitId);
            return View(model);
        }
        public async Task<IActionResult> UnitList(string id)
        {
            int unitId = Convert.ToInt16(StringEncryption.Decrypt(id));
            var model = new HomePageViewModel(_unit);
            await model.GetUnits(unitId);
            return View(model);
        }
        public async Task<IActionResult> Blog(string id)
        {
            var model = new HomePageViewModel(_news, _blog, _calender);
            await model.InitializeNewsAsync();
            int blogId = Convert.ToInt16(StringEncryption.Decrypt(id));
            await model.BlogInitailize(blogId);
            return View(model);
        }
        public async Task<IActionResult> BlogList()
        {
            var model = new HomePageViewModel(_news, _blog, _calender);
            await model.BlogInitailize();
            return View(model);
        }
        public async Task<IActionResult> News(string id)
        {
            var model = new HomePageViewModel(_news, _blog, _calender);
            await model.InitializeNewsAsync();
            int newsId = Convert.ToInt16(StringEncryption.Decrypt(id));
            await model.NewsInitializeValue(newsId);
            return View(model);
        }
        public async Task<IActionResult> NewsList()
        {
            var model = new HomePageViewModel(_news, _blog, _calender);
            await model.NewsInitializeValue();
            return View(model);
        }
    }
   
}