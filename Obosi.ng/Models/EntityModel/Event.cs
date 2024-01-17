using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Models.EntityModel
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public int UnitId { get; set; } // Foreign key to Units table
        public virtual Unit Unit { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}