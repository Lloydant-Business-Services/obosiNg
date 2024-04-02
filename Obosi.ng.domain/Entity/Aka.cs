using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Aka
    {
        [Key]
        public int Id { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public bool Active { get; set; }
        public int VillageId { get; set; }
        public virtual Village Village { get; set; }
    }
}
