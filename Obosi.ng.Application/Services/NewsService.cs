using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
        public async Task<List<Category>> AllCategories()
        {
            return await _dataContext.Category.ToListAsync();
        }
        public async Task<News> ApproveNews(int id)
        {
            if(id >0)
            {
                var news = _dataContext.News.Where(x => x.Id == id).FirstOrDefault();
                if (news != null)
                {
                    news.IsApproved = true;
                    news.DateApproved = DateTime.Now;
                    _dataContext.News.Update(news);
                    await _dataContext.SaveChangesAsync();
                    return news;
                }
            }
            return null;
        }

        public async Task<News> CreateNews(News news)
        {
            if(news != null)
            {
                news.DateCreated = DateTime.Now;
                news.IsActive = true;
                var newsEntity =await  _dataContext.News.AddAsync(news);
               await _dataContext.SaveChangesAsync();
                return newsEntity.Entity;
            }
            return null;
        }

        public async Task<News_Comment> CreateReaction(News_Comment comment)
        {
           if(comment != null)
            {
                comment.DateAdded = DateTime.Now;
                comment.IsActive = true;
                var commentEntity = await _dataContext.News_Comment.AddAsync(comment);
                await _dataContext.SaveChangesAsync();
                return commentEntity.Entity;
            }
            return null;
        }

        public async Task DeleteNews(int NewsId)
        {
            if(NewsId > 0)
            {
                var news = _dataContext.News.Where(x => x.Id == NewsId).FirstOrDefault();
                if(news != null)
                {
                    news.IsActive = false;
                    _dataContext.News.Update(news);
                    await _dataContext.SaveChangesAsync();
                }
            }   
        }

        public async Task<List<News>> GetHomePageNews()
        {
            return await _dataContext.News.Where(x=>x.IsApproved).OrderBy(x => x.DateApproved).Include(x => x.Category).Take(3).ToListAsync();
        }

        public async Task<List<News>> GetNews()
        {
            return await _dataContext.News.OrderBy(x => x.DateApproved).Include(x=>x.User.Role).Include(x => x.Category).ToListAsync();
        }

        public async Task<List<News>> GetNews(int pageId)
        {
            // Determine the offset for the current page
            int offset = (pageId - 1) * 10;

            // Fetch the specified page of data
            var ListObj = await _dataContext.News.Where(x => x.IsApproved == true).Include(x => x.User.Role)
                .Skip(offset)
                .Take(10)
                .ToListAsync();
            return ListObj;
        }

        public async Task<News> GetNewsById(int NewsId)
        {
            return await _dataContext.News.Where(x => x.Id == NewsId).Include(x => x.User.Role)
                .Include(x => x.Category).FirstOrDefaultAsync(); 
        }

        public async Task<News> PublishNews(int id)
        {
            if (id > 0)
            {
                var news = _dataContext.News.Where(x => x.Id == id).FirstOrDefault();
                if (news != null)
                {
                    news.IsPublished = true;
                    news.DatePublished = DateTime.Now;
                    _dataContext.News.Update(news);
                    await _dataContext.SaveChangesAsync();
                    return news;
                }
            }
            return null;
        }

        public async Task<News_Update> UpdateNews(News_Update news)
        {
            if(news != null)
            {
               var newsup = await _dataContext.News_Update.AddAsync(news);
                await _dataContext.SaveChangesAsync();
                return newsup.Entity;
            }
            return null;
        }

        public async Task<News> UpdateNews(News news)
        {
           if(news != null)
            {
                var newsDetail = await _dataContext.News.Where(x => x.Id == news.Id).FirstOrDefaultAsync();
                if(newsDetail != null)
                {
                    if (!string.IsNullOrWhiteSpace(news.Title))
                    {
                        newsDetail.Title = news.Title;
                    }
                    if (!string.IsNullOrWhiteSpace(news.Body))
                    {
                        newsDetail.Body = news.Body;
                    }
                    if (news?.CategoryId > 0)
                    {
                        newsDetail.CategoryId = news.CategoryId;
                    }
                    if (!string.IsNullOrEmpty(news.BackgroundImageUrl))
                    {
                        newsDetail.BackgroundImageUrl = news.BackgroundImageUrl;
                    }
                    if (!string.IsNullOrWhiteSpace(news.Summary))
                    {
                        newsDetail.Summary = news.Summary;
                    }
                    _dataContext.News.Update(newsDetail);
                   await  _dataContext.SaveChangesAsync();
                    
                }   
            }
            return news;
        }
    }
}
