using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Domain.Entity
{
    public class Users
    {
        [Key]
        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? OtherName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string? PassportUrl { get; set; }
        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public bool IsSuspended { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public string? MaidenName { get; set; }
        public string? BackGroundImageUrl { get; set; }
        public string? Title { get; set; }
        public string? AboutMe { get; set; }
    }
}
