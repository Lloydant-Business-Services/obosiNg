using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class UserViewModel
    {
        private readonly IUser user;
        public UserViewModel(IUser _user)
        {
           user = _user;
        }
        public async Task InitializeNewsAsync()
        {
            this.Users = await user.GetAllUsers();
        }

        public List<Users> Users { get; set; }
    }
}
