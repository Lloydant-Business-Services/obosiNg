using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Models.EntityModel
{
    public class Video
    {
        [Key]
        public int Id { get; set; }
        public int UnitId { get; set; } // Foreign key to Units table
        public virtual Unit Unit { get; set; }
        public int? EventId { get; set; } // Nullable foreign key to Events table
        public virtual Event Event { get; set; } // Navigation property
        public string Title { get; set; }
        public string? Caption { get; set; }
        public string VideoUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}