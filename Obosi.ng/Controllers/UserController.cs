using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Application.Services;
using Obosi.ng.Domain.Entity;
using Obosi.ng.Infrastructure.Migrations;
using Obosi.ng.Presentation.utility;
using Obosi.ng.Presentation.ViewModels;
using System.Security.Claims;
using System.Security.Principal;

namespace Obosi.ng.Presentation.Controllers
{
    public class UserController : Controller
    {   private readonly IUser _user;
        private readonly IUnit unit;
        private readonly IHostEnvironment _hostingEnvironment;
        public IConfiguration _Configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserController(IUser user, IUnit _unit, IConfiguration Configuration, IHttpContextAccessor httpContextAccessor,
            IHostEnvironment hostingEnvironment)
        {
            _user = user;
            unit = _unit;
            _Configuration = Configuration;
            _httpContextAccessor = httpContextAccessor;
            _hostingEnvironment = hostingEnvironment;
        }   
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Users";
            UserViewModel model = new(_user, unit);
            await model.InitializeNewsAsync();
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Title = "Users";
            UserViewModel model = new(_user, unit);
            model.User = await  _user.GetUsersById(id);
            return View(model);
        }

        public async Task<IActionResult> UnApproveUsers()
        {
            ViewBag.Title = "Approve Users";
            UserViewModel model = new(_user, unit);
            await model.InitializeNewsAsync();
            return View(model);
        }
        public async Task<IActionResult> ApproveUsers(string username,int unitId)
        {
            await _user.ActivateUser(username, unitId);
            return RedirectToAction("UnApproveUsers");
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            ViewBag.Title = "View Profile";
            UserViewModel model = new(_user, unit);
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
                await _user.UpdateUser(model.User);
            }
            var claimsPrincipal =  _httpContextAccessor.HttpContext.User;
            string userEmail = claimsPrincipal.FindFirst(ClaimTypes.Email).Value;
            model = new(_user, unit);
            await model.InitializeNewsAsync(userEmail);
  
            return RedirectToAction("Profile");
        }

        // GET: /Users/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.Title = "Create Users";
            UserViewModel model = new(_user, unit);
            await model.InitializeNewsAsync();
            return View(model);
        }

        // POST: /Users/Create
        [HttpPost]
        public async Task<IActionResult> Create(UserViewModel userViewModel)
        {
            if (userViewModel != null )
            {
                try
                {
                    var createdUser = await _user.CreateUser_Admin(userViewModel.User);
                       

                    return RedirectToAction("index");
                }
                catch (Exception ex)
                {
                    UserViewModel model = new(_user, unit);
                     
                    await model.InitializeNewsAsync();
                    userViewModel = model;
                    userViewModel.Error = ex.Message;
                    return View(userViewModel);

                }
            }
            return View(userViewModel);
        }

        // GET: /Users/Create
        public async Task<IActionResult> Edit(int Id)
        {
            ViewBag.Title = "Edit Users";
            UserViewModel model = new(_user, unit);
            await model.InitializeNewsAsync(Id);
            return View(model);
        }

        // POST: /Users/Create
        [HttpPost]
        public async Task<IActionResult> Edit(UserViewModel userViewModel)
        {
            if (userViewModel != null)
            {
                try
                {
                    var createdUser = await _user.UpdateUser(userViewModel.User);


                    return RedirectToAction("index");
                }
                catch (Exception ex)
                {
                    UserViewModel model = new(_user, unit);

                    await model.InitializeNewsAsync();
                    userViewModel = model;
                    userViewModel.Error = ex.Message;
                    return View(userViewModel);

                }
            }
            return View(userViewModel);
        }
    }
}
