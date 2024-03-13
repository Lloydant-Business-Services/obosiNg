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

        public async Task<Calender_Assets> CreateAsset(Calender_Assets asset)
        {
            if(asset != null)
            {
                asset.IsActive = true;
                asset.DateAdded = DateTime.Now;
                var assets=  await _dataContext.Calender_Assets.AddAsync(asset);
                await _dataContext.SaveChangesAsync();
                return assets.Entity;
            } 
            return null;
        }

        public async Task DeleteAsset(int id)
        {
           if(id > 0)
            {
                var asset = _dataContext.Calender_Assets.Where(x => x.Id == id).FirstOrDefault();
                if(asset != null)
                {
                    _dataContext.Calender_Assets.Remove(asset);
                   await  _dataContext.SaveChangesAsync();
                }
            }
           
        }

        public async Task<List<Calender_Assets>> GetAssets()
        {
            return await _dataContext.Calender_Assets.OrderBy(x => x.DateAdded).ToListAsync();
        }

        public async Task<Calender_Assets> GetAssets(int id)
        {
            return await _dataContext.Calender_Assets.Where(x => x.Id == id).OrderBy(x => x.DateAdded).FirstOrDefaultAsync();   
        }

        public async Task<List<Calender_Assets>> GetAssetsByUnitId(int unitId)
        {
            return await _dataContext.Calender_Assets.Where(x=>x.UnitId == unitId).OrderBy(x => x.DateAdded).ToListAsync();
        }

        public async Task<List<Calender_Assets>> GetHomePageAssets()
        {
            return await _dataContext.Calender_Assets.Where(x=>x.IsActive).OrderBy(x => x.DateAdded).Take(6).ToListAsync();
        }

        public async Task<Calender_Assets> UpdateAsset(Calender_Assets asset)
        {
            if(asset != null)
            {
                _dataContext.Calender_Assets.Update(asset);
                await  _dataContext.SaveChangesAsync();
                return asset;
            }
            return null;
        }
    }
}
