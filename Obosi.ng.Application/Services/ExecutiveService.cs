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
    public class ExecutiveService : IExecutive
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public ExecutiveService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public Task<Executive> CreateExecutive(Executive executive)
        {
            throw new NotImplementedException();
        }

        public Task DeleteExecutive(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Executive>> GetAllExecutives()
        {
            return await _dataContext.Executive.ToListAsync();
        }

        public async Task<Executive> GetExecutivesById(int id)
        {
            return await _dataContext.Executive.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Executive>> GetExecutivesByUnit(int unitId)
        {
            return await _dataContext.Executive.Where(x=>x.UnitId == unitId).ToListAsync();
        }

        public Task<List<Executive>> GetHomePageExecutives()
        {
            throw new NotImplementedException();
        }

        public Task<Executive> UpdateExecutive(Executive executive)
        {
            throw new NotImplementedException();
        }
    }
}
