namespace Obosi.ng.Domain.Entity
{
    public class News_Update : Content_Update_Base
    {
        public int NewsId { get; set; }
        public virtual News News { get; set; }
    }
}
