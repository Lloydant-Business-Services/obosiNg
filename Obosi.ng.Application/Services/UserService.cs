using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Services
{
    public class UserService : IUser
    {
        public Task<Users> ActivateUser(string username)
        {
            throw new NotImplementedException();
        }

        public Task<Users> AssignUserToRole(string username, Role role)
        {
            throw new NotImplementedException();
        }

        public Task<Users> ConfirmUser(string username)
        {
            throw new NotImplementedException();
        }

        public Task<Users> CreateUser(Users user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(string username)
        {
            throw new NotImplementedException();
        }

        public Task<List<Users>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetUsersByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetUsersByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public Task<Users> RemoveUsersRoles(string username)
        {
            throw new NotImplementedException();
        }

        public Task<Users> ResumeUser(string username)
        {
            throw new NotImplementedException();
        }

        public Task<Users> SuspendUser(string username)
        {
            throw new NotImplementedException();
        }

        public Task<Users> UpdateUser(Users user)
        {
            throw new NotImplementedException();
        }
    }
}
