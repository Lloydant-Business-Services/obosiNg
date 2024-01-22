using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Services
{
    public class UnitService : IUnit
    {
        public Task<Unit> ConfirmUnit(int unitId, long UserId)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> JoinUnit(int unitId, long UserId)
        {
            throw new NotImplementedException();
        }
    }
}
