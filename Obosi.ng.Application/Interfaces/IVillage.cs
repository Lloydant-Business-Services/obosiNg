using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Application.Interfaces
{
    public interface IVillage
    {
        Task<Village> CreateVillage(Village village);

        Task<List<Village>> GetVillages();
        Task<Village> GetVillageById(int villageId);
    }
}
