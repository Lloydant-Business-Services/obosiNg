using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Application.Services
{
    public class VillageService : IVillage
    {
        private readonly DataContext _dataContext;
        public VillageService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Village> CreateVillage(Village village)
        {
            if (village != null)
            {
                village.Active = true;
                var createdVillage = await _dataContext.Village.AddAsync(village);
                await _dataContext.SaveChangesAsync();
                return createdVillage.Entity;
            }
            throw new Exception("Village Item is Null");
        }

        public async Task<List<Village>> GetVillages()
        {
            return await _dataContext.Village.Where(x => x.Active == true).Include(x => x.Unit).ToListAsync();
        }
        public async Task<Village> GetVillageById(int villageId)
        {
            return await _dataContext.Village.Where(x => x.Id == villageId).Include(x => x.Unit).FirstOrDefaultAsync();
        }


    }
}
