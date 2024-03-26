 using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.utility;
using Obosi.ng.Presentation.ViewModels;
using System.Security.Claims;

namespace Obosi.ng.Presentation.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlog blog;
        private readonly IHostEnvironment _hostingEnvironment;
        public BlogController(IBlog _blog, IHostEnvironment hostingEnvironment)
        {
            blog = _blog;
            _hostingEnvironment = hostingEnvironment;
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
            if (model?.Blog != null)
            {
                var userRole = IdentityExtensions.GetId(User.Identity);
                var role = IdentityExtensions.GetRole(User.Identity);
                if (role == 3)
                {
                    model.Blog.UserId = Convert.ToInt32(userRole);
                    model.Blog.BackgroundImageUrl = await SaveImages.SaveImage(model.Image, _hostingEnvironment);
                    await blog.CreateBlog(model.Blog);
                    return RedirectToAction("Index");
                }
            }
            await model.InitializeNewsAsync();
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
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Edit(BlogViewModel model)
        {
            if (model.Blog!= null)
            {
                model.Blog.BackgroundImageUrl = await SaveImages.SaveImage(model.Image, _hostingEnvironment);
                await blog.UpdateBlog(model.Blog);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
           await blog.DeleteBlog(id);
            return RedirectToAction("index");
        }
        public async Task<IActionResult> Approve(int id)
        {
            await blog.ApproveBlog(id);
            return RedirectToAction("index");
        }
        public async Task<IActionResult> Publish(int id)
        {
            await blog.PublishBlog(id);
            return RedirectToAction("index");
        }
    }
}
