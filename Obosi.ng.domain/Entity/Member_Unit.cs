using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Member_Unit
    {
        [Key]
        public long Id { get; set; }
        public long UsersId { get; set; }
        public virtual Users Users { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsActive { get; set; }
    }
}
