using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Unit_Type> CreateUnitType(Unit_Type unittype)
        {
            if(unittype != null)
            {
                var created = await _dataContext.Unit_Type.AddAsync(unittype);
                await _dataContext.SaveChangesAsync();
                return created.Entity;  
            }
            throw new Exception("Unit type is empty");
        }

       

        public async Task<List<Member_Unit>> GetAllMembersByUnitId(int unitId)
        {
            return await _dataContext.Member_Unit.Where(x=>x.UnitId == unitId).Include
                (x=>x.Users).Include(x=>x.Unit).OrderBy(p => p.Users.LastName).ToListAsync();

        }

        public async Task<List<Unit>> GetAllUmunna()
        {
            return await _dataContext.Unit.Where(x => x.UnitTypeId == (int)UnitTypes.Umunna).Include(x => x.UnitType).OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<List<Unit>> GetAllUnits()
        {
            return await _dataContext.Unit.Include(x => x.UnitType).OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<List<Unit>> GetAllUnits(string email)
        {
            var userRole = await _dataContext.Users.Where(r => r.Email == email).FirstOrDefaultAsync();
            if(userRole.RoleId == (int)Enums.Role.Admin)
            {
                return await _dataContext.Unit.Include(x => x.UnitType).OrderBy(p => p.Name).ToListAsync();
            }
            return await _dataContext.Member_Unit.Where(x => x.Users.Email == email)
                                                 .Include(x => x.Unit)
                                                 .Select(x => x.Unit)
                                                 .ToListAsync();               
        }

        public async Task<List<Unit>> GetAllUnitsByUnitType(int unitTypeId)
        {
            return await _dataContext.Unit.Where(x => x.UnitTypeId == unitTypeId).Include(x => x.UnitType).OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<List<Unit_Type>> GetAllUnitTypes()
        {
            return await _dataContext.Unit_Type.OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<DashBoardDTO> GetDashBoardDTO()
        {
            DashBoardDTO model = new();
            var Users = await _dataContext.Users.ToListAsync();
            var units = await _dataContext.Unit.ToListAsync();
            var Umunna = units.Where(x => x.UnitTypeId == (int)UnitTypes.Umunna).OrderBy(p => p.Name).ToList();
            var Odus = units.Where(x => x.UnitTypeId == (int)UnitTypes.ODU_chapter).OrderBy(p => p.Name).ToList();
            var villages = units.Where(x => x.UnitTypeId == (int)UnitTypes.Village).OrderBy(p => p.Name).ToList();
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
            return await _dataContext.Unit.Where(x => x.Id == unitId).FirstOrDefaultAsync();
        }

        public async Task<Unit_Type> GetUnitType(int unittypeId)
        {
            return await _dataContext.Unit_Type.Where(x=>x.Id == unittypeId).FirstOrDefaultAsync();
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

        public async Task<Unit_Type> UpdateUnitType(Unit_Type unittype)
        {
            if(unittype != null)
            {
                if (!string.IsNullOrWhiteSpace(unittype.Name))
                {
                    _dataContext.Unit_Type.Update(unittype);
                    await _dataContext.SaveChangesAsync();
                }
                return unittype;
            }
            return null;
        }

        public async Task<List<Member_Unit>> ViewApprovedMembers()
        {
            return await _dataContext.Member_Unit.Where(x => x.IsActive == true && x.Unit.UnitTypeId == (int)UnitTypes.Umunna).Include(x=>x.Unit.UnitType).Include(x=>x.Users).ToListAsync();
        }

        public async Task<List<Member_Unit>> ViewUnApprovedMembers()
        {
            return await _dataContext.Member_Unit.Where(x => x.IsActive == false && x.Unit.UnitTypeId == (int)UnitTypes.Umunna).Include(x => x.Unit.UnitType).Include(x => x.Users).ToListAsync();
        }
    }
}
