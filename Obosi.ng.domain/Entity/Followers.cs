using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Followers
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public virtual Users User { get; set; }
        public long FollowerId { get; set; }
        public virtual Users Follower { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
    }
}
