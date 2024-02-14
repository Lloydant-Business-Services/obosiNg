using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class BoulevardController : Controller
    {
        private readonly IBoulevard _boulevard;
        public BoulevardController(IBoulevard boulevard)
        {
            _boulevard = boulevard;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            BoulevardViewModel model = new(_boulevard);
            await model.InitializeAsync();
            return View(model);
        }
        public async Task<IActionResult> BoulevardList()
        {
            BoulevardViewModel model = new(_boulevard);
            await model.InitializeAsync();
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            BoulevardViewModel model = new(_boulevard);
            await model.InitializeAsync();
            model.builders_Boulevard = await _boulevard.GetBoulevardById(id);
            return View(model);
        }  
        public async Task<IActionResult> Create()
        {
            BoulevardViewModel model = new(_boulevard);
            await model.InitializeAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BoulevardViewModel model)
        {
            if (model.builders_Boulevard != null)
            {   
                model.builders_Boulevard.DateAdded = DateTime.Now; 
                await _boulevard.CreateBoulevard(model.builders_Boulevard);
                return RedirectToAction("BoulevardList");
            }
            return View(model);
        }   
        public async Task<IActionResult> Edit(int id)
        {
            BoulevardViewModel model = new(_boulevard);
            await model.InitializeAsync();
            model.builders_Boulevard = await _boulevard.GetBoulevardById(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BoulevardViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _boulevard.UpdateBoulevard(model.builders_Boulevard);
                return RedirectToAction("BoulevardList");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _boulevard.DeleteBoulevard(id);
            return RedirectToAction("Index");
        }
    }
}
