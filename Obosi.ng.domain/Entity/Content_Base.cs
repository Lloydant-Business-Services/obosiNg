using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Content_Base
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string BackgroundImageUrl { get; set; }
        public string Body { get; set; }
        public string Summary { get; set; }
        public long UserId { get; set; }
        public virtual Users User { get; set; }
        public bool IsPublished { get; set; }   
        public DateTime DatePublished { get; set; }
        public bool IsApproved { get; set; }
        public DateTime? DateApproved { get; set; }
        public bool IsActive { get; set; }
    }
}
