using Obosi.ng.Models.EntityModel;

namespace Obosi.ng.Models.Dto
{
    public class ViewPostDto
    {
        public Post Post { get; set; }
        public List<PostWallComment?>? PostWallComments { get; set;}
    }
}
