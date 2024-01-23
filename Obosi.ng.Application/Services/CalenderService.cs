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
    public class CalenderService : ICalender
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public CalenderService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<List<Calender_Assets>> GetAssets()
        {
            return await _dataContext.Calender_Assets.OrderBy(x => x.DateAdded).ToListAsync();
        }

        public async Task<List<Calender_Assets>> GetAssetsByUnitId(int unitId)
        {
            return await _dataContext.Calender_Assets.Where(x=>x.UnitId == unitId).OrderBy(x => x.DateAdded).ToListAsync();
        }

        public async Task<List<Calender_Assets>> GetHomePageAssets()
        {
            return await _dataContext.Calender_Assets.OrderBy(x => x.DateAdded).Take(6).ToListAsync();
        }
    }
}
