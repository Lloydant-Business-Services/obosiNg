using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Assets_Base
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }    
        public bool IsActive { get; set; }
        public DateTime DateAdded { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
    }
    }
