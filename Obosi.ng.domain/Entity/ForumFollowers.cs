using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class ForumFollowers
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public virtual Users User { get; set; }
        public long ForumId { get; set; }
        public virtual Forum Forum { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
    }
}
