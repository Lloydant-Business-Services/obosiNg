using Obosi.ng.Application.DTO;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface Icalender
    {
        Task<Unit?> JoinUnit(int unitId, long userId);
        Task<Unit> ConfirmUnit(int unitId, long userId);
        Task<List<Member_Unit>> GetAllMembersByUnitId(int unitId);
        Task<List<Unit_Type>> GetAllUnitTypes();
        Task<List<Unit>> GetAllUnitsByUnitType(int unitTypeId);
        Task<List<Unit>> GetAllUmunna();
        Task<List<ImeNne>> GetAllImeNneByUmunna(int unitId);
        Task<DashBoardDTO> GetDashBoardDTO();
    }
}
