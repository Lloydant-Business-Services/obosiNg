using Obosi.ng.Models.Dto;
using Obosi.ng.Models.EntityModel;
using Obosi.ng.Services.Interfaces;

namespace Obosi.ng.Services.Implementation
{
    public class PostService : IPostService
    {
        public Task<Post> CreatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public Task<ViewPostDto> GetPostById(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<Post> UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
