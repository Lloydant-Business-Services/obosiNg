﻿using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;
using Obosi.ng.Presentation.utility;
using Obosi.ng.Presentation.ViewModels;
using System.Security.Claims;

namespace Obosi.ng.Presentation.Controllers
{
    public class UserDashboardController : Controller
    {
        private readonly IPostService _postService;
        private readonly IHostEnvironment _hostingEnvironment;
        public IConfiguration _Configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IForum _forum;
        public UserDashboardController(IPostService postService, IConfiguration Configuration, IHttpContextAccessor httpContextAccessor,
            IHostEnvironment hostingEnvironment, IForum forum) 
        {
            _postService = postService;
            _Configuration = Configuration;
            _httpContextAccessor = httpContextAccessor;
            _hostingEnvironment = hostingEnvironment;
            _forum = forum;
        }    
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Notifications()
        {
            return View();
        }
        public async Task<IActionResult> Posts()
        {
            UserDashboardViewModel model = new UserDashboardViewModel(_postService);
            var claimsPrincipal = _httpContextAccessor.HttpContext.User;
            string userEmail = claimsPrincipal.FindFirst(ClaimTypes.Email).Value;
            await model.InitializePostsAsync(userEmail);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Posts(UserDashboardViewModel model)
        {
            
            var claimsPrincipal = _httpContextAccessor.HttpContext.User;
            long userId = Convert.ToInt64(claimsPrincipal.FindFirst(ClaimTypes.Sid).Value);
           var Photos = await SaveImages.SavePostImages(model.Pictures, _hostingEnvironment);
            var Videos = new List<string>() { await SaveImages.SavePostVideo(model.Videos, _hostingEnvironment) };

            await _postService.AddPostAsync(userId, model.Comment, Photos, Videos, null, !model.IsPrivate, true, false);
            return RedirectToAction("Posts");
        }
        public async Task<IActionResult> Post(long Id)
        {
            UserDashboardViewModel model = new UserDashboardViewModel(_postService);
            var claimsPrincipal = _httpContextAccessor.HttpContext.User;
            string userEmail = claimsPrincipal.FindFirst(ClaimTypes.Email).Value;
            await model.InitializePostsAsync(userEmail);
            model.Post = await _postService.GetPost(Id);
            return View(model);
        }
        public async Task<IActionResult> PostComment(UserDashboardViewModel model)
        {
            var claimsPrincipal = _httpContextAccessor.HttpContext.User;
            long userId = Convert.ToInt64(claimsPrincipal.FindFirst(ClaimTypes.Sid).Value);
            await _postService.AddCommentAsync(model.Post.Id, userId, model.Comment);
            return RedirectToAction("Post", new { Id = model.Post.Id });
        }
            public IActionResult Forum()
        {
            return View();
        }
        public async Task<IActionResult> ForumTopic(long forumId)
        {
            UserDashboardViewModel model = new UserDashboardViewModel(_postService);
            model.ForumTopics =await _forum.GetForumTopics(forumId);
            model.Forum = await _forum.ViewForum(forumId);
            return View(model);
        }
        public IActionResult CreateForum()
        {
            UserDashboardViewModel model = new UserDashboardViewModel(_postService);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateForum(UserDashboardViewModel model)
        {
            var claimsPrincipal = _httpContextAccessor.HttpContext.User;
            long userId = Convert.ToInt64(claimsPrincipal.FindFirst(ClaimTypes.Sid).Value);
            await _forum.CreateForum(model.Forum.Title, model.Forum.Description, userId,model.Forum.UnitId,model.Forum.IsGeneral);
            return RedirectToAction("Forum");
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
            return RedirectToAction("ForumTopic", new { forumId = model.Forum.Id});
        }

        public IActionResult Event()
        {
            var model = new UserDashboardViewModel(_postService);
            return View(model);
        }

        public async Task<IActionResult> ViewForumTopic(long forumTopicId)
        { 
            var model = new UserDashboardViewModel(_postService,_forum);
            var claimsPrincipal = _httpContextAccessor.HttpContext.User;
            string userEmail = claimsPrincipal.FindFirst(ClaimTypes.Email).Value;
            await model.InitializeChatsAsync(userEmail, forumTopicId);
            model.ForumTopic = await _forum.ViewForumTopic(forumTopicId);
            return View(model);
        }

        public async Task<bool> LikePost(long Postid)
        {
            var claimsPrincipal = _httpContextAccessor.HttpContext.User;
            long userId = Convert.ToInt64(claimsPrincipal.FindFirst(ClaimTypes.Sid).Value);
            await  _postService.LikePost(Postid, userId);
            return true;
        }
        public async Task<bool> GetLikedPost(long Postid)
        {
            return await _postService.LikedPost(Postid, Convert.ToInt64(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Sid).Value));    
        }
        public async Task<long> GetLikedPostCount(long Postid)
        {
            return await _postService.LikedPostCount(Postid);
        }   
        public async Task<bool> FollowForum(long forumId)
        {
            var claimsPrincipal = _httpContextAccessor.HttpContext.User;
            long userId = Convert.ToInt64(claimsPrincipal.FindFirst(ClaimTypes.Sid).Value);
            await _forum.JoinForum(forumId, userId);
            return true;
        }   
        public async Task<bool> ApproveUsers(long forumId, long userId)
        {
            await _forum.ApproveForumContributor(forumId, userId);
            return true;
        }
        public async Task<bool> AddChat(long forumTopicId, string message)
        {
            var claimsPrincipal = _httpContextAccessor.HttpContext.User;
            long userId = Convert.ToInt64(claimsPrincipal.FindFirst(ClaimTypes.Sid).Value);
            await _forum.SendForumMessage(forumTopicId, userId, message);
            return true;
        }
    }
}
