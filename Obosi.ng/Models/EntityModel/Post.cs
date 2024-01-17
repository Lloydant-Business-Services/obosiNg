using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Models.EntityModel
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; } // Foreign key to Users table
        public virtual User User { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public string? ImageUrl { get; set; } // Nullable
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}