using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Forum
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public virtual Users User { get; set; } 
        public string Title { get; set; }   
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
    }
}
