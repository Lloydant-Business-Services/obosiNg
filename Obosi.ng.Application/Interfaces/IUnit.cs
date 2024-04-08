using Obosi.ng.Application.DTO;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IUnit
    {
        Task<Unit?> JoinUnit(int unitId, long userId);
        Task<Unit> ConfirmUnit(int unitId, long userId);
        Task<List<Member_Unit>> GetAllMembersByUnitId(int unitId);
        Task<List<Unit_Type>> GetAllUnitTypes();
        Task<List<Unit>> GetAllUnitsByUnitType(int Unit_TypeId);
        Task<List<Unit>> GetAllUmunna();
        Task<List<Unit>> GetAllUnits();
        Task<List<Unit>> GetAllUnits(string email);
        Task<DashBoardDTO> GetDashBoardDTO();
        Task<Unit> GetUnit(int unitId);
        Task<Unit> CreateUnit(Unit unit);
        Task<Unit_Type> CreateUnitType(Unit_Type Unit_Type);
        Task<Unit_Type> GetUnitType(int Unit_TypeId);
        Task<Unit> UpdateUnit(Unit unit);   
        Task<Unit_Type> UpdateUnitType(Unit_Type Unit_Type);
        Task<List<Member_Unit>> ViewApprovedMembers();
        Task<List<Member_Unit>> ViewUnApprovedMembers();

        Task<List<UnitAdmin>> GetAdmins();
        Task<UnitAdmin> CreateAdmin(UnitAdmin admin);
        Task DeleteAdmin(long id);

        Task<List<Village>> GetVillages();
        Task<List<Aka>> Akas(int villageId);
        Task<List<Umunna>> GetUmunnas(int akaId);
        Task<List<Imenne>> GetImennes(int umunnaId);
    }
}
