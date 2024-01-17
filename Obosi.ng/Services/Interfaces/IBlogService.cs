using Obosi.ng.Models.Dto;
using Obosi.ng.Models.EntityModel;

namespace Obosi.ng.Services.Interfaces
{
    public interface IBlogService
    {
        Task<Blog> CreateBlog(Blog blog);
        Task<Blog> PublishBlog(int blogId);
        Task<List<Blog>> ViewAllBlog();
        Task<ViewBlogDto> ViewBlog(int blogId);
        Task<bool> AddBlogComment(BlogComment blogComment);
    }
}
