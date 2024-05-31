using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Domain.Entity
{
    public class PostLikes
    {
        public long Id { get; set; }
        public long PostId { get; set; }
        public virtual Post Post { get; set; }
        public DateTime Date { get; set; }
        public long UserId { get; set; }
        public virtual Users User { get; set; }
        public bool Active { get; set; }
    }
}
