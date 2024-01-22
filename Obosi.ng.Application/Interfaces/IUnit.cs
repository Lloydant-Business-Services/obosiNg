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
        Task<Unit> JoinUnit(int unitId, long UserId);
        Task<Unit> ConfirmUnit(int unitId, long UserId);
    }
}
