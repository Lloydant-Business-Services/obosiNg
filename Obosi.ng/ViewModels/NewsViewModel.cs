using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class NewsViewModel
    {
        private readonly INews news;
        public NewsViewModel(INews _news)
        {
            news = _news;
        }
        public NewsViewModel()
        {
                
        }
        public async Task InitializeNewsAsync()
        {
            this.NewsList = await news.GetNews();
        }

        public List<News> NewsList { get; set; }
        public News NewsObject { get; set; }
        public News_Update News_Update { get; set; }
    }
}
