using Obosi.ng.Models.Dto;
using Obosi.ng.Models.EntityModel;

namespace Obosi.ng.Services.Interfaces
{
    public interface IPostService
    {
        Task<Post> CreatePost(Post post);
        Task<Post> UpdatePost(Post post);   
        Task<bool> DeletePost(Post post);   
        Task<ViewPostDto> GetPostById(int postId);
        Task<List<Post>> GetAllPosts(); 
    }
}
