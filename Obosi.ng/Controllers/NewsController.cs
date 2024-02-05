using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.utility;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class NewsController : Controller
    {
        private readonly INews news;
        private readonly IHostEnvironment _hostingEnvironment;
        public NewsController(INews _news, IHostEnvironment hostingEnvironment)
        {
            news = _news;
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "News";
            NewsViewModel model = new(news);
            await model.InitializeNewsAsync();
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Title = "News Details";
            NewsViewModel model = new();
            model.NewsObject = await news.GetNewsById(id);    
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Title = "Create News";
            NewsViewModel model = new(news);
            await model.InitializeNewsAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewsViewModel model)
        {
            if (model?.NewsObject!= null)
            {
                var userRole = IdentityExtensions.GetId(User.Identity);
                model.NewsObject.UserId = Convert.ToInt32(userRole);
                model.NewsObject.BackgroundImageUrl = await SaveImages.SaveImage(model.Image, _hostingEnvironment);
                await news.CreateNews(model.NewsObject);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Title = "News";
            NewsViewModel model = new();
            model.NewsObject =  await news.GetNewsById(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(NewsViewModel model)
        {
            if (ModelState.IsValid)
            {
                await news.UpdateNews(model.News_Update);    
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(int id) 
        {
            await news.DeleteNews(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Approve(int id)
        {
            await news.ApproveNews(id);
            return RedirectToAction("index");
        }
        public async Task<IActionResult> Publish(int id)
        {
            await news.PublishNews(id);
            return RedirectToAction("index");
        }

    }
}
