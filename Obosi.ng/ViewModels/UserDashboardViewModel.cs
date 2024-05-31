using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class UserDashboardViewModel
    {
        private readonly IPostService postService;
        private readonly IForum forumService;

        public List<Notification> Notifications { get; set; }
        public List<Post> Posts { get; set; }
        public Post Post { get; set; }
        public List<IFormFile> Pictures { get; set; }
        public IFormFile Videos { get; set; }
        public string Comment { get; set; }
        public bool IsPrivate { get; set; } = false;
        public Users Users { get; set; }

        public Forum Forum { get; set; }
        public ForumTopic ForumTopic { get; set; }
        public List<ForumTopic> ForumTopics { get; set; }

        public UserDashboardViewModel()
        {
                
        }
        public UserDashboardViewModel(IPostService _postService)
        {
           postService = _postService;
        }
        public async Task InitializePostsAsync(string email)
        {
            this.Posts = await postService.GetPosts(email,1,40);
            this.Users = await postService.GetUser(email);
        }
       
    }
}
