using Obosi.ng.Models.Dto;
using Obosi.ng.Models.EntityModel;
using Obosi.ng.Services.Interfaces;

namespace Obosi.ng.Services.Implementation
{
    public class BlogService : IBlogService
    {
        public Task<bool> AddBlogComment(BlogComment blogComment)
        {
            throw new NotImplementedException();
        }

        public Task<Blog> CreateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task<Blog> PublishBlog(int blogId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Blog>> ViewAllBlog()
        {
            throw new NotImplementedException();
        }

        public Task<ViewBlogDto> ViewBlog(int blogId)
        {
            throw new NotImplementedException();
        }
    }
}
