using Obosi.ng.Models.EntityModel;

namespace Obosi.ng.Services.Interfaces
{
    public interface IUnitService
    {
         Task<Unit> CreateUnit(Unit unit);    
         Task<Unit> UpdateUnit(Unit unit); 
         Task<bool> DeleteUnit(Unit unit);
         Task<Unit> GetUnitById(int unitId);
         Task<List<Unit>> GetAllUnits();
         Task<List<Unit>> GetAllUnitsByUnitType(int unitTypeId);
    }
}
