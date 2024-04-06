using Microsoft.EntityFrameworkCore;
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
    public class AkaService : IAka
    {
        private readonly DataContext _dataContext;
        public AkaService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Aka> CreateAka(Aka aka)
        {
            if(aka != null)
            {
                aka.Active = true;
                var createdAka = await _dataContext.Aka.AddAsync(aka);  
                await _dataContext.SaveChangesAsync();
                return createdAka.Entity;
            }
            throw new Exception("Aka Item is Null");
        }

        public async Task DeleteAka(int id)
        {
           var existingAka = await _dataContext.Aka.Where(x=>x.Id == id).FirstOrDefaultAsync();
            if (existingAka != null)
            {
                existingAka.Active = false;
                _dataContext.Aka.Update(existingAka);
                await _dataContext.SaveChangesAsync();
            }

            else
            {
                throw new Exception("Aka Item is Null");
            }
        }

        public async Task<List<Aka>> GetAka()
        {
            return await _dataContext.Aka.Include(x => x.Unit.UnitType).Include(x => x.Village.Unit.UnitType).ToListAsync();
            ;
        }

        public async Task<List<Aka>> GetAkaByVillage(int VillageId)
        {
           return await _dataContext.Aka.Where(x=>x.VillageId == VillageId).Include(x => x.Unit.UnitType).Include(x => x.Village.Unit.UnitType).ToListAsync();
        }

        public async Task<Aka> UpdateAka(Aka aka)
        {
            var existingAka = await _dataContext.Aka.Where(x => x.Id == aka.Id).FirstOrDefaultAsync();
            if (existingAka != null)
            {
                existingAka.UnitId = aka.UnitId;
                existingAka.VillageId = aka.VillageId;
                _dataContext.Aka.Update(existingAka);
                await _dataContext.SaveChangesAsync();
            }
            throw new Exception("Aka Item is Null");
        }
    }
}
