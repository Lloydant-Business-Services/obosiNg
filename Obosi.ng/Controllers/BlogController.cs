using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlog blog;
        public BlogController(IBlog _blog)
        {
            blog = _blog;
        }
        public async Task<IActionResult> Index()
        {
            BlogViewModel model = new(blog);
            await model.InitializeNewsAsync();
            ViewBag.Title = "Blogs";
            return View(model);
        }
    }
}
