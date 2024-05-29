using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class ForumMessage
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public virtual Users User { get; set; }
        public long ForumTopicId { get; set; }
        public virtual ForumTopic ForumTopic { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
    }
}
