using System.ComponentModel.DataAnnotations;

namespace Obosi.ng.Models.EntityModel
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } // Unique
        public string? Password { get; set; } // Hashed
        public string? Name { get; set; }
        public string? Profession { get; set; }
        public string? Location { get; set; }
        public string? AgeRange { get; set; }
        public string? ResumeFile { get; set; } // Path or reference to resume document
        public bool IsIndigene { get; set; }
        public bool IsActive { get; set; }
        public int RoleId { get; set; } // Foreign key to Roles table
        public virtual Role Role { get; set; }
        public string? FirebaseId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}