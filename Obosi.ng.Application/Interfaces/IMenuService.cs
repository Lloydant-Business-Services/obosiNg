using Obosi.ng.Application.DTO;
using Obosi.ng.Domain.Entity;
using Obosi.ng.Infrastructure.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IMenuService
    {

        Task<IEnumerable<MenuDTO>> GetAllMenu();//read
        Task<bool> ModifyMenu(ModifyMenuDTO modifyMenuDTO); // update
       // Task<User> GetUser(string email);//read
        Task<MenuDisplayGroup> GetMenu(string email);
        // add delete menu 
    }
}
