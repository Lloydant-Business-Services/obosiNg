using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Models.EntityModel
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitTypeId { get; set; } // Foreign key to UnitTypes table
        public virtual UnitType UnitType { get; set; }
        public string AboutUs { get; set; }
        public string BackgroundImage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}