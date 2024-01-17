using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Models.EntityModel
{
    public class Executive
    {
        [Key]
        public int Id { get; set; }
        public int UnitId { get; set; } // Foreign key to Units table
        public virtual Unit Unit { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Designation { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}