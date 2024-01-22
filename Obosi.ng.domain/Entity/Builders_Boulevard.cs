using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Domain.Entity
{
    public class Builders_Boulevard
    {
        [Key]
        public long Id { get; set; }
        public string FullName { get; set; }    
        public decimal Amount { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; } 
    }
}
