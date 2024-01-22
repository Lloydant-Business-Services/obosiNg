using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Services
{
    public class ExecutiveService : IExecutive
    {
        public Task<Executive> CreateExecutive(Executive executive)
        {
            throw new NotImplementedException();
        }

        public Task DeleteExecutive(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Executive>> GetAllExecutives()
        {
            throw new NotImplementedException();
        }

        public Task<Executive> GetExecutivesById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Executive>> GetExecutivesByUnit(int unitId)
        {
            throw new NotImplementedException();
        }

        public Task<Executive> UpdateExecutive(Executive executive)
        {
            throw new NotImplementedException();
        }
    }
}
