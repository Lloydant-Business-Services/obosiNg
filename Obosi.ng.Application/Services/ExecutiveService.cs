﻿using AutoMapper;
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

        public async Task<Executive> UpdateExecutive(Executive executive)
        {
            if(executive != null)
            {
                _dataContext.Executive.Update(executive);
                await _dataContext.SaveChangesAsync();
                return executive;
            }
            return null;
        }
    }
}