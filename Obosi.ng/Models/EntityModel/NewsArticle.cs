using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Models.EntityModel
{
    public class NewsArticle
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; } // Foreign key to NewsCategories table
        public virtual NewsCategory Category { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}