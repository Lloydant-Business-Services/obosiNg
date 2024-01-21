namespace Obosi.ng.Domain.Entity
{
    public class Blogs_Update : Content_Update_Base
    {
        public int BlogsId { get; set; }
        public virtual Blogs Blogs { get; set; }
    }
}
