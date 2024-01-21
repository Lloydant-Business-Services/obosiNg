using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Content_Update_Base
    {
        [Key]
        public int Id { get; set; }
        public string Updates { get; set; }
        public DateTime DateUpdated { get; set; }
        public long UserId { get; set; }    
        public virtual Users User { get; set; }
        public bool IsActive { get; set; }
    }
}
