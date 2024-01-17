using Obosi.ng.Models.EntityModel;

namespace Obosi.ng.Services.Interfaces
{
    public interface INewsService
    {
        Task<NewsArticle> CreateNewsArticle(NewsArticle news);
        Task<NewsArticle> UpdateNewsArticle(NewsArticle news);
        Task<bool> DeleteNewsArticle(int newsId);
        Task<NewsArticle> GetNewsArticleById(int newsId);
        Task<List<NewsArticle>> GetAllNewsArticles();
        Task<List<NewsArticle>> GetAllNewsArticlesCategory(int categoryId);
    }
}
