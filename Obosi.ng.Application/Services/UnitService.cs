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

        public async Task<List<ImeNne>> GetAllImeNneByUmunna(int unitId)
        {
            return await _dataContext.ImeNne.Where(x => x.UnitId == unitId).ToListAsync();
        }

        public async Task<List<Member_Unit>> GetAllMembersByUnitId(int unitId)
        {
            return await _dataContext.Member_Unit.Where(x=>x.UnitId == unitId).Include
                (x=>x.Users).Include(x=>x.Unit).ToListAsync();

        }

        public async Task<List<Unit>> GetAllUmunna()
        {
            return await _dataContext.Unit.Where(x => x.UnitTypeId == (int)UnitTypes.Umunna).Include(x => x.UnitType).ToListAsync();
        }

        public async Task<List<Unit>> GetAllUnitsByUnitType(int unitTypeId)
        {
            return await _dataContext.Unit.Where(x => x.UnitTypeId == unitTypeId).Include(x=>x.UnitType).ToListAsync();
        }

        public async Task<List<Unit_Type>> GetAllUnitTypes()
        {
            return await _dataContext.Unit_Type.ToListAsync();
        }

        public async Task<DashBoardDTO> GetDashBoardDTO()
        {
            DashBoardDTO model = new();
            var Users = await _dataContext.Users.ToListAsync();
            var units = await _dataContext.Unit.ToListAsync();
            var Umunna = units.Where(x => x.UnitTypeId == (int)UnitTypes.Umunna).ToList();
            var Odus = units.Where(x => x.UnitTypeId == (int)UnitTypes.ODU_chapter).ToList();
            var villages = units.Where(x => x.UnitTypeId == (int)UnitTypes.Village).ToList();
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
    }
}
