using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Umunna
    {
        [Key]
        public int Id { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public bool Active { get; set; }
        public int AkaId { get; set; }
        public virtual Aka Aka { get; set; }
    }
}
