using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.DTO
{
    public class UserRegistrationDTO
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? OtherName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int GenderId { get; set; }
        public int? ImeNneId { get; set; }
        public int RoleId { get; set; }
    }
}
