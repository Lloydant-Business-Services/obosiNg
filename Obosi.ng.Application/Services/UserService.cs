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
                Notification notification = new()
                {
                    Message = "User Account Activation Successful",
                    DateCreated = DateTime.UtcNow,
                    UserId = user.Id,
                    Type = "User Account Activation",
                    IsRead = false
                };
                await _dataContext.Notification.AddAsync(notification);
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
           
            var user = await _dataContext.Users.Where(x => x.Email == email).Include(x=>x.Role).FirstOrDefaultAsync();
            if (user != null)
            {var passwordCheck = VerifyPassword(password,user.Password);
                if (passwordCheck && user.IsActive)
                {
                    Notification notification = new()
                    {
                        Message = "User Login Successful",
                        DateCreated = DateTime.UtcNow,
                        UserId = user.Id,
                        Type = "User Login",
                        IsRead = false
                    };
                    await _dataContext.Notification.AddAsync(notification);
                    await _dataContext.SaveChangesAsync();
                    return user;
                }
                else
                {
                    throw new Exception("User has not been Approved");
                }
            }
            return null;
        }

     

        public async Task<Users> CreateUser(Users user, int akaId, int umunnaId, int villageId, int imenneId)
        {
          if(user != null)
            {
                var transaction = await _dataContext.Database.BeginTransactionAsync();
                user.DateCreated = DateTime.Now;
                user.IsActive = false;
                string hashedPassword = HashPassword(user.Password);
                user.Password = hashedPassword;
                var userDetails = await _dataContext.Users.Where(x => x.Email == user.Email).FirstOrDefaultAsync();
                if (userDetails == null)
                {
                    var createdUser = await _dataContext.Users.AddAsync(user);
                    await _dataContext.SaveChangesAsync();
                    var AkaItem = await _dataContext.Aka.Where(x => x.Id == akaId).FirstOrDefaultAsync();
                    if (AkaItem != null)
                    {
                        Member_Unit Aka = new()
                        {
                            UsersId = createdUser.Entity.Id,
                            UnitId = AkaItem.UnitId,
                            IsActive = true,
                            DateJoined = DateTime.Now
                        };
                        await _dataContext.Member_Unit.AddAsync(Aka);
                    }
                    var UmunnaItem = await _dataContext.Umunna.Where(x => x.Id == umunnaId).FirstOrDefaultAsync();
                    if (UmunnaItem != null)
                    {
                        Member_Unit Umunna = new()
                        {
                            UsersId = createdUser.Entity.Id,
                            UnitId = UmunnaItem.UnitId,
                            IsActive = false,
                            DateJoined = DateTime.Now
                        };
                        await _dataContext.Member_Unit.AddAsync(Umunna);
                    }
                    var ImenneItem = await _dataContext.Imenne.Where(x => x.Id == imenneId).FirstOrDefaultAsync();
                    if (ImenneItem != null)
                    {
                        Member_Unit Imenne = new()
                        {
                            UsersId = createdUser.Entity.Id,
                            UnitId = ImenneItem.UnitId,
                            IsActive = true,
                            DateJoined = DateTime.Now
                        };
                        await _dataContext.Member_Unit.AddAsync(Imenne);
                    }
                    var VillageItem = await _dataContext.Village.Where(x => x.Id == villageId).FirstOrDefaultAsync();
                    if (VillageItem != null)
                    {
                        Member_Unit Village = new()
                        {
                            UsersId = createdUser.Entity.Id,
                            UnitId = VillageItem.UnitId,
                            IsActive = true,
                            DateJoined = DateTime.Now
                        };
                        await _dataContext.Member_Unit.AddAsync(Village);
                    }
                    Notification notification = new()
                    {
                        Message = "User Account Created",
                        DateCreated = DateTime.UtcNow,
                        UserId = createdUser.Entity.Id,
                        Type = "User creation", 
                        IsRead = false
                    };
                    await _dataContext.Notification.AddAsync(notification);

                    await _dataContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return createdUser.Entity;
                }
                await transaction.RollbackAsync();
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
                   // await NotificationCreation(user.Id, "Users Name Updated");
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
                  //  await NotificationCreation(user.Id, "Users Passport Updated");
                }
               
                if (!string.IsNullOrWhiteSpace(user.Password))
                {
                    var passwordCheck = VerifyPassword(user.Password.Trim(), userDetails.Password);
                    if (!passwordCheck)
                    {
                        userDetails.Password = HashPassword(user.Password.Trim());
                    }
                   // await NotificationCreation(user.Id, "Users Password Updated");
                }

                if(user.RoleId > 0)
                {
                    userDetails.RoleId = user.RoleId;
                }
                if (!string.IsNullOrEmpty(user.BackGroundImageUrl))
                {
                    userDetails.BackGroundImageUrl = user.BackGroundImageUrl;
                   // await NotificationCreation(user.Id, "Users Background Image Updated");
                }
                if (!string.IsNullOrEmpty(user.Title))
                {
                    userDetails.Title = user.Title;
                  //  await NotificationCreation(user.Id, "Users Salutation Updated");
                }
                if (!string.IsNullOrEmpty(user.AboutMe))
                {
                    userDetails.AboutMe = user.AboutMe;
                    //await NotificationCreation(user.Id, "Users Bio Updated");
                }
                if (!string.IsNullOrEmpty(user.MaidenName))
                {
                    userDetails.MaidenName = user.MaidenName;
                    //await NotificationCreation(user.Id, "Users Bio Updated");
                }

                _dataContext.Users.Update(userDetails);
                await _dataContext.SaveChangesAsync();
                return userDetails;
            }
            return null;
        }

        public async Task NotificationCreation(long userId, string type)
        {
            Notification notification = new()
            {
                Message = type+" Successful",
                DateCreated = DateTime.UtcNow,
                UserId = userId,
                Type = type+" Login",
                IsRead = false
            };
            await _dataContext.Notification.AddAsync(notification);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<List<Role>> GetAllRoles()
        {
            return await _dataContext.Role.ToListAsync();
        }

        public async Task<List<Users>> GetUnitAdmins()
        {
            return await _dataContext.Users.Where(x => x.IsActive == true && x.RoleId == 4).ToListAsync();
        }
        public string HashPassword(string password)
        {
            // Generate a salt
            string salt = BCrypt.Net.BCrypt.GenerateSalt();

            // Hash the password using the salt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);

            return hashedPassword;
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            // Verify the password against the hashed password
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
