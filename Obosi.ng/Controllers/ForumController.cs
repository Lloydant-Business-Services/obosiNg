using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.utility;
using Obosi.ng.Presentation.ViewModels;
using System.Security.Claims;

namespace Obosi.ng.Presentation.Controllers
{
    public class ForumController : Controller
    {
        private readonly IPostService _postService;
        private readonly IHostEnvironment _hostingEnvironment;
        public IConfiguration _Configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IForum _forum;
        private readonly IUnit _unit;
        public ForumController(IPostService postService, IConfiguration Configuration, IHttpContextAccessor httpContextAccessor,
            IHostEnvironment hostingEnvironment, IForum forum, IUnit unit)
        {
            _postService = postService;
            _Configuration = Configuration;
            _httpContextAccessor = httpContextAccessor;
            _hostingEnvironment = hostingEnvironment;
            _forum = forum;
            _unit = unit;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ForumTopic(long forumId)
        {
            UserDashboardViewModel model = new UserDashboardViewModel(_postService);
            model.ForumTopics = await _forum.GetForumTopics(forumId);
            model.Forum = await _forum.ViewForum(forumId);
            return View(model);
        }
        public async Task<IActionResult> CreateForum()
        {
            UserDashboardViewModel model = new UserDashboardViewModel(_postService, _unit);
            var userEmail = IdentityExtensions.GetEmail(User.Identity);
            await model.InitializeUnitsAsync(userEmail);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateForum(UserDashboardViewModel model)
        {
            var claimsPrincipal = _httpContextAccessor.HttpContext.User;
            long userId = Convert.ToInt64(claimsPrincipal.FindFirst(ClaimTypes.Sid).Value);
            await _forum.CreateForum(model.Forum.Title, model.Forum.Description, userId,model.Forum.UnitId,model.IsPrivate);
            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult> CreateForumTopic(long forumId)
        {
            UserDashboardViewModel model = new UserDashboardViewModel(_postService);
            model.ForumTopics = await _forum.GetForumTopics(forumId);
            model.Forum = await _forum.ViewForum(forumId);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateForumTopic(UserDashboardViewModel model)
        {
            var claimsPrincipal = _httpContextAccessor.HttpContext.User;
            long userId = Convert.ToInt64(claimsPrincipal.FindFirst(ClaimTypes.Sid).Value);
            await _forum.CreateForumTopic(model.Forum.Id, model.ForumTopic.Topic, userId);
            return RedirectToAction("ForumTopic", new { forumId = model.Forum.Id });
        }
        [HttpGet]
        public async Task<IActionResult> ViewForumMembers(long forumId)
        {
            UserDashboardViewModel model = new UserDashboardViewModel(_postService);
            model.ForumFollowers = await _forum.GetFollowers(forumId);
            model.Forum = await _forum.ViewForum(forumId);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> InviteForumMember(UserDashboardViewModel model)
        {
            return View(model);
        }
    }
}
