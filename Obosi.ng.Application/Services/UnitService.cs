using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Obosi.ng.Application.DTO;
using Obosi.ng.Application.Enums;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Services
{
    public class UnitService : IUnit
    {

        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public UnitService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<Unit> ConfirmUnit(int unitId, long UserId)
        {
            var unitmember = await _dataContext.Member_Unit.Where(x => x.UnitId == unitId && x.UsersId == UserId)
                .Include(x=>x.Unit).FirstOrDefaultAsync();
            if (unitmember != null)
            {
                unitmember.DateApproved = DateTime.Now;
                unitmember.IsActive = true;
                _dataContext.Member_Unit.Update(unitmember);
                await _dataContext.SaveChangesAsync();
                return unitmember.Unit;
            }
            return null;
        }

		public async Task<UnitAdmin> CreateAdmin(UnitAdmin admin)
		{
			var existingUnitAdmin = await _dataContext.UnitAdmin.Where(x=>x.UsersId == admin.UsersId &&
            x.UnitId == admin.UnitId).Include(x=>x.Unit).Include(x=>x.Users).FirstOrDefaultAsync();
            if(existingUnitAdmin == null)
            {
                admin.DateAdded = DateTime.UtcNow;
                admin.Active = true;
               var res = await _dataContext.UnitAdmin.AddAsync(admin);
                await _dataContext.SaveChangesAsync();
                return res.Entity;
            }
            return existingUnitAdmin;
		}

		public async Task<Unit> CreateUnit(Unit unit)
        {
            if(unit != null)
            {
                unit.DateCreated = DateTime.Now;
                var created = await _dataContext.Unit.AddAsync(unit);
                await _dataContext.SaveChangesAsync();
                return created.Entity;
            }
            throw new Exception("Unit is empty");
        }

        public async Task<Unit_Type> CreateUnitType(Unit_Type Unit_Type)
        {
            if(Unit_Type != null)
            {
                var created = await _dataContext.Unit_Type.AddAsync(Unit_Type);
                await _dataContext.SaveChangesAsync();
                return created.Entity;  
            }
            throw new Exception("Unit type is empty");
        }

		public async Task DeleteAdmin(long id)
		{
			var existingUnit = await _dataContext.UnitAdmin.Where(x=>x.Id == id).FirstOrDefaultAsync();
            if(existingUnit != null)
            {
                 _dataContext.UnitAdmin.Remove(existingUnit);
                await _dataContext.SaveChangesAsync();
            }
		}

		public async Task<List<UnitAdmin>> GetAdmins()
		{
            return await _dataContext.UnitAdmin.Include(x=>x.Users).Include(x=>x.Unit).ToListAsync();
		}

		public async Task<List<Member_Unit>> GetAllMembersByUnitId(int unitId)
        {
            return await _dataContext.Member_Unit.Where(x=>x.UnitId == unitId).Include
                (x=>x.Users).Include(x=>x.Unit).OrderBy(p => p.Users.LastName).ToListAsync();

        }

        public async Task<List<Unit>> GetAllUmunna()
        {
            return await _dataContext.Unit.Where(x => x.Unit_TypeId == (int)Unit_Types.Umunna).Include(x => x.Unit_Type).OrderBy(p => p.Name)
                .Select(ua => new Unit
                {
                    Name = SentenceCase(ua.Name),
                    About = ua.About,
                    BackGroundImageUrl = ua.BackGroundImageUrl,
                    CanHaveMembers = ua.CanHaveMembers,
                    DateCreated = ua.DateCreated,
                    Description = ua.Description,
                    Id = ua.Id,
                    NeedsConfirmation = ua.NeedsConfirmation,
                    Unit_TypeId = ua.Unit_TypeId,
                    Unit_Type
                = ua.Unit_Type
                })
                .ToListAsync();
        }

        public async Task<List<Unit>> GetAllUnits()
        {
            return await _dataContext.Unit.Include(x => x.Unit_Type).OrderBy(p => p.Name)
                .Select(ua => new Unit { Name = SentenceCase(ua.Name),About = ua.About,BackGroundImageUrl =ua.BackGroundImageUrl,
                CanHaveMembers = ua.CanHaveMembers,DateCreated = ua.DateCreated,Description= ua.Description,
                Id= ua.Id,NeedsConfirmation= ua.NeedsConfirmation,Unit_TypeId = ua.Unit_TypeId,Unit_Type
                = ua.Unit_Type})
                .ToListAsync();
          
        }
        private static string SentenceCase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Convert the first character to uppercase
            string sentenceCase = input.Substring(0, 1).ToUpper();

            if (input.Length > 1)
            {
                // Convert the rest of the string to lowercase
                sentenceCase += input.Substring(1).ToLower();
            }

            return sentenceCase;
        }

    

    public async Task<List<Unit>> GetAllUnits(string email)
        {
            var userRole = await _dataContext.Users.Where(r => r.Email == email).FirstOrDefaultAsync();
            if(userRole.RoleId == (int)Enums.Role.Admin)
            {
                return await _dataContext.Unit.Include(x => x.Unit_Type).OrderBy(p => p.Name)
                    .Select(ua => new Unit
                    {
                        Name = SentenceCase(ua.Name),
                        About = ua.About,
                        BackGroundImageUrl = ua.BackGroundImageUrl,
                        CanHaveMembers = ua.CanHaveMembers,
                        DateCreated = ua.DateCreated,
                        Description = ua.Description,
                        Id = ua.Id,
                        NeedsConfirmation = ua.NeedsConfirmation,
                        Unit_TypeId = ua.Unit_TypeId,
                        Unit_Type
                = ua.Unit_Type
                    })
                    .ToListAsync();
            }
            return await _dataContext.UnitAdmin.Where(x => x.Users.Email == email)
                                                 .Include(x => x.Unit.Unit_Type)
                                                
                                                 .Select(ua => new Unit
                                                 {
                                                     Name = SentenceCase(ua.Unit.Name),
                                                     About = ua.Unit.About,
                                                     BackGroundImageUrl = ua.Unit.BackGroundImageUrl,
                                                     CanHaveMembers = ua.Unit.CanHaveMembers,
                                                     DateCreated = ua.Unit.DateCreated,
                                                     Description = ua.Unit.Description,
                                                     Id = ua.Unit.Id,
                                                     NeedsConfirmation = ua.Unit.NeedsConfirmation,
                                                     Unit_TypeId = ua.Unit.Unit_TypeId,
                                                     Unit_Type
                = ua.Unit.Unit_Type
                                                 })
                                                 .ToListAsync();
          
        }

        public async Task<List<Unit>> GetAllUnitsByUnitType(int Unit_TypeId)
        {
            return await _dataContext.Unit.Where(x => x.Unit_TypeId == Unit_TypeId).Include(x => x.Unit_Type).OrderBy(p => p.Name)
                .Select(ua => new Unit
                {
                    Name = SentenceCase(ua.Name),
                    About = ua.About,
                    BackGroundImageUrl = ua.BackGroundImageUrl,
                    CanHaveMembers = ua.CanHaveMembers,
                    DateCreated = ua.DateCreated,
                    Description = ua.Description,
                    Id = ua.Id,
                    NeedsConfirmation = ua.NeedsConfirmation,
                    Unit_TypeId = ua.Unit_TypeId,
                    Unit_Type
                = ua.Unit_Type
                })
                .ToListAsync();
        }

        public async Task<List<Unit_Type>> GetAllUnitTypes()
        {
            return await _dataContext.Unit_Type.OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<DashBoardDTO> GetDashBoardDTO()
        {
            DashBoardDTO model = new();
            var Users = await _dataContext.Users.ToListAsync();
            var units = await _dataContext.Unit.Include(x=>x.Unit_Type).Select(ua => new Unit
            {
                Name = SentenceCase(ua.Name),
                About = ua.About,
                BackGroundImageUrl = ua.BackGroundImageUrl,
                CanHaveMembers = ua.CanHaveMembers,
                DateCreated = ua.DateCreated,
                Description = ua.Description,
                Id = ua.Id,
                NeedsConfirmation = ua.NeedsConfirmation,
                Unit_TypeId = ua.Unit_TypeId,
                Unit_Type
                = ua.Unit_Type
            }).ToListAsync();
            var Umunna = units.Where(x => x.Unit_TypeId == (int)Unit_Types.Umunna).OrderBy(p => p.Name).ToList();
            var Odus = units.Where(x => x.Unit_TypeId == (int)Unit_Types.ODU_chapter).OrderBy(p => p.Name).ToList();
            var villages = units.Where(x => x.Unit_TypeId == (int)Unit_Types.Village).OrderBy(p => p.Name).ToList();
            model.TotalMembers = Users.Where(x => x.IsActive == true).Count();
            model.NewMembers = Users.Where(x => x.IsActive == false).Count();
            model.TotalOdu = Odus.Count();
            model.Umunnas = Umunna.Count();
            model.Villages  = villages.Take(6).ToList();
            model.Calender = await _dataContext.Calender_Assets.OrderBy(x => x.StartDate).Include(x=>x.Unit).Take(6).ToListAsync();

            return model;
        }

        public async Task<Unit> GetUnit(int unitId)
        {
            return await _dataContext.Unit.Where(x => x.Id == unitId).Select(ua => new Unit
            {
                Name = SentenceCase(ua.Name),
                About = ua.About,
                BackGroundImageUrl = ua.BackGroundImageUrl,
                CanHaveMembers = ua.CanHaveMembers,
                DateCreated = ua.DateCreated,
                Description = ua.Description,
                Id = ua.Id,
                NeedsConfirmation = ua.NeedsConfirmation,
                Unit_TypeId = ua.Unit_TypeId,
                Unit_Type
                = ua.Unit_Type
            }).FirstOrDefaultAsync();
        }

        public async Task<Unit_Type> GetUnitType(int Unit_TypeId)
        {
            return await _dataContext.Unit_Type.Where(x=>x.Id == Unit_TypeId).FirstOrDefaultAsync();
        }

        public async Task<Unit?> JoinUnit(int unitId, long UserId)
        {
            var unit = await _dataContext.Unit.Where(x => x.Id == unitId).FirstOrDefaultAsync();
            if (unit != null)
            {
                Member_Unit member = new()
                {
                    UsersId = UserId,
                    UnitId = unitId,
                    IsActive = false,
                    DateJoined = DateTime.Now
                };
                await _dataContext.Member_Unit.AddAsync(member);
                await _dataContext.SaveChangesAsync();
                return unit;
            }
            return null;
        }

        public async Task<Unit> UpdateUnit(Unit unit)
        {
            if(unit != null)
            {
                var updateUnit = await _dataContext.Unit.Where(x => x.Id == unit.Id).FirstOrDefaultAsync();
                if (updateUnit != null)
                {
                    if (!string.IsNullOrWhiteSpace(unit.Name))
                    {
                        updateUnit.Name = unit.Name;
                    }
                    if (!string.IsNullOrWhiteSpace(unit.About)) 
                    { 
                    updateUnit.About = unit.About;
                     }
                    if (!string.IsNullOrEmpty(unit.BackGroundImageUrl))
                    {
                        updateUnit.BackGroundImageUrl = unit.BackGroundImageUrl;
                    }
                    if (!string.IsNullOrWhiteSpace(unit.Description))
                    {
                        updateUnit.Description = unit.Description;
                    }
                    _dataContext.Unit.Update(updateUnit);
                 await  _dataContext.SaveChangesAsync();
                }
                return  unit;
            }
            return null;
        }

        public async Task<Unit_Type> UpdateUnitType(Unit_Type Unit_Type)
        {
            if(Unit_Type != null)
            {
                if (!string.IsNullOrWhiteSpace(Unit_Type.Name))
                {
                    _dataContext.Unit_Type.Update(Unit_Type);
                    await _dataContext.SaveChangesAsync();
                }
                return Unit_Type;
            }
            return null;
        }

        public async Task<List<Member_Unit>> ViewApprovedMembers()
        {
            return await _dataContext.Member_Unit.Where(x => x.IsActive == true && x.Unit.Unit_TypeId == (int)Unit_Types.Umunna).Include(x=>x.Unit.Unit_Type).Include(x=>x.Users).ToListAsync();
        }

        public async Task<List<Member_Unit>> ViewUnApprovedMembers(string email)
        {
            var userRole = await _dataContext.Users.Where(r => r.Email == email).FirstOrDefaultAsync();
            if (userRole.RoleId == (int)Enums.Role.Admin)
            {
                return await _dataContext.Member_Unit.Where(x => x.IsActive == false && x.Unit.Unit_TypeId == (int)Unit_Types.Umunna)
                .Include(x => x.Unit.Unit_Type).Include(x => x.Users).ToListAsync();
            }
            else
            {
                var membership = await _dataContext.Member_Unit.Where(x => x.Users.Email == email
                && x.Unit.Unit_TypeId == (int)Unit_Types.Umunna).FirstOrDefaultAsync(); 
                if(membership != null)
                {
                    return await _dataContext.Member_Unit.Where(x => x.IsActive == false && x.Unit.Id == 
                  membership.UnitId)
                .Include(x => x.Unit.Unit_Type).Include(x => x.Users).ToListAsync();
                }
                return null;
            }
        }

        public async Task<List<Village>> GetVillages()
        {
           return await _dataContext.Village.Include(x => x.Unit).OrderBy(p => p.Unit.Name)
                .Select(ua => new Village
                {
                    Id = ua.Id,
                    UnitId = ua.UnitId,
                    Unit = new Unit
                    {
                        Name = SentenceCase(ua.Unit.Name),
                        About = ua.Unit.About,
                        BackGroundImageUrl = ua.Unit.BackGroundImageUrl,
                        CanHaveMembers = ua.Unit.CanHaveMembers,
                        DateCreated = ua.Unit.DateCreated,
                        Description = ua.Unit.Description,
                        Id = ua.Id,
                        NeedsConfirmation = ua.Unit.NeedsConfirmation,
                        Unit_TypeId = ua.Unit.Unit_TypeId,
                        Unit_Type = ua.Unit.Unit_Type
                    }
                })
                .ToListAsync(); 
        }

        public async Task<List<Aka>> Akas(int villageId)
        {
            return await _dataContext.Aka.Where(x=>x.VillageId == villageId && x.Active == true).Include(x => x.Unit).OrderBy(p => p.Unit.Name)
                .Select(ua => new Aka
                {  VillageId = ua.VillageId,
                Id = ua.Id,
                Unit = new Unit
                {
                    Name = SentenceCase(ua.Unit.Name),
                    About = ua.Unit.About,
                    BackGroundImageUrl = ua.Unit.BackGroundImageUrl,
                    CanHaveMembers = ua.Unit.CanHaveMembers,
                    DateCreated = ua.Unit.DateCreated,
                    Description = ua.Unit.Description,
                    Id = ua.Id,
                    NeedsConfirmation = ua.Unit.NeedsConfirmation,
                    Unit_TypeId = ua.Unit.Unit_TypeId,
                    Unit_Type = ua.Unit.Unit_Type
                }
                })
                .ToListAsync();
        }

        public async Task<List<Umunna>> GetUmunnas(int akaId)
        {
            return await _dataContext.Umunna.Where(x => x.AkaId == akaId && x.Active == true).Include(x => x.Unit).OrderBy(p => p.Unit.Name)
                  .Select(ua => new Umunna
                  { AkaId = ua.AkaId,
                  Id = ua.Id,
                  Unit = new Unit
                  {
                      Name = SentenceCase(ua.Unit.Name),
                      About = ua.Unit.About,
                      BackGroundImageUrl = ua.Unit.BackGroundImageUrl,
                      CanHaveMembers = ua.Unit.CanHaveMembers,
                      DateCreated = ua.Unit.DateCreated,
                      Description = ua.Unit.Description,
                      Id = ua.Id,
                      NeedsConfirmation = ua.Unit.NeedsConfirmation,
                      Unit_TypeId = ua.Unit.Unit_TypeId,
                      Unit_Type = ua.Unit.Unit_Type
                  }
                  })
                  .ToListAsync();
        }

        public async Task<List<Imenne>> GetImennes(int umunnaId)
        {
            return await _dataContext.Imenne.Where(x => x.UmunnaId == umunnaId && x.Active == true).Include(x => x.Unit).OrderBy(p => p.Unit.Name)
                 .Select(ua => new Imenne
                 { UmunnaId = ua.UmunnaId,  
                 Id = ua.Id,
                 Unit = new Unit
                 {
                     Name = SentenceCase(ua.Unit.Name),
                     About = ua.Unit.About,
                     BackGroundImageUrl = ua.Unit.BackGroundImageUrl,
                     CanHaveMembers = ua.Unit.CanHaveMembers,
                     DateCreated = ua.Unit.DateCreated,
                     Description = ua.Unit.Description,
                     Id = ua.Id,
                     NeedsConfirmation = ua.Unit.NeedsConfirmation,
                     Unit_TypeId = ua.Unit.Unit_TypeId,
                     Unit_Type = ua.Unit.Unit_Type
                 }
                 })
                 .ToListAsync();
        }

        public async Task<List<Unit>> ViewMembership(string email)
        {
            return await _dataContext.Member_Unit.Where(x => x.Users.Email == email).Include(x => x.Unit).Select(x => x.Unit).ToListAsync();
        }
    }
}
