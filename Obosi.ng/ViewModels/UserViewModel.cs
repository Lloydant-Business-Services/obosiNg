using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class UserViewModel
    {
        private readonly IUser user;
        private readonly IUnit unit;
        public UserViewModel(IUser _user, IUnit _unit)
        {
           user = _user;
           unit = _unit;
        }
        public UserViewModel()
        {
            
        }
        public async Task InitializeNewsAsync()
        {
            this.Users = await user.GetAllUsers();
            this.Members = await unit.ViewUnApprovedMembers();
            this.Roles = await user.GetAllRoles();
            this.User = new Users();

        }
        public async Task InitializeNewsAsync(string email)
        {
            this.User = await user.GetUsersByEmail(email);
            
           
        }
        

        public List<Users> Users { get; set; }
        public Users User { get; set; }
        public List<Member_Unit> Members { get; set; }
        public IFormFile Image { get; set; }
        public List<Role> Roles { get; set; }
        public string Error { get; set; }
    }
}
