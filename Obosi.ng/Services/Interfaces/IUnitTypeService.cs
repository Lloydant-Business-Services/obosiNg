using Obosi.ng.Models.EntityModel;

namespace Obosi.ng.Services.Interfaces
{
    public interface IUnitTypeService
    {
        Task<UnitType> CreateUnitType(UnitType unitType);
        Task<UnitType> UpdateUnitType(UnitType unitType);
        Task<bool> DeleteUnitType(UnitType unitType);
        Task<UnitType> GetUnitType(int id);
        Task<List<UnitType>> GetAllUnitTypes();
    }
}
