using Obosi.ng.Application.Enums;
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
        public async Task InitializeNewsAsync(string email)
        {
            this.Users = await user.GetAllUsers();
            this.Members = await unit.ViewUnApprovedMembers(email);
            this.Roles = await user.GetAllRoles();
            this.User = new Users();
            this.User = await user.GetUsersByEmail(email);

        }
        public async Task InitializeNewsAsync(int Id, string email)
        {
            this.Users = await user.GetAllUsers();
            this.Members = await unit.ViewUnApprovedMembers(email);
            this.Roles = await user.GetAllRoles();
            this.User = await user.GetUsersById(Id);

        }
       
        public async Task InitializeUserAsync(string email)
        {
            this.User = await user.GetUsersByEmail(email);
            var membership = await unit.ViewMembership(email);
            this.Village = membership?.Where(x=>x.Unit_TypeId == (int)Unit_Types.Village)?.FirstOrDefault()?.Name;
            this.Umunna = membership?.Where(x => x.Unit_TypeId == (int)Unit_Types.Umunna)?.FirstOrDefault()?.Name;
            this.Aka = membership?.Where(x => x.Unit_TypeId == (int)Unit_Types.Aka)?.FirstOrDefault()?.Name;
            this.Imenne = membership?.Where(x => x.Unit_TypeId == (int)Unit_Types.Ime_Nne)?.FirstOrDefault()?.Name;
        }


        public List<Users> Users { get; set; }
        public Users User { get; set; }
        public List<Member_Unit> Members { get; set; }
        public IFormFile Image { get; set; }
        public IFormFile BackgroundImage { get; set; }
        public List<Domain.Entity.Role> Roles { get; set; }
        public string Error { get; set; }
        public string Village { get; set; }
        public string Umunna { get; set; }
        public string Aka { get; set; }
        public string Imenne { get; set; }
    }
}
