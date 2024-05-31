using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IPostService
    {
        Task<bool> AddPostAsync(long userId, string postContent, List<string> photos, List<string> videos, int? unitId, bool isPublic, bool onlyFollowers, bool isHidden);
        Task<bool> DeletePostAsync(long postId);
        Task<bool> EditPostAsync(long postId, string postContent, List<string> photos, List<string> videos, int? unitId, bool isPublic, bool onlyFollowers, bool isHidden);
        Task<bool> LikePostAsync(long postId, long userId);
        Task<bool> UnlikePostAsync(long postId, long userId);
        Task<bool> SharePostAsync(long postId, long userId);
        Task<bool> UnsharePostAsync(long postId, long userId);
        Task<bool> ReportPostAsync(long postId, long userId);
        Task<bool> HidePostAsync(long postId, long userId);
        Task<bool> UnhidePostAsync(long postId, long userId);
        Task<bool> AddCommentAsync(long postId, long userId, string comment);
        Task<bool> DeleteCommentAsync(long commentId);
        Task<bool> EditCommentAsync(long commentId, string comment);
        Task<bool> LikeCommentAsync(long commentId, long userId);
        Task<bool> UnlikeCommentAsync(long commentId, long userId);
        Task<bool> ReportCommentAsync(long commentId, long userId);
        Task<bool> HideCommentAsync(long commentId, long userId);
        Task<bool> UnhideCommentAsync(long commentId, long userId);
        Task<bool> AddReplyAsync(long commentId, long userId, string reply);
        Task<bool> DeleteReplyAsync(long replyId);
        Task<bool> EditReplyAsync(long replyId, string reply);
        Task<bool> LikeReplyAsync(long replyId, long userId);
        Task<bool> UnlikeReplyAsync(long replyId, long userId);
        Task<bool> ReportReplyAsync(long replyId, long userId);
        Task<bool> HideReplyAsync(long replyId, long userId);
        Task<bool> UnhideReplyAsync(long replyId, long userId);
        Task<List<Post>> GetPosts(string email, int pageNumber, int pageSize);
        Task<Users> GetUser(string email);
        Task<Post> GetPost(long Id);
        Task<List<PostComments>> AllComments(long postId);
        Task<bool> LikePost(long PostId, long UserId);
    }
}
