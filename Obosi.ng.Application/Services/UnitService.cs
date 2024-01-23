using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
        public Task<Unit> ConfirmUnit(int unitId, long UserId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Member_Unit>> GetAllMembersByUnitId(int unitId)
        {
            return await _dataContext.Member_Unit.Where(x=>x.UnitId == unitId).Include
                (x=>x.Users).Include(x=>x.Unit).ToListAsync();

        }

        public Task<Unit> JoinUnit(int unitId, long UserId)
        {
            throw new NotImplementedException();
        }
    }
}
