using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;
using Obosi.ng.Presentation.utility;
using Obosi.ng.Presentation.ViewModels;
using Serilog;
using System.Security.Claims;
using System.Text.Json;
using static Obosi.ng.Presentation.ViewModels.HomePageViewModel;

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
        private readonly IAboutService _about;



        public HomeController(ILogger<HomeController> logger, INews news, IBlog blog, ICalender calender, IUnit unit,
        IUser user, IMedia media, IExecutive executive, IAboutService about)
        {
            _logger = logger;
            _news = news;
            _blog = blog;
            _calender = calender;
            _unit = unit;
            _user = user;
            _media = media;
            _executive = executive;
            _about = about;

        }

        public async Task<IActionResult> Index()
        {
            var model = new HomePageViewModel(_news, _blog, _calender, _unit);
            await model.InitializeNewsAsync();
            string apiUrl = "https://blogs.obosi.ng/wp-json/obosi/v1/latest-posts";

            // Create an instance of HttpClient
            using var httpClient = new HttpClient();

            // Send a GET request to the API
            var response = await httpClient.GetAsync(apiUrl);

            // Check the response status code
            if (response.IsSuccessStatusCode)
            {
                // Read the response content as a string
                var responseContent = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON content to a C# model
                var myModel = JsonSerializer.Deserialize<List<BlogTitles>>(responseContent);

                model.AnnouncementTitlesList = myModel;
            }
            string apiUrl2 = "https://blogs.obosi.ng/wp-json/obosi/v1/latest-posts-from-categories";

            // Create an instance of HttpClient
            //using var httpClient = new HttpClient();

            // Send a GET request to the API
            var response2 = await httpClient.GetAsync(apiUrl2);

            // Check the response status code
            if (response2.IsSuccessStatusCode)
            {
                // Read the response content as a string
                var responseContent2 = await response2.Content.ReadAsStringAsync();

                // Deserialize the JSON content to a C# model
                var myModel2 = JsonSerializer.Deserialize<List<BlogTitles>>(responseContent2);

                model.categoriesTitlesList = myModel2;
            }
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

            try
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
                    //if (user.RoleId == 2)
                    //{
                        return RedirectToAction("ViewUserProfile", "User");
                    //}
                    //else
                    //{
                    //    return RedirectToAction("Index", "DashBoard");
                    //}

                }
            }
            catch (Exception ex)
            {
                model.ErrorMessage = ex.Message;
                Log.Error($"SignIn Method-{ex.Message}", ex);
            }

            return View(model);
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
            try
            {
                model.user.RoleId = (int)Application.Enums.Role.User;
                var user = await _user.CreateUser(model.user, model.AkaId, model.UmunnaId, model.VillageId, model.ImeneId);
                if (user?.IsActive != true)
                {

                    return RedirectToAction("Confirmation", "Home");
                }
            }
            catch (Exception ex)
            {
                model = new HomePageViewModel(_unit);
                model.ErrorMessage = ex.Message;
                await model.GetAllUmunna();
                Log.Error($"SignUp Method-{ex.Message}", ex);
                return View(model);
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Confirmation()
        {
            var model = new HomePageViewModel(_news, _blog, _calender, _unit);
            await model.InitializeNewsAsync();
            return View(model);
        }
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> About()
        {
            var model = new HomePageViewModel(_news, _blog, _calender, _unit);
            await model.InitializeNewsAsync();
            return View(model);
        }

        public async Task<IActionResult> Executive()
        {
            var model = new HomePageViewModel(_news, _blog, _calender, _unit);
            return View(model);
        }
        public async Task<IActionResult> Media()
        {
            var model = new HomePageViewModel(_news, _blog, _calender, _unit);
            return View(model);
        }
        public async Task<IActionResult> MediaList()
        {
            var model = new HomePageViewModel(_news, _blog, _calender, _unit);
            return View(model);
        }

        public async Task<IActionResult> Unit(string id)
        {
            int unitId = Convert.ToInt16(StringEncryption.Decrypt(id));
            var model = new HomePageViewModel(_unit, _calender, _media, _executive);
            await model.GetUnit(unitId);
            return View(model);
        }
        public async Task<IActionResult> UnitList(string id)
        {
            int unitId = Convert.ToInt16(StringEncryption.Decrypt(id));
            var model = new HomePageViewModel(_news, _blog, _calender, _unit);
            await model.GetUnits(unitId);
            return View(model);
        }
        public async Task<IActionResult> Events(string id)
        {
            int unitId = Convert.ToInt16(StringEncryption.Decrypt(id));
            var model = new HomePageViewModel(_unit, _calender, _media, _executive);
            await model.GetEvent(unitId);
            return View(model);
        }
        public async Task<IActionResult> EventList()
        {

            var model = new HomePageViewModel(_news, _blog, _calender, _unit);
            await model.GetEvents();
            return View(model);
        }
        public async Task<IActionResult> Blog(string id)
        {
            var model = new HomePageViewModel(_news, _blog, _calender, _unit);
            await model.InitializeNewsAsync();
            int blogId = Convert.ToInt16(StringEncryption.Decrypt(id));
            await model.BlogInitailize(blogId);
            return View(model);
        }
        public async Task<IActionResult> BlogList()
        {
            var model = new HomePageViewModel(_news, _blog, _calender, _unit);
            await model.BlogInitailize();
            return View(model);
        }
        public async Task<IActionResult> News(string id)
        {
            var model = new HomePageViewModel(_news, _blog, _calender, _unit);
            await model.InitializeNewsAsync();
            int newsId = Convert.ToInt16(StringEncryption.Decrypt(id));
            await model.NewsInitializeValue(newsId);
            return View(model);
        }
        public async Task<IActionResult> NewsList()
        {
            var model = new HomePageViewModel(_news, _blog, _calender, _unit);
            await model.NewsInitializeValue();
            return View(model);
        }
        public async Task<IActionResult> EventsList()
        {
            var model = new HomePageViewModel(_news, _blog, _calender, _unit);
            await model.NewsInitializeValue();
            return View(model);
        }
        public async Task<IActionResult> AboutUs(int pageId)
        {
            var model = new HomePageViewModel(_news, _about, _blog, _calender, _unit);
            await model.NewsInitializeValue();
            await model.GetAbout(pageId);
            model.PageId = pageId;
            return View(model);
        }
        public async Task<List<Village>> GetVillages()
        {
            return await _unit.GetVillages();
        }
        public async Task<List<Aka>> GetAkas(int villageId)
        {
            return await _unit.Akas(villageId);
        }
        public async Task<List<Umunna>> GetUmunna(int akaId)
        {
            return await _unit.GetUmunnas(akaId);
        }
        public async Task<List<Imenne>> GetImenes(int umunnaId)
        {
            return await _unit.GetImennes(umunnaId);
        }
        public async Task<IActionResult> Policy()
        {
            var model = new HomePageViewModel(_news, _about, _blog, _calender, _unit);
            await model.NewsInitializeValue();
            return View(model);
        }
    }

}