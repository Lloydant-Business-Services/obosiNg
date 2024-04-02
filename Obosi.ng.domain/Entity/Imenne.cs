using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Imenne
    {
        [Key]
        public int Id { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public bool Active { get; set; }
        public int UmunnaId { get; set; }
        public virtual Umunna Umunna { get; set; }
    }
}
