using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class PostComments
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public virtual Users User { get; set; }
        public long PostId { get; set; }
        public virtual Post Post { get; set; } 
        public string Comment { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
    }
}
