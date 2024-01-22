using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.DTO
{
    public class BlogDTO
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string BackgroundImageUrl { get; set; }
        public string Body { get; set; }
        public string Summary { get; set; }
        public long UserId { get; set; }
    }
}
