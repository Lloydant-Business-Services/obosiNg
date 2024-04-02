using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Domain.Entity
{
    public class Village
    {
        [Key]
        public int Id { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public bool Active { get; set; }
    }
}
