﻿using Microsoft.AspNetCore.Mvc;
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
            var userEmail = IdentityExtensions.GetEmail(User.Identity);
            await  model.InitializVideoAsync(userEmail);
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Title = "Video";
            MediaViewModel model = new(media, unit);
            var userEmail = IdentityExtensions.GetEmail(User.Identity);
            await model.InitializVideoAsync(id, userEmail);
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Title = "Video";
            MediaViewModel model = new(media, unit);
            var userEmail = IdentityExtensions.GetEmail(User.Identity);
            await  model.InitializVideoAsync(userEmail);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(MediaViewModel model)
        {
            if (model.Video_Asset != null)
            {
                model.Video_Asset.Title = model.Video_Asset.Caption;
                model.Video_Asset.DateAdded = DateTime.Now;
                await media.CreateVideo(model.Video_Asset);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Title = "Video";
            MediaViewModel model = new(media, unit);
            var userEmail = IdentityExtensions.GetEmail(User.Identity);
            await model.InitializVideoAsync(id, userEmail);
            return View(model);
        }
        [HttpPost]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Edit(MediaViewModel model)
        {
            if (model.Video_Asset != null)
            {
                await media.UpdateVideo(model.Video_Asset);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            ViewBag.Title = "Video";
            MediaViewModel model = new(media, unit);
            await media.DeleteVideo(id);
            return RedirectToAction("Index");
        }
    }
}
