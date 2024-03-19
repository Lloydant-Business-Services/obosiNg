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
    public class BoulevardService : IBoulevard
    {
        private readonly DataContext _dataContext;
        public BoulevardService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Builders_Boulevard> CreateBoulevard(Builders_Boulevard builders_Boulevard)
        {
            if(builders_Boulevard != null)
            {
                builders_Boulevard.Description = "N/A";
                builders_Boulevard.Title = "N/A";
               var createdItems= await _dataContext.Builders_Boulevard.AddAsync(builders_Boulevard);
                await _dataContext.SaveChangesAsync();
                return createdItems.Entity;
            }
            throw new Exception("Failed To Create");
        }

        public Task DeleteBoulevard(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Builders_Boulevard>> GetBoulevard(int pageId)
        {
            if (pageId > 0)
            {
                // Determine the offset for the current page
                int offset = (pageId-1)  * 10;

                // Fetch the specified page of data
                var boulevardList = await _dataContext.Builders_Boulevard
                    .Skip(offset)
                    .Take(10)
                    .ToListAsync();
                return boulevardList;

            }
            return null;
        }

        public async Task<List<Builders_Boulevard>> GetBoulevard()
        {
            var boulevardList = await _dataContext.Builders_Boulevard
                    .ToListAsync();
            return boulevardList;
        }

        public async Task<Builders_Boulevard> GetBoulevardById(int id)
        {
            return await _dataContext.Builders_Boulevard.Where(x => x.Id == id).FirstOrDefaultAsync();  
        }

        public async Task<Builders_Boulevard> UpdateBoulevard(Builders_Boulevard builders_Boulevard)
        {
            if(builders_Boulevard != null)
            {
                var builder = await _dataContext.Builders_Boulevard.Where(x=>x.Id == builders_Boulevard.Id).FirstOrDefaultAsync();
                if (builder != null)
                {
                    if (!string.IsNullOrWhiteSpace(builders_Boulevard.FullName))
                    {
                        builder.FullName = builders_Boulevard.FullName;
                    }
                    if (builders_Boulevard.Amount > 0)
                    {
                        builder.Amount = builders_Boulevard.Amount;
                    }
                    _dataContext.Builders_Boulevard.Update(builder);
                    await _dataContext.SaveChangesAsync();
                }
            }
            return builders_Boulevard;
        }
    }
}
