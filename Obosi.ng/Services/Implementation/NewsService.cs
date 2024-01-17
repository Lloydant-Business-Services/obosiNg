using Obosi.ng.Models.EntityModel;
using Obosi.ng.Services.Interfaces;

namespace Obosi.ng.Services.Implementation
{
    public class NewsService : INewsService
    {
        public Task<NewsArticle> CreateNewsArticle(NewsArticle news)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteNewsArticle(int newsId)
        {
            throw new NotImplementedException();
        }

        public Task<List<NewsArticle>> GetAllNewsArticles()
        {
            throw new NotImplementedException();
        }

        public Task<List<NewsArticle>> GetAllNewsArticlesCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<NewsArticle> GetNewsArticleById(int newsId)
        {
            throw new NotImplementedException();
        }

        public Task<NewsArticle> UpdateNewsArticle(NewsArticle news)
        {
            throw new NotImplementedException();
        }
    }
}
