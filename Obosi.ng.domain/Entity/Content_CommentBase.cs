using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Content_CommentBase
    {
        [Key]
        public int Id { get; set; }
        public long UserId { get; set; }
        public virtual Users User { get; set; }
        public string Comment { get; set; }
        public string Reaction { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }
    }
}
