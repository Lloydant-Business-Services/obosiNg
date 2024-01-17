using Obosi.ng.Models.EntityModel;

namespace Obosi.ng.Services.Interfaces
{
    public interface IExecutiveService
    {
        Task<Executive> CreateExecutive(Executive executive);
        Task<Executive> UpdateExecutive(Executive executive);
        Task<Executive> DeleteExecutive(Executive executive);   
        Task<Executive> GetExecutive(int id);
        Task<List<Executive>> GetAllExecutives();
        Task<List<Executive>> GetExecutivesByUnit(int unitId);
    }
}
