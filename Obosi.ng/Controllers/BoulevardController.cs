using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;
using Obosi.ng.Presentation.ViewModels;
using System.Globalization;

namespace Obosi.ng.Presentation.Controllers
{
    public class BoulevardController : Controller
    {
        private readonly IBoulevard _boulevard;
        private readonly IUnit _unit;
		private readonly INews _news;
		private readonly IBlog _blog;
		private readonly ICalender _calender;
		private readonly IUser _user;
		private readonly IMedia _media;
		private readonly IExecutive _executive;
		private readonly IAboutService _about;
		public BoulevardController(IBoulevard boulevard, IUnit unit, IBlog blog, ICalender calender, IExecutive executive)
        {
            _boulevard = boulevard;
            _unit = unit;
            _blog = blog;
            _calender = calender;
            _executive = executive;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index(int page)
        {
            //BoulevardViewModel model = new(_boulevard, _unit);
			var model = new HomePageViewModel( _unit, _calender, _media, _executive, _boulevard);
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
