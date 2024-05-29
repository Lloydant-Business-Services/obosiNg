using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Services
{
    public class ForumService : IForum
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ForumService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Forum> CreateForum(string title, string description, long userId)
        {
            if(title == null || description == null)
            {
                throw new ArgumentNullException("Title or Description cannot be null");
            }
            var forum = new Forum
            {
                Title = title,
                Description = description,
                Date = DateTime.UtcNow,
                UserId = userId,IsActive = true
            };
            var create = await _context.Forum.AddAsync(forum);
            await _context.SaveChangesAsync();
            return create.Entity;
        }

        public async Task<ForumTopic> CreateForumTopic(long forumId, string title, long userId)
        {
           if(title == null || forumId == null || userId == null)
            {
                throw new ArgumentNullException("Title or Description cannot be null");
            }
            var forumtopic = new ForumTopic
            {
                Date = DateTime.UtcNow,
                ForumId = forumId,
                IsActive = true,
                Topic = title,
                UserId = userId
            };
            var create = await _context.ForumTopic.AddAsync(forumtopic);
            await _context.SaveChangesAsync();
            return create.Entity;
        }

        public Task<ForumTopic> DeleteForumTopic(long forumTopicId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ForumFollowers>> GetFollowers(long forumId)
        {
            return await  _context.ForumFollowers.Where(x => x.ForumId == forumId).ToListAsync();
        }

        public async Task<List<Forum>> GetForums()
        {
            return await _context.Forum.ToListAsync();
        }

        public async Task<List<ForumTopic>> GetForumTopics(long forumId)
        {
            return await _context.ForumTopic.Where(x => x.ForumId == forumId).ToListAsync();
        }

        public async  Task<List<ForumMessage>> GetMessage(long forumTopicId)
        {
            return await _context.ForumMessage.Where(x => x.ForumTopicId == forumTopicId).ToListAsync();
        }

        public async Task<ForumFollowers> JoinForum(long forumId, long userId)
        {
           if(forumId == null || userId == null)
            {
                throw new ArgumentNullException("User or Forum cannot be null");
            }
           var forumfollower  = new ForumFollowers { ForumId = forumId, UserId = userId, Date = DateTime.UtcNow,IsActive= true };
            var create = await _context.ForumFollowers.AddAsync(forumfollower);
            await _context.SaveChangesAsync();
            return create.Entity;
        }

        public Task<ForumFollowers> LeaveForum(long forumId, long userId)
        {
            throw new NotImplementedException();
        }

        public async Task<ForumMessage> SendForumMessage(long forumTopicId, long userId, string message)
        {
            if(forumTopicId == null || userId == null || message == null)
            {
                throw new ArgumentNullException("User or Forum cannot be null");
            }   
            var forummessage = new ForumMessage { ForumTopicId = forumTopicId, UserId = userId, Date = DateTime.UtcNow, Message = message,IsActive = true};
            var create = await _context.ForumMessage.AddAsync(forummessage);
            await _context.SaveChangesAsync();
            return create.Entity;
        }

        public Task<ForumTopic> UpdateForumTopic(long forumTopicId, string title)
        {
            throw new NotImplementedException();
        }

        public async Task<Forum> ViewForum(long Id)
        {
            return await _context.Forum.Where(x => x.Id == Id).FirstOrDefaultAsync(); 
        }

        public async Task<ForumTopic> ViewForumTopic(long forumTopicId)
        {
            return await _context.ForumTopic.Where(x => x.Id == forumTopicId).FirstOrDefaultAsync();
        }
    }
}
