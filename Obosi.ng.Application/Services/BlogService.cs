using Obosi.ng.Application.DTO;
using Obosi.ng.Application.Interfaces;
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
        public Task<Blogs> ApproveBlog(int blogId)
        {
            throw new NotImplementedException();
        }

        public Task<Blogs> CreateBlog(BlogDTO blog)
        {
            throw new NotImplementedException();
        }

        public Task<Blogs_Comment> CreateReaction(Blogs_Comment comment, int CommentType)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBlog(int BlogId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Blogs>> GetBlogs()
        {
            throw new NotImplementedException();
        }

        public Task<Blogs> GetBlogsById(int BlogId)
        {
            throw new NotImplementedException();
        }

        public Task<Blogs> PublishBlog(int blogId)
        {
            throw new NotImplementedException();
        }

        public Task<Blogs_Update> UpdateBlog(Blogs_Update blog)
        {
            throw new NotImplementedException();
        }
    }
}
