using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Models.EntityModel
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; } // Foreign key to Users table
        public virtual User User { get; set; } // Navigation property 
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public bool IsPublished { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}