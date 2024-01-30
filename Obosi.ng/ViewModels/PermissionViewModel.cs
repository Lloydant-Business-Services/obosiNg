using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class PermissionViewModel
    {
        private readonly IUser user;
        public PermissionViewModel(IUser _user)
        {
            user = _user;
        }

        public PermissionViewModel()
        {
                
        }
        public async Task InitializeNewsAsync()
        {
            this.Users = await user.GetAllUsers();
        }

        public List<Users> Users { get; set; }
        public Users User { get; set; }
    }
}
