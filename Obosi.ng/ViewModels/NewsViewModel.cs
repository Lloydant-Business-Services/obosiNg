using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;
using System.Reflection.Metadata;

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
            this.Categories = await news.AllCategories();
        }
        public async Task NewsL()
        {
            this.NewsList = await news.GetNews(1);
            this.SimilarNews = await news.GetHomePageNews();
        }

        public List<News> NewsList { get; set; }
        public List<News> SimilarNews { get; set; }
        public News NewsObject { get; set; }
        public News_Update News_Update { get; set; }
        public IFormFile Image { get; set; }
        public List<Category> Categories { get; set; }
    }
}
