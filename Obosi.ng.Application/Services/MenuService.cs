using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.DTO;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
using Obosi.ng.Domain.Entity;
using Obosi.ng.Infrastructure.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Services
{
    public class MenuService : IMenuService
    {
        private readonly DataContext _context;
        public MenuService(DataContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<MenuDTO>> GetAllMenu()
        {
            return await _context.Menu
                .Include(f => f.MenuGroup)
                .Select(f => new MenuDTO
                {
                    ActionName = f.ActionName,
                    DisplayName = f.DisplayName,
                    Controller = f.Controller,
                    Active = f.Active,
                    MenuGroupId = f.MenuGroupId,
                    MenuGroup = f.MenuGroup.Name,
                    MenuId = f.Id,
                    Status = f.Active ? "Active" : "In-Active",

                })
                .ToListAsync();
        }
        public async Task<bool> ModifyMenu(ModifyMenuDTO modifyMenuDTO)
        {
            if (modifyMenuDTO?.MenuGroupId > 0 && modifyMenuDTO ?.MenuId > 0)
            {
                var menu = await _context.Menu.Where(f => f.Id == modifyMenuDTO.MenuId).FirstOrDefaultAsync();
                if (menu?.Id > 0) {
                    menu.MenuGroupId = modifyMenuDTO.MenuGroupId;
                    menu.DisplayName = modifyMenuDTO.DisplayName;
                    menu.Controller = modifyMenuDTO.ControllerName;
                    menu.ActionName = modifyMenuDTO.ActionName;
                    menu.Active = modifyMenuDTO.IsActive;

                  await _context.SaveChangesAsync();
                   return true;
                }
                
            }
            return false;
        }
        /*public async Task<User> GetUser(string email)
        {
            try
            {
                return await _context.Users.Where(u => u.Email == email)
                    .Include(x => x.Role)
                    .FirstOrDefaultAsync(); 
            }
            catch (Exception ex) { throw ex; }
        }*/

        public async Task<MenuDisplayGroup> GetMenu(string email)
        {
            try
            {
                var user = await _context.Users.Where(x => x.Email == email).FirstOrDefaultAsync(); 
                var menuroles = await _context.MenuInRole.Where(x => x.RoleId == user.RoleId)
                    .Include(x => x.Menu.MenuGroup).ToListAsync();
                MenuDisplayGroup group = new();
                group.Grouping = new List<MenuGrouping>();
                var groups = menuroles.GroupBy(x => x.Menu.MenuGroupId).Select(x => x.FirstOrDefault()).ToList();
                foreach (var items in groups)
                {
                    MenuGrouping menuGrouping = new();
                    menuGrouping.MenuGroup = items.Menu.MenuGroup;
                    menuGrouping.Menu = menuroles.Where(x => x.Menu.MenuGroupId == items.Menu.MenuGroupId)
                        .Select(x => new Menu()
                        {
                            ActionName = x.Menu.ActionName,
                            Controller = x.Menu.Controller,
                            DisplayName = x.Menu.DisplayName,
                            Id = x.Menu.Id
                        }).ToList();
                    group.Grouping.Add(menuGrouping);
                }
                return group;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
