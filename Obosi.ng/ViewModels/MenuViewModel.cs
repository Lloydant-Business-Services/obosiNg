using Obosi.ng.Application.Enums;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class MenuViewModel
    {
        private readonly IMenuService menuService;
        public MenuViewModel(IMenuService _menuService)
        {
            menuService = _menuService;
        }
        public MenuViewModel()
        {
                
        }
        public async Task InitializeAsync()
        {
            this.Roles = await menuService.GetAllRoleList();
            this.MenuInRoles = await menuService.GetAllMenuInRoles();
            this.Menus = await menuService.GetAllMenuList();

        }
        public List<Obosi.ng.Domain.Entity.Role> Roles { get; set; }
        public List<MenuInRole> MenuInRoles { get; set; }
        public List<Menu> Menus { get; set; }
        public Menu Menu { get; set; }
        public MenuInRole MenuInRole { get; set; }
    }
}
