using Obosi.ng.Models.EntityModel;

namespace Obosi.ng.Models.Dto
{
    public class ViewBlogDto
    {
        public Blog Blog { get; set; }
        public List<BlogComment?>? BlogComments { get; set;}
    }
}
