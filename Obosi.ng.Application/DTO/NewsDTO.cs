namespace Obosi.ng.Application.DTO
{
    public class NewsDTO
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string BackgroundImageUrl { get; set; }
        public string Body { get; set; }
        public string Summary { get; set; }
        public long UserId { get; set; }
    }
}
