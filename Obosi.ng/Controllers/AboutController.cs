using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.DTO;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IHostEnvironment _hostingEnvironment;

        public AboutController(IAboutService aboutService, IHostEnvironment hostingEnvironment)
        {
            _aboutService = aboutService;
            _hostingEnvironment = hostingEnvironment;   
        }

        // GET : About
        public async Task<IActionResult> Index()
        {
            var abouts = await _aboutService.GetAllAbouts();
            var viewModel = new AboutViewModel
            {
                Abouts = abouts
            };
            return View(viewModel);
        }

        //GET: About/Create
        public IActionResult Create()
        {
            var viewModel = new AboutViewModel
            {
                About = new About()
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AboutViewModel aboutViewModel)
        {
            if (aboutViewModel.About != null)
            {
                var createdAbout = await _aboutService.CreateAbout(aboutViewModel.About);
                return RedirectToAction(nameof(Index));
            }

            return View(aboutViewModel);
        }


        // POST: About/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(AboutViewModel aboutDTO)
        {
            
            if (aboutDTO != null)
            {
                var updatedAbout = await _aboutService.UpdateAbout(aboutDTO.About);
                return RedirectToAction(nameof(Index));
            }

           
            return NotFound();
        }
        // GET: About/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var about = await _aboutService.GetAboutById(id);
            if (about == null)
            {
                return NotFound();
            }

            var viewModel = new AboutViewModel
            {
                About = about
            };

            return View(viewModel);
        }

        // GET: About/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var about = await _aboutService.GetAboutById(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }

        // POST: About/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _aboutService.DeleteAbout(id);
            return RedirectToAction(nameof(Index));
        }
    }

}
