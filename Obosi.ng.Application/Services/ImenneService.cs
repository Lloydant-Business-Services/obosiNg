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
    public class ImenneService : IImenne
    {
        private readonly DataContext _dataContext;
        public ImenneService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Imenne> CreateImenne(Imenne imenne)
        {
            if(imenne != null) 
            { 
                imenne.Active = true;   
                var createdImenne = await _dataContext.Imenne.AddAsync(imenne);
                await _dataContext.SaveChangesAsync();
                return createdImenne.Entity;
            }
            throw new Exception("Imene Item is Null");
        }

        public async Task DeleteImenne(int id)
        {
            var existingImenne= await _dataContext.Imenne.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (existingImenne != null)
            {
                existingImenne.Active = false;
                _dataContext.Imenne.Update(existingImenne);
                await _dataContext.SaveChangesAsync();
            }
            throw new Exception("Imenne Item is Null");
        }

        public async Task<List<Imenne>> GetImenne()
        {
            return await _dataContext.Imenne.Where(x=>x.Active == true).Include(x => x.Unit).Include(x => x.Umunna.Aka.Village).ToListAsync();
        }

        public async Task<List<Imenne>> GetImenneByUmunna(int UmunnaId)
        {
            return await _dataContext.Imenne.Where(x=>x.UnitId == UmunnaId && x.Active == true).Include(x=>x.Unit).Include(x=>x.Umunna.Aka.Village).ToListAsync();
        }

      
    }
}
