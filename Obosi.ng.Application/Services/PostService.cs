using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.Enums;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Services
{
    public class PostService : IPostService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public PostService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> AddCommentAsync(long postId, long userId, string comment)
        {
            if (postId > 0 && userId > 0 && !string.IsNullOrEmpty(comment))
            {
                await _context.PostComments.AddAsync(new Domain.Entity.PostComments()
                {
                    Date = DateTime.Now,
                    Comment = comment,
                    IsActive = true,
                    PostId = postId,
                    UserId = userId,
                    Response = null
                });
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> AddPostAsync(long userId, string postContent, List<string?> photos, List<string?> videos, int? unitId, bool isPublic, bool onlyFollowers, bool isHidden)
        {
            if (userId > 0)
            {
                var membership = await _context.Member_Unit.Where(x => x.UsersId == userId &&
                x.Unit.Unit_TypeId == (int)Unit_Types.Village).FirstOrDefaultAsync();
                if(membership != null)
                {
                    unitId = membership.UnitId;
                }
                
                await _context.Post.AddAsync(new Domain.Entity.Post()
                {
                    DateAdded = DateTime.Now,
                    IsPublic = isPublic,
                    IsHidden = isHidden,
                    IsActive = true,
                    OnlyFollowers = onlyFollowers,
                    Photos = photos,
                    PostContent = postContent,
                    UnitId = unitId,
                    UserId = userId,
                    Videos = videos
                });
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> AddReplyAsync(long commentId, long userId, string reply)
        {
            var replyComment = await _context.PostComments.Where(x => x.Id == commentId).FirstOrDefaultAsync();
            if (replyComment != null) 
            {
                replyComment.Response = reply;
                _context.PostComments.Update(replyComment);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public Task<List<PostComments>> AllComments(long postId)
        {
            return _context.PostComments.Where(x => x.PostId == postId)
                .Include(x=>x.User).Include(x=>x.Post.User.Role).ToListAsync();
        }

        public async Task<bool> DeleteCommentAsync(long commentId)
        {
           if(commentId > 0)
            {
               var post = await _context.PostComments.Where(x => x.Id == commentId).FirstOrDefaultAsync();
                if (post != null)
                {
                    _context.PostComments.Remove(post);
                    await _context.SaveChangesAsync();
                    return true;
                } return false;
            }
            return false;
        }

        public async Task<bool> DeletePostAsync(long postId)
        {
            if (postId > 0)
            {
                var post = await _context.Post.Where(x => x.Id == postId).FirstOrDefaultAsync();
                if (post != null)
                {
                    _context.Post.Remove(post);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            return false;
        }

        public Task<bool> DeleteReplyAsync(long replyId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditCommentAsync(long commentId, string comment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditPostAsync(long postId, string postContent, List<string> photos, List<string> videos, int? unitId, bool isPublic, bool onlyFollowers, bool isHidden)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditReplyAsync(long replyId, string reply)
        {
            throw new NotImplementedException();
        }

        public async Task<Post> GetPost(long Id)
        {
            return await _context.Post.Where(x => x.Id == Id).Include(x=>x.User).Include(x=>x.Unit).FirstOrDefaultAsync();
        }

        public async Task<List<Post>> GetPosts(string email, int pageNumber, int pageSize)
        {

            List<Post> GrandPosts = new List<Post>();
            var query = _context.Post.Where(x => x.IsPublic).Include(x=>x.User).Include(x=>x.Unit);

            // Get total count of records for pagination metadata
            int totalCount = await query.CountAsync();

            // Pagination logic remains the same
            int skip = (pageNumber - 1) * pageSize;
            var publicPosts = await query
                                    .OrderByDescending(x => x.DateAdded)
                                    .Skip(skip)
                                    .Take(pageSize)
                                    .ToListAsync();
            GrandPosts.AddRange(publicPosts);
            var membership =await _context.Member_Unit.Where(x => x.Users.Email == email).ToListAsync();
            foreach(var item in membership)
            {
                var querymem = _context.Post.Where(x => x.IsPublic == false && x.UnitId == item.UnitId).Include(x => x.User).Include(x => x.Unit);

                // Get total count of records for pagination metadata
                int totalCountmember = await query.CountAsync();

                // Pagination logic remains the same
                int skipmember = (pageNumber - 1) * pageSize;
                var nonpublicPosts = await query
                                        .OrderByDescending(x => x.DateAdded)
                                        .Skip(skipmember)
                                        .Take(pageSize)
                                        .ToListAsync();
                GrandPosts.AddRange(publicPosts);
            }
            return GrandPosts.GroupBy(post => post.Id)  // Group by Id property
    .Select(group => group.First())
     .OrderByDescending(x => x.DateAdded)
    .ToList();  // Convert the result to a List

        }

        public async Task<Users> GetUser(string email)
        {
            return await 
                 _context.Users.Where(x => x.Email == email)
                .FirstOrDefaultAsync();
        }

        public Task<bool> HideCommentAsync(long commentId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HidePostAsync(long postId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HideReplyAsync(long replyId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LikeCommentAsync(long commentId, long userId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> LikePost(long PostId, long UserId)
        {
            var like= await _context.PostLikes.Where(x => x.PostId == PostId &&
            x.UserId == UserId).FirstOrDefaultAsync();
            if (like != null)
            {
                bool stat = like.Active;
                like.Active = !stat;
                _context.PostLikes.Update(like);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                await _context.PostLikes.AddAsync(new PostLikes()
                {
                    PostId = PostId,
                    Date = DateTime.UtcNow,
                    Active = true,
                    UserId = UserId
                });
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public Task<bool> LikePostAsync(long postId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LikeReplyAsync(long replyId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ReportCommentAsync(long commentId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ReportPostAsync(long postId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ReportReplyAsync(long replyId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SharePostAsync(long postId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UnhideCommentAsync(long commentId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UnhidePostAsync(long postId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UnhideReplyAsync(long replyId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UnlikeCommentAsync(long commentId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UnlikePostAsync(long postId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UnlikeReplyAsync(long replyId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UnsharePostAsync(long postId, long userId)
        {
            throw new NotImplementedException();
        }
    }
}
