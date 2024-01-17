using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Models.EntityModel
{
    public class NewsComment
    {
        [Key]
        public int Id { get; set; }
        public int NewsArticleId { get; set; } // Foreign key to Blogs or NewsArticles table
        public virtual NewsArticle NewsArticle { get; set; } // Navigation property 
        public int UserId { get; set; } // Foreign key to Users table
        public virtual User User { get; set; }
        public string Text { get; set; }
        public string Reactions { get; set; } // JSON or structured data for storing likes, dislikes
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}