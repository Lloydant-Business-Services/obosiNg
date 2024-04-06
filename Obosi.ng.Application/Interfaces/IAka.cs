using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IAka
    {
        Task<Aka> CreateAka(Aka aka);
        Task<Aka> UpdateAka(Aka aka);
        Task DeleteAka(int id);
        Task<List<Aka>> GetAka();
        Task<List<Aka>> GetAkaByVillage(int VillageId);
    }
}
