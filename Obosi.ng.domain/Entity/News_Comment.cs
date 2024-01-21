namespace Obosi.ng.Domain.Entity
{
    public class News_Comment : Content_CommentBase
    {
        public int NewsId { get; set; }
        public virtual News News { get; set; }
    }
}
