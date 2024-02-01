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
               var createdItems= await _dataContext.Builders_Boulevard.AddAsync(builders_Boulevard);
                await _dataContext.SaveChangesAsync();
                return createdItems.Entity;
            }
            throw new Exception("Failed To Create");
        }

        public async Task<List<Builders_Boulevard>> GetBoulevard(int pageId)
        {
            // Determine the offset for the current page
            int offset = (pageId - 1) * 10;

            // Fetch the specified page of data
            var boulevardList = await _dataContext.Builders_Boulevard
                .Skip(offset)
                .Take(10)
                .ToListAsync();
            return boulevardList;
        }
    }
}
