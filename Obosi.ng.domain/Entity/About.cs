using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string Body { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
