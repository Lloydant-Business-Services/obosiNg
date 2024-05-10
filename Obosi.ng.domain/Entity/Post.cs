using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Domain.Entity
{
    public class Post
    {
        [Key]
        public long Id { get; set; } 
        public long UserId { get; set; }    
        public virtual Users User { get; set; }
        public List<string>? Photos { get; set; }
        public List<string>? Videos { get; set; }
        public string PostContent { get; set; } 
        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }
        public long? UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public bool OnlyFollowers { get; set; }
        public bool IsHidden { get; set; }
    }
}
