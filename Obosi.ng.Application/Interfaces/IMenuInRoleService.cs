using Obosi.ng.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IMenuInRoleService
    {
        Task<IEnumerable<MenuDTO>> GetMenuBy(int RoleId);
        Task<List<MenuDTO>> GetMenuBy(string RoleId);
    }
}
