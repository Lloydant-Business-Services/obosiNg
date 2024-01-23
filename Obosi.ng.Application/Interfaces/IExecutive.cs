using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IExecutive
    {
        Task<List<Executive>> GetAllExecutives();
        Task<List<Executive>> GetHomePageExecutives();
        Task<List<Executive>> GetExecutivesByUnit(int unitId);
        Task<Executive> GetExecutivesById(int id);
        Task<Executive> CreateExecutive(Executive executive);
        Task<Executive> UpdateExecutive(Executive executive);
        Task DeleteExecutive(int id);
    }
}
