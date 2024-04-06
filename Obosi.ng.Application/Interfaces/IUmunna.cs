using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IUmunna
    {
        Task<Umunna> CreateUmunna(Umunna umunna);
        Task<Umunna> UpdateUmunna(Umunna umunna);
        Task DeleteUmunna(int id);
        Task<List<Umunna>> GetUmunna();
        Task<List<Umunna>> GetUmunnaByAka(int AkaId);
    }
}
