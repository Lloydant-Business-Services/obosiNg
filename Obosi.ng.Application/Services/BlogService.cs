using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Obosi.ng.Application.DTO;
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
    public class BlogService : IBlog
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public BlogService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;   
        }

        public async Task<List<Category>> AllCategories()
        {
            return await _dataContext.Category.ToListAsync(); 
        }

        public async Task<Blogs> ApproveBlog(int blogId)
        {
            var blog = await _dataContext.Blogs.Where(x => x.Id == blogId).FirstOrDefaultAsync();
            if(blog != null) 
            {
                blog.IsApproved = true;
                blog.DateApproved = DateTime.Now;
                _dataContext.Blogs.Update(blog);
                await _dataContext.SaveChangesAsync();
            }
            return blog;
        }

        public async Task<Blogs> CreateBlog(Blogs blog)
        {

            blog.IsActive = true;
            blog.DateCreated = DateTime.Now;
            blog.IsApproved = true;
            blog.DateApproved = DateTime.Now;
            blog.IsPublished = true;
            blog.DatePublished = DateTime.Now;
            var createdBlog=  await _dataContext.Blogs.AddAsync(blog);
            await _dataContext.SaveChangesAsync();
            return createdBlog.Entity;
        }

        public async Task<Blogs_Comment> CreateReaction(Blogs_Comment comment)
        {
            await _dataContext.Blogs_Comment.AddAsync(comment);
            await _dataContext.SaveChangesAsync();  
            return comment;
        }

        public async Task DeleteBlog(int BlogId)
        {
            var blog = await _dataContext.Blogs.Where(x => x.Id == BlogId).FirstOrDefaultAsync();
            if (blog != null)
            {
                blog.IsActive = false;
                _dataContext.Blogs.Update(blog);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<List<Blogs>> GetBlogs()
        {
           return await _dataContext.Blogs.Include(x => x.User.Role).Include(x=>x.Category).ToListAsync();
        }

        public async Task<List<Blogs>> GetBlogs(int pageId)
        {
            // Determine the offset for the current page
            int offset = (pageId - 1) * 10;

            // Fetch the specified page of data
            var ListObj = await _dataContext.Blogs.Where(x=>x.IsApproved == true).Include(x => x.User.Role).Include(x=>x.Category)
                .Skip(offset)
                .Take(10)
                .ToListAsync();
            return ListObj;
        }

        public async Task<Blogs?> GetBlogsById(int BlogId)
        {
           return  await _dataContext.Blogs.Where(x => x.Id == BlogId).Include(x=>x.User.Role).Include(x => x.Category).FirstOrDefaultAsync();
        }

        public async Task<List<Blogs>> GetHomePageBlogs()
        {
            return await _dataContext.Blogs.Where(x=>x.IsApproved).Include(x => x.User.Role).OrderBy(x => x.DateApproved).Include(x => x.Category).Take(3).ToListAsync();
        }

        public async Task<Blogs> PublishBlog(int blogId)
        {
            var blog = await _dataContext.Blogs.Where(x => x.Id == blogId).FirstOrDefaultAsync();
            if (blog != null)
            {
                blog.IsPublished = true;
                blog.DatePublished = DateTime.Now;  
                _dataContext.Blogs.Update(blog);
                await _dataContext.SaveChangesAsync();
            }
            return blog;
        }

        public async Task<Blogs_Update> UpdateBlog(Blogs_Update blog)
        {
            _dataContext.Blogs_Update.Update(blog);
            await _dataContext.SaveChangesAsync();
            return blog;
        }

        public async Task<Blogs> UpdateBlog(Blogs blog)
        {
            var blogDetail = _dataContext.Blogs.Where(x => x.Id == blog.Id).FirstOrDefault();
            if (blogDetail != null)
            {
                if (!string.IsNullOrWhiteSpace(blog.Title))
                {
                    blogDetail.Title = blog.Title;
                }
                if (!string.IsNullOrWhiteSpace(blog.Body))
                {
                    blogDetail.Body = blog.Body;
                }
                if (blog?.CategoryId>0)
                {
                    blogDetail.CategoryId = blog.CategoryId;
                }
                if (!string.IsNullOrWhiteSpace(blog.BackgroundImageUrl))
                {
                    blogDetail.BackgroundImageUrl = blog.BackgroundImageUrl;
                }
                if (!string.IsNullOrWhiteSpace(blog.Summary))
                {
                    blogDetail.Summary = blog.Summary;
                }
                _dataContext.Blogs.Update(blogDetail);
                await _dataContext.SaveChangesAsync();
            }
            return blog;
        }
    }
}
