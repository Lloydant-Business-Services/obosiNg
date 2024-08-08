using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class UserDashboardViewModel
    {
        private readonly IPostService postService;
        private readonly IForum forumService;
        private readonly IUnit unitService;

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
        public List<ForumFollowers> ForumFollowers { get; set; }
        public List<Unit> Units { get; set; }
        public ForumFollowers? ForumFollower { get; set; }
        public List<ForumMessage>? ForumMessages { get; set; }

        public UserDashboardViewModel()
        {
                
        }
        public UserDashboardViewModel(IPostService _postService)
        {
           postService = _postService;
        }
        public UserDashboardViewModel(IPostService _postService,IForum _forum)
        {
            postService = _postService;
            forumService = _forum;
        }
        public UserDashboardViewModel(IPostService _postService, IUnit _unitService)
        {
            postService = _postService;
            unitService = _unitService;
        }
        public async Task InitializePostsAsync(string email)
        {
            this.Posts = await postService.GetPosts(email,1,40);
            this.Users = await postService.GetUser(email);
        }
        public async Task InitializeUnitsAsync(string email)
        {
            this.Posts = await postService.GetPosts(email, 1, 40);
            this.Users = await postService.GetUser(email);
            this.Units = await unitService.GetAllUnits(email);
        }

        public async Task InitializeChatsAsync(string email,long forumTopicId)
        {
            this.Posts = await postService.GetPosts(email, 1, 40);
            this.Users = await postService.GetUser(email);
            this.ForumFollower = await forumService.GetForumStatus(email);    
            this.ForumMessages = await forumService.GetMessage(forumTopicId);
        }

    }
}
