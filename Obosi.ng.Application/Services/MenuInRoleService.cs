using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.DTO;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Services
{
    public class MenuInRoleService : IMenuInRoleService
    {
        private readonly DataContext _context;
        public MenuInRoleService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MenuDTO>> GetMenuBy(int RoleId)
        {
            return await _context.MenuInRole
                .Include(f => f.Menu)
                .ThenInclude(f => f.MenuGroup)
                .Include(f => f.RoleId)
                .Where(f => f.RoleId == RoleId)
                .Select(f => new MenuDTO
                {
                    ActionName = f.Menu.ActionName,
                    DisplayName = f.Menu.DisplayName,
                    Controller = f.Menu.Controller,
                    Active = f.Menu.Active,
                    MenuGroup = f.Menu.MenuGroup.Name,
                    RoleName = f.Role.Name,
                    MenuGroupId = f.Menu.MenuGroupId,
                    MenuId = f.MenuId,
                    MenuInRoleId = f.Id,
                    Status = f.Menu.Active ? "Active" : "In-Active",
                })
                .ToListAsync();
        }
        public async Task<List<MenuDTO>> GetMenuBy(string RoleId)
        {
            int id = Convert.ToInt32(RoleId);
            return await _context.MenuInRole
                 .Include(f => f.Menu)
                .ThenInclude(f => f.MenuGroup)
                .Include(f => f.Role)
                .Where(f => f.RoleId == id && f.Menu.Active)
                .Select(f => new MenuDTO
                {
                    ActionName = f.Menu.ActionName,
                    DisplayName = f.Menu.DisplayName,
                    Controller = f.Menu.Controller,
                    Active = f.Menu.Active,
                    MenuGroup = f.Menu.MenuGroup.Name,
                    RoleName = f.Role.Name,
                    MenuGroupId = f.Menu.MenuGroupId,
                    MenuId = f.MenuId,
                    MenuInRoleId = f.Id,
                    Status = f.Menu.Active ? "Active" : "In-Active",
                })
                .ToListAsync();
        }
    }
}
