using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IForum
    {
        Task<Forum> CreateForum(string title,string description,long userId,int? unitId,bool? isGeneral);
        Task<Forum> ViewForum(long Id);
        Task<List<Forum>> GetForums();
        Task<List<ForumFollowers>> GetFollowers(long forumId);
        Task<ForumFollowers> JoinForum(long forumId,long userId);
        Task<ForumFollowers> LeaveForum(long forumId,long userId);
        Task<List<ForumMessage>> GetMessage(long forumTopicId);
        Task<ForumMessage> SendForumMessage(long forumTopicId,long userId,string message);
        Task<ForumTopic> CreateForumTopic(long forumId,string title,long userId);
        Task<ForumTopic> ViewForumTopic(long forumTopicId);
        Task<List<ForumTopic>> GetForumTopics(long forumId);
        Task<ForumTopic> DeleteForumTopic(long forumTopicId);
        Task<ForumTopic> UpdateForumTopic(long forumTopicId,string title);
        Task<bool> ApproveForumContributor(long forumId,long userId);
    }
}
