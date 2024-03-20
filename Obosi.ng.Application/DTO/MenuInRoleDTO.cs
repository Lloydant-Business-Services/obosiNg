using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.DTO
{
    public  class MenuInRoleDTO
    {
        public int Id { get; set; }
        public long MenuId { get; set; }
        public virtual MenuDTO Menu { get; set; }
        public bool Activated { get; set; }
        public int RoleId { get; set; }

        public virtual RoleDTO Role { get; set; }
    }
}
