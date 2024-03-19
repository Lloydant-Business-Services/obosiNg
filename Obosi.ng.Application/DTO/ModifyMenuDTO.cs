using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.DTO
{
    public class ModifyMenuDTO
    {
        public int MenuId { get; set; }
        public string DisplayName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public int MenuGroupId { get; set; }
        public bool IsActive { get; set; }
    }
}
