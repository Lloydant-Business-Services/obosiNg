using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface ICalender
    {
        Task<List<Calender_Assets>> GetAssets();
        Task<List<Calender_Assets>> GetHomePageAssets();
        Task<List<Calender_Assets>> GetAssetsByUnitId(int unitId);
    }
}
