using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.DTO
{
    public class MenuDTO
    {
        public int MenuInRoleId { get; set; }
        public int MenuId { get; set; }
        public string Status { get; set; }
        public string Controller { get; set; }

        public string ActionName { get; set; }

        public string DisplayName { get; set; }

        public int MenuGroupId { get; set; }
        public bool Active { get; set; }
        public string MenuGroup { get; set; }
        public string RoleName { get; set; }
    }
}
