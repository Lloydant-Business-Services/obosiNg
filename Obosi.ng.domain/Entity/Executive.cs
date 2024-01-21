using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Executive
    {
        [Key]
        public long Id { get; set; }    
        public long UserId { get; set; }
        public virtual Users User { get; set; } 
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public string Designation { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsActive { get; set; }
    }
}
