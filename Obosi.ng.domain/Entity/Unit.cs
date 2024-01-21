
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Domain.Entity
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public int UnitTypeId { get; set; }
        public virtual Unit_Type UnitType { get; set; }
        public string About { get; set; }
        public string? Description { get; set; }
        public string BackGroundImageUrl { get; set; }
        public DateTime DateCreated { get; set; }    
    }
}
