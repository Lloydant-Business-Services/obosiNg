using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IVillage
    {
        Task<Village> CreateVillage(Village village);
      
        Task<List<Village>> GetVillages();
    }
}
