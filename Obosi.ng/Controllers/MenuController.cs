using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using Obosi.ng.Application.DTO;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;
using Obosi.ng.Presentation.utility;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public async Task<IActionResult> Index()
        {
            MenuViewModel model = new MenuViewModel(_menuService);
            await model.InitializeAsync();
            return View(model);
        }
       
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            MenuViewModel model = new MenuViewModel(_menuService);
            await model.InitializeAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(MenuViewModel model)
        {
            if(model.MenuInRole != null)
            {
              await _menuService.CreateMenuInRole(model.MenuInRole);
                return RedirectToAction("Index");
            }
            await model.InitializeAsync();
            return View(model);
        }
       
        public async Task<IActionResult> Delete(int id)
        {
            await _menuService.DeleteMenuInRole(id);
            return RedirectToAction("Index");
        }

    }

}
