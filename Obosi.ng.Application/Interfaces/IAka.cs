using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Application.Interfaces
{
    public interface IAka
    {
        Task<Aka> CreateAka(Aka aka);
        Task<Aka> UpdateAka(Aka aka);
        Task DeleteAka(int id);
        Task<List<Aka>> GetAka();
        Task<List<Aka>> GetAkaByVillage(int VillageId);
        Task<Aka> GetAkaById(int Id);
    }
}
