using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Personality
    {
        [Key]
        public long Id { get; set; } 
        public long UserId { get; set; }
        public virtual Users User { get; set; }
        public string? PortFolio { get; set; }
        public string? Bio { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; }    
    }
}
