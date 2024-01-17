using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Models.EntityModel
{
    public class UnitType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

}