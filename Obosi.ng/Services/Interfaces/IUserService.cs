using Obosi.ng.Models.EntityModel;

namespace Obosi.ng.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(User user);   
        Task<bool> DeleteUser(User user);
        Task<User> GetUserById(int userId);
        Task<List<User>> GetAllUsers(); 
        Task<User> GetUserByUsername(string username);
    }
}
