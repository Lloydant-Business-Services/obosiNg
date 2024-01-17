using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Models.EntityModel
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } // Unique
        public bool Active { get; set; }
    }

}