using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Application.Interfaces
{
    public interface IUser
    {
        Task<List<Users>> GetAllUsers();
        Task<Users> GetUsersByEmail(string email);
        Task<Users> GetUsersById(int id);
        Task<Users> CreateUser(Users user,int akaId,int umunnaId,int villageId,int imenneId);
        Task<Users> CreateUser_Admin(Users user);
        Task<Users> UpdateUser(Users user);
        Task DeleteUser(string username);
        Task<Users> ActivateUser(string username,int unitId);
        Task<Users> SuspendUser(string username,string reasonforsuspension, long UserId);
        Task<Users> ResumeUser(string username);
        Task<Users> AssignUserToRole(string username, Role role);
       
        Task<Users> AuthenticateUser(string email,string password);
        Task<List<Role> > GetAllRoles();
    }
}
