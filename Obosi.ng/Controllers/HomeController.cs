using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.ViewModels;
using System.Diagnostics;

namespace Obosi.ng.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INews _news;
        private readonly IBlog _blog;
        private readonly ICalender _calender;

        public HomeController(ILogger<HomeController> logger, INews news, IBlog blog, ICalender calender)
        {
            _logger = logger;
            _news = news;
            _blog = blog;
            _calender = calender;
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

        public IActionResult SignIn()
        {
            return View();  
        }
        public IActionResult SignUp()
        {
            return View();
        }


    }
}