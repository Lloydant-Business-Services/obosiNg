using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IUser
    {
        Task<List<Users>> GetAllUsers();
        Task<Users> GetUsersByEmail(string email);
        Task<Users> GetUsersById(int id);
        Task<Users> CreateUser(Users user,int unitId);
        Task<Users> UpdateUser(Users user);
        Task DeleteUser(string username);
        Task<Users> ActivateUser(string username);
        Task<Users> SuspendUser(string username,string reasonforsuspension, long UserId);
        Task<Users> ResumeUser(string username);
        Task<Users> AssignUserToRole(string username, Role role);
       
        Task<Users> AuthenticateUser(string email,string password);
    }
}
