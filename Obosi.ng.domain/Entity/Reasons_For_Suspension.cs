using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Reasons_For_Suspension
    {
        [Key]
        public long Id { get; set; }
        public long UsersId { get; set; }
        public virtual Users Users { get; set; }
        public string Reason { get; set; }
        public DateTime DateCreated { get; set; }
        public string? ResolutionNote { get; set; }
        public DateTime? DateResolved { get; set; }
    }
}
