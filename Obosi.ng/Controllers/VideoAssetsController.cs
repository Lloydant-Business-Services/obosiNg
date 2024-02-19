using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.utility;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class VideoAssetsController : Controller
    {
        private readonly IMedia media;
        private readonly IHostEnvironment _hostingEnvironment;
        private readonly IUnit unit;    
        public VideoAssetsController(IMedia _media, IHostEnvironment hostingEnvironment, IUnit _unit)
        {
            media = _media; 
            _hostingEnvironment = hostingEnvironment;
            unit = _unit;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Video";
            MediaViewModel model = new(media,unit);
          
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Title = "Calender";
            MediaViewModel model = new(media, unit);
          
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Title = "Calender";
            MediaViewModel model = new(media, unit);
           
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(MediaViewModel model)
        {
            if (model.Video_Asset != null)
            {
               
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Title = "Calender";
            MediaViewModel model = new(media, unit);
           
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(MediaViewModel model)
        {
            if (model.Video_Asset != null)
            {
             
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            ViewBag.Title = "Video";
            MediaViewModel model = new(media, unit);
         
            return View(model);
        }
    }
}
