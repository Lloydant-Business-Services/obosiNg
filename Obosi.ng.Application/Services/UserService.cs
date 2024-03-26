using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Services
{
    public class UserService : IUser
    {
        private readonly DataContext _dataContext;
        public UserService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
        }
        public async Task<Users> ActivateUser(string username, int unitId)
        {
            var user = await _dataContext.Users.Where(x => x.Email == username).FirstOrDefaultAsync();
            if(user != null)
            {
                user.IsActive = true;
                _dataContext.Users.Update(user);
                await _dataContext.SaveChangesAsync();
               
            }
            var member = await _dataContext.Member_Unit.Where(x => x.UnitId == unitId).FirstOrDefaultAsync();
            if(member != null) 
            {
                member.IsActive = true;
                _dataContext.Member_Unit.Update(member);
                await _dataContext.SaveChangesAsync();
            }
            return user;
        }

        public async Task<Users> AssignUserToRole(string username, Role role)
        {
            var user = await _dataContext.Users.Where(x => x.Email == username).FirstOrDefaultAsync();
            if (user != null)
            {
                user.RoleId = role.Id;
                _dataContext.Users.Update(user);
                await _dataContext.SaveChangesAsync();
                return user;
            }
            return null;
        }

        public async  Task<Users> AuthenticateUser(string email, string password)
        {
            var user = await _dataContext.Users.Where(x => x.Email == email && x.Password == password && 
            x.IsActive== true).Include(x=>x.Role).FirstOrDefaultAsync();
            if (user != null)
            {
                return user;
            }
            return null;
        }

     

        public async Task<Users> CreateUser(Users user, int akaId, int umunnaId, int villageId, int imenneId)
        {
          if(user != null)
            {
                user.DateCreated = DateTime.Now;
                user.IsActive = false;
                var userDetails = await _dataContext.Users.Where(x => x.Email == user.Email).FirstOrDefaultAsync();
                if (userDetails == null)
                {
                    var createdUser = await _dataContext.Users.AddAsync(user);
                    await _dataContext.SaveChangesAsync();

                    Member_Unit Aka = new()
                    {
                        UsersId = createdUser.Entity.Id,
                        UnitId = akaId,
                        IsActive = true,
                        DateJoined = DateTime.Now
                    };
                    await _dataContext.Member_Unit.AddAsync(Aka);
                    Member_Unit Umunna = new()
                    {
                        UsersId = createdUser.Entity.Id,
                        UnitId = umunnaId,
                        IsActive = false,
                        DateJoined = DateTime.Now
                    };
                    await _dataContext.Member_Unit.AddAsync(Umunna);
                    Member_Unit Imenne = new()
                    {
                        UsersId = createdUser.Entity.Id,
                        UnitId = imenneId,
                        IsActive = true,
                        DateJoined = DateTime.Now
                    };
                    await _dataContext.Member_Unit.AddAsync(Imenne);
                    Member_Unit Village = new()
                    {
                        UsersId = createdUser.Entity.Id,
                        UnitId = villageId,
                        IsActive = true,
                        DateJoined = DateTime.Now
                    };
                    await _dataContext.Member_Unit.AddAsync(Village);

             
                    await _dataContext.SaveChangesAsync();
                    return createdUser.Entity;
                }
                throw new Exception("User Already Exists");
            }
            throw new Exception("User Object is Null");
        }
        public async Task<Users> CreateUser_Admin(Users user)
        {
            try
            {
                if (user != null)
                {
                    user.DateCreated = DateTime.UtcNow;
                    user.IsActive = true;
                    user.LastName = "";
                    user.PhoneNumber = "";
                    user.OtherName = "";
                    user.FirstName = "";
                    user.GenderId = 1;



                    var userDetails = await _dataContext.Users.Where(x => x.Email == user.Email).FirstOrDefaultAsync();
                    if (userDetails != null)
                    {
                        throw new Exception("User Already Exists");
                    }
                    var createdUser = await _dataContext.Users.AddAsync(user);
                    await _dataContext.SaveChangesAsync();

                    return createdUser.Entity;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            return user;
        }

        public async Task DeleteUser(string username)
        {
            var user = await _dataContext.Users.Where(x => x.Email == username).FirstOrDefaultAsync();
            if (user != null)
            {
                user.IsActive = false;
                _dataContext.Users.Update(user);
                await _dataContext.SaveChangesAsync();
            }
        }

     

        public async  Task<List<Users>> GetAllUsers()
        {
            return await _dataContext.Users.Where(x => x.IsActive == true).ToListAsync();
        }

        public async Task<Users> GetUsersByEmail(string email)
        {
            return await _dataContext.Users.Where(x => x.Email == email).FirstOrDefaultAsync();
        }

        public async Task<Users> GetUsersById(int id)
        {
            return await _dataContext.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Users> ResumeUser(string username)
        {
            var user = await _dataContext.Users.Where(x => x.Email == username).FirstOrDefaultAsync();
            if (user != null)
            {
                user.IsActive = true;
                _dataContext.Users.Update(user);
                await _dataContext.SaveChangesAsync();
                return user;
            }
            return null;
        }

        public async Task<Users> SuspendUser(string username, string reasonforsuspension, long UserId)
        {
            var user = await _dataContext.Users.Where(x => x.Email == username).FirstOrDefaultAsync();
            if (user != null)
            {
                user.IsActive = true;
                _dataContext.Users.Update(user);            
                Reasons_For_Suspension reason = new()
                {
                    DateCreated = DateTime.Now,
                    Reason = reasonforsuspension,
                    UsersId = UserId
                };
                await _dataContext.Reasons_For_Suspension.AddAsync(reason);
                await _dataContext.SaveChangesAsync();
                return user;
            }
            return null;
        }

      

        public async Task<Users> UpdateUser(Users user)
        {
            var userDetails = await _dataContext.Users.Where(x => x.Id == user.Id).FirstOrDefaultAsync();
            if (userDetails != null)
            {
                if (!string.IsNullOrWhiteSpace(user.OtherName))
                {
                    userDetails.OtherName = user.OtherName;
                }
                if (!string.IsNullOrWhiteSpace(user.PhoneNumber))
                {
                    userDetails.PhoneNumber = user.PhoneNumber;
                }
                if (!string.IsNullOrWhiteSpace(user.FirstName))
                {
                    userDetails.FirstName = user.FirstName;
                }
                if (!string.IsNullOrWhiteSpace(user.LastName))
                {
                    userDetails.LastName = user.LastName;
                }
                //if (!string.IsNullOrWhiteSpace(user.Email))
                //{
                //    userDetails.Email = user.Email;
                //}
                if (!string.IsNullOrWhiteSpace(user.PassportUrl))
                {
                    userDetails.PassportUrl = user.PassportUrl;
                }
                if (!string.IsNullOrWhiteSpace(user.Password))
                {
                    userDetails.Password = user.Password;
                }

                if(user.RoleId > 0)
                {
                    userDetails.RoleId = user.RoleId;
                }

                _dataContext.Users.Update(userDetails);
                await _dataContext.SaveChangesAsync();
                return userDetails;
            }
            return null;
        }

        public async Task<List<Role>> GetAllRoles()
        {
            return await _dataContext.Role.ToListAsync();
        }
    }
}
