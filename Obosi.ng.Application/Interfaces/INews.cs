using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface INews
    {
        Task<List<News>> GetNews();
        Task<List<News>> GetNews(int pageId);
        Task<List<News>> GetHomePageNews();
        Task<News> GetNewsById(int NewsId);
        Task<News> CreateNews(News news);
        Task<News_Update> UpdateNews(News_Update news);
        Task DeleteNews(int NewsId);
        Task<News> PublishNews(int id);
        Task<News> ApproveNews(int id);
        Task<News_Comment> CreateReaction(News_Comment comment);
        Task<List<Category>> AllCategories();
    }
}
