using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Application.Services
{
    public class ImenneService : IImenne
    {
        private readonly DataContext _dataContext;
        public ImenneService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Imenne> CreateImenne(Imenne imenne)
        {
            if (imenne != null)
            {
                var existingImenne = await _dataContext.Imenne.Where(f => f.UnitId == imenne.UnitId && f.UmunnaId == imenne.UmunnaId).FirstOrDefaultAsync();
                if (existingImenne == null)
                {
                    imenne.Active = true;
                    var createdImenne = await _dataContext.Imenne.AddAsync(imenne);
                    await _dataContext.SaveChangesAsync();
                    return createdImenne.Entity;
                }
                else
                {
                    existingImenne.Active = true;
                    _dataContext.Imenne.Update(existingImenne);
                    await _dataContext.SaveChangesAsync();
                    return existingImenne;
                }
            }
            throw new Exception("Imene Item is Null");
        }

        public async Task DeleteImenne(int id)
        {
            var existingImenne = await _dataContext.Imenne.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (existingImenne != null)
            {
                existingImenne.Active = false;
                _dataContext.Imenne.Update(existingImenne);
                await _dataContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Imenne Item is Null");
            }
        }

        public async Task<List<Imenne>> GetImenne()
        {
            return await _dataContext.Imenne.Where
                (x => x.Active == true).Include(x => x.Unit).Include(x => x.Umunna.Unit.Unit_Type).ToListAsync();

        }

        public async Task<List<Imenne>> GetImenneByUmunna(int UmunnaId)
        {
            return await _dataContext.Imenne.Where(x => x.UmunnaId == UmunnaId && x.Active == true).Include(x => x.Unit).Include(x => x.Umunna.Unit.Unit_Type).ToListAsync();
        }


    }
}
