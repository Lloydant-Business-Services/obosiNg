using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.DTO;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        
        public async Task<IActionResult> GetAllMenus()
        {
            try
            {
                var menus = await _menuService.GetAllMenu();
                return View("GetAllMenus", menus); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

      
        public async Task<IActionResult> GetUserMenus(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return BadRequest("Email is required");
            }

            try
            {
                var menus = await _menuService.GetMenu(email);
                return View("GetUserMenus", menus);
            }  
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

       
        public async Task<IActionResult> ModifyMenu( ModifyMenuDTO modifyMenuDTO)
        {
            

            try
            {
                var result = await _menuService.ModifyMenu(modifyMenuDTO);
                if (result)
                {
                    return Ok();
                }
                return NotFound("Menu not found");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }

}
