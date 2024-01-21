namespace Obosi.ng.Domain.Entity
{
    public class Blogs_Comment : Content_CommentBase
    {
        public int BlogsId { get; set; }
        public virtual Blogs Blogs { get; set; }
    }
}
