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
        Task<List<Calender_Assets>> GetAssets(string email);
        Task<List<Calender_Assets>> GetAllAssets();
        Task<Calender_Assets> GetAssets(int id);
        Task<List<Calender_Assets>> GetHomePageAssets();
        Task<List<Calender_Assets>> GetAssetsByUnitId(int unitId);
        Task<Calender_Assets> CreateAsset(Calender_Assets asset);
        Task<Calender_Assets> UpdateAsset(Calender_Assets asset);
        Task DeleteAsset(int id);
    }
}
