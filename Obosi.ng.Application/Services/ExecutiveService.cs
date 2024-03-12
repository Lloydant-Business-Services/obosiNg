using AutoMapper;
using AutoMapper.Configuration.Annotations;
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
        public async Task<Executive> CreateExecutive(Executive executive)
        {
           if(executive != null)
            {
                executive.DateCreated = DateTime.Now;
                executive.IsActive = true;
                var executiveEntity = await _dataContext.Executive.AddAsync(executive);
                await _dataContext.SaveChangesAsync();
                return executiveEntity.Entity;
            }
            return null;
        }

        public async Task DeleteExecutive(int id)
        {
            if(id > 0)
            {
                var executive = _dataContext.Executive.Where(x => x.Id == id).FirstOrDefault();
                if(executive != null)
                {
                    _dataContext.Executive.Remove(executive);
                  await  _dataContext.SaveChangesAsync();
                }
            }   
        }

        public async Task<List<Executive>> GetAllExecutives()
        {
            return await _dataContext.Executive.Include(x => x.Unit).Include(x=>x.User).ToListAsync();
        }

        public async Task<List<Users>> GetAllUsers(int unitId)
        {
            var users = await _dataContext.Member_Unit
                .Where(x => x.UnitId == unitId)
                .Include(x=>x.Users)
                .Select(x => x.Users)
                .OrderBy(x=>x.FirstName)
                .ToListAsync();
            return users;
        }

        public async Task<Executive> GetExecutivesById(int id)
        {
            return await _dataContext.Executive.Where(x => x.Id == id).Include(x => x.User).Include(x => x.Unit.UnitType).FirstOrDefaultAsync();
        }

        public async Task<List<Executive>> GetExecutivesByUnit(int unitId)
        {
            return await _dataContext.Executive.Where(x=>x.UnitId == unitId).Include(x=>x.User).ToListAsync();
        }

        public Task<List<Executive>> GetHomePageExecutives()
        {
            throw new NotImplementedException();
        }

        public async Task<Executive> UpdateExecutive(Executive executive)
        {
            if(executive != null)
            {
                var existingExecutive = await _dataContext.Executive.Where(x => x.Id == executive.Id).FirstOrDefaultAsync();
                if(existingExecutive != null)
                {
                    if(!string.IsNullOrWhiteSpace(executive.Designation))
                    {
                        existingExecutive.Designation = executive.Designation;
                    }
                    
                }
                _dataContext.Executive.Update(existingExecutive);
                await _dataContext.SaveChangesAsync();
                return executive;
            }
            return null;
        }
    }
}
