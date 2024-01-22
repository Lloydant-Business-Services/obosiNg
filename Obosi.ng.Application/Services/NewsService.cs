using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Services
{
    public class NewsService : INews
    {
        public Task<News> ApproveNews(News news)
        {
            throw new NotImplementedException();
        }

        public Task<News> CreateNews(News news)
        {
            throw new NotImplementedException();
        }

        public Task<News_Comment> CreateReaction(News_Comment comment, int CommentType)
        {
            throw new NotImplementedException();
        }

        public Task DeleteNews(int NewsId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<News>> GetNews()
        {
            throw new NotImplementedException();
        }

        public Task<News> GetNewsById(int NewsId)
        {
            throw new NotImplementedException();
        }

        public Task<News> PublishNews(News news)
        {
            throw new NotImplementedException();
        }

        public Task<News_Update> UpdateNews(News_Update news)
        {
            throw new NotImplementedException();
        }
    }
}
