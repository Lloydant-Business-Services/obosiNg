using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
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
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public NewsService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
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

        public async Task<List<News>> GetHomePageNews()
        {
            return await _dataContext.News.OrderBy(x => x.DateApproved).Take(3).ToListAsync();
        }

        public async Task<List<News>> GetNews()
        {
            return await _dataContext.News.OrderBy(x => x.DateApproved).ToListAsync();
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
