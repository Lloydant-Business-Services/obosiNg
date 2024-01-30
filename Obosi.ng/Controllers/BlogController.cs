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
        public async Task<IActionResult> Details(int id)
        {
            BlogViewModel model = new(blog);
            await model.InitializeNewsAsync();
            model.Blog = await blog.GetBlogsById(id);
            ViewBag.Title = "Blogs";
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            BlogViewModel model = new(blog);
            await model.InitializeNewsAsync();
            ViewBag.Title = "Blogs";
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BlogViewModel model)
        {
            if (ModelState.IsValid)
            {
                await blog.CreateBlog(model.BlogDto);
                return RedirectToAction("Index");
            }
            return View(model);
        }   
        public async Task<IActionResult> Edit(int id)
        {
            BlogViewModel model = new(blog);
            await model.InitializeNewsAsync();
            model.Blog = await blog.GetBlogsById(id);
            ViewBag.Title = "Blogs";
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BlogViewModel model)
        {
            if (ModelState.IsValid)
            {
                await blog.UpdateBlog(model.Blogs_Update);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
           await blog.DeleteBlog(id);
            return RedirectToAction("index");
        }   
    }
}
