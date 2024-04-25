
using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
using Obosi.ng.Domain.Entity;

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
            if (umunna != null)
            {
                var existingUmunna = await _dataContext.Umunna.Where(f => f.UnitId == umunna.UnitId && f.AkaId == umunna.AkaId).FirstOrDefaultAsync();
                if (existingUmunna == null)
                {
                    umunna.Active = true;
                    var createdUmunna = await _dataContext.AddAsync(umunna);
                    await _dataContext.SaveChangesAsync();
                    return createdUmunna.Entity;
                }
                else
                {
                    existingUmunna.Active = true;
                    _dataContext.Umunna.Update(existingUmunna);
                    await _dataContext.SaveChangesAsync();
                    return existingUmunna;
                }

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
            return await _dataContext.Umunna.Where(x => x.Active == true).Include(x => x.Aka.Unit.Unit_Type).Include
               (x => x.Unit).OrderBy(f => f.Unit.Name).ToListAsync();
        }

        public async Task<List<Umunna>> GetUmunnaByAka(int AkaId)
        {
            return await _dataContext.Umunna.Where(x => x.AkaId == AkaId && x.Active == true).Include(x => x.Aka.Unit.Unit_Type).Include
                (x => x.Unit).OrderBy(f => f.Unit.Name).ToListAsync();
        }
        public async Task<Umunna> GetUmunnaById(int Id)
        {
            return await _dataContext.Umunna.Where(x => x.Id == Id).Include(x => x.Aka.Unit.Unit_Type).Include
                (x => x.Unit).OrderBy(f => f.Unit.Name).FirstOrDefaultAsync();
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
