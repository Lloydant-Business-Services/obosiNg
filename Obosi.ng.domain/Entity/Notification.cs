using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Domain.Entity
{
    public class Notification
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public string? Url { get; set; }
        public bool IsRead { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
