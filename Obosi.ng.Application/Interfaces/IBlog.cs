using Obosi.ng.Application.DTO;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IBlog
    {
        Task<List<Blogs>> GetBlogs();
        Task<List<Blogs>> GetHomePageBlogs();
        Task<Blogs?> GetBlogsById(int BlogId);
        Task<Blogs> CreateBlog(Blogs blog);
        Task<Blogs_Update> UpdateBlog(Blogs_Update blog);
        Task DeleteBlog(int BlogId);
        Task<Blogs> PublishBlog(int blogId);
        Task<Blogs> ApproveBlog(int blogId);
        Task<Blogs_Comment> CreateReaction(Blogs_Comment comment);
        Task<List<Category>> AllCategories();

    }
}
