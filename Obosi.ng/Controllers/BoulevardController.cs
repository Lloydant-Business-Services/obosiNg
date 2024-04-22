using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class BoulevardController : Controller
    {
        private readonly IBoulevard _boulevard;
        private readonly IUnit _unit;
        public BoulevardController(IBoulevard boulevard, IUnit unit)
        {
            _boulevard = boulevard;
            _unit = unit;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index(int page)
        {
            BoulevardViewModel model = new(_boulevard, _unit);
            if (page == null)
            {
                page = 1;
            }
            model.pageNo = page;
            await model.InitializeAsync(page);
            return View(model);
        }
        public async Task<IActionResult> BoulevardList()
        {
            BoulevardViewModel model = new(_boulevard, _unit);
            await model.InitializeAsync();
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            BoulevardViewModel model = new(_boulevard, _unit);
            await model.InitializeAsync();
            model.builders_Boulevard = await _boulevard.GetBoulevardById(id);
            return View(model);
        }
        public async Task<IActionResult> Create()
        {
            BoulevardViewModel model = new(_boulevard, _unit);
            await model.InitializeAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BoulevardViewModel model)
        {
            if (model.builders_Boulevard != null)
            {
                //model.builders_Boulevard.DateAdded = DateTime.Now; 
                await _boulevard.CreateBoulevard(model.builders_Boulevard);
                return RedirectToAction("BoulevardList");
            }
            return View(model);
        }
        public async Task<IActionResult> Edit(int id)
        {
            BoulevardViewModel model = new(_boulevard, _unit);
            await model.InitializeAsync();
            model.builders_Boulevard = await _boulevard.GetBoulevardById(id);
            return View(model);
        }
        [HttpPost]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Edit(BoulevardViewModel model)
        {
            if (model != null)
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
