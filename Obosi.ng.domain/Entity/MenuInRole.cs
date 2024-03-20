using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Domain.Entity
{
    public class MenuInRole
    {
        [Key]
        public int Id { get; set; }

        public int RoleId { get; set; }

        public virtual Role Role { get; set; }

        public int MenuId { get; set; }

        public virtual Menu Menu { get; set; }
    }

    public class MenuDisplayGroup
    {
        public List<MenuGrouping> Grouping { get; set; }

    }
    public class MenuGrouping
    {
        public MenuGroup MenuGroup { get; set; }
        public List<Menu> Menu { get; set; }
    }
}
