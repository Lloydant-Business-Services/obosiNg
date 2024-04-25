using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
using Obosi.ng.Domain.Entity;

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

            if (aka != null)
            {
                var existingAka = await _dataContext.Aka.Where(f => f.UnitId == aka.UnitId && f.VillageId == aka.VillageId).FirstOrDefaultAsync();
                if (existingAka == null)
                {
                    aka.Active = true;
                    var createdAka = await _dataContext.Aka.AddAsync(aka);
                    await _dataContext.SaveChangesAsync();
                    return createdAka.Entity;
                }
                else
                {
                    existingAka.Active = true;
                    _dataContext.Aka.Update(existingAka);
                    await _dataContext.SaveChangesAsync();
                    return existingAka;
                }

            }
            throw new Exception("Aka Item is Null");
        }

        public async Task DeleteAka(int id)
        {
            var existingAka = await _dataContext.Aka.Where(x => x.Id == id).FirstOrDefaultAsync();
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
            return await _dataContext.Aka.Where(x => x.Active == true).Include(x => x.Unit.Unit_Type).Include(x => x.Village.Unit.Unit_Type).ToListAsync();
            ;
        }

        public async Task<List<Aka>> GetAkaByVillage(int VillageId)
        {
            return await _dataContext.Aka.Where(x => x.VillageId == VillageId && x.Active == true).Include(x => x.Unit.Unit_Type).Include(x => x.Village.Unit.Unit_Type).ToListAsync();
        }
        public async Task<Aka> GetAkaById(int Id)
        {
            return await _dataContext.Aka.Where(x => x.Id == Id).Include(x => x.Unit).Include(x => x.Unit.Unit_Type).Include(x => x.Village.Unit.Unit_Type).FirstOrDefaultAsync();
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
