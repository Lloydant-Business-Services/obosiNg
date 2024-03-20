using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Domain.Entity
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        public string Controller { get; set; }

        public string ActionName { get; set; }

        public string DisplayName { get; set; }

        public int MenuGroupId { get; set; }
        public bool Active { get; set; }

        public virtual MenuGroup MenuGroup { get; set; }
    }
}
