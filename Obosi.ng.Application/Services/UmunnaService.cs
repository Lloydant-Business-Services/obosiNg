
using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.Enums;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
using Obosi.ng.Domain.Entity;
using Obosi.ng.Infrastructure.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Services
{
    public class UmunnaService : IUmunna
    {
        private readonly DataContext _dataContext;
        public UmunnaService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Umunna> CreateUmunna(Umunna umunna)
        {
           if(umunna != null)
           {
                umunna.Active  = true;
                var createdUmunna = await _dataContext.AddAsync(umunna);
                await  _dataContext.SaveChangesAsync();
                return createdUmunna.Entity;
            }
            throw new Exception("Umunna Item is Null");
        }

        public async Task DeleteUmunna(int id)
        {
            var existingUmunna = await _dataContext.Umunna.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (existingUmunna != null)
            {
                existingUmunna.Active = false;
                _dataContext.Umunna.Update(existingUmunna);
                await _dataContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Umunna Item is Null");
            }
        }

        public async Task<List<Umunna>> GetUmunna()
        {
            return await _dataContext.Umunna.Include(x => x.Aka.Unit.UnitType).Include
               (x => x.Unit).ToListAsync();
        }

        public async Task<List<Umunna>> GetUmunnaByAka(int AkaId)
        {
            return await _dataContext.Umunna.Where(x=>x.AkaId == AkaId).Include(x=>x.Aka.Unit.UnitType).Include
                (x=>x.Unit).ToListAsync();
        }

        public async Task<Umunna> UpdateUmunna(Umunna umunna)
        {
            var existingUmunna = await _dataContext.Umunna.Where(x => x.Id == umunna.Id).FirstOrDefaultAsync();
            if (existingUmunna != null)
            {
                existingUmunna.UnitId = umunna.UnitId;  
                existingUmunna.AkaId = umunna.Aka.Id;
                _dataContext.Umunna.Update(existingUmunna);
                await _dataContext.SaveChangesAsync();
            }
            throw new Exception("Umunna Item is Null");
        }
    }
}
