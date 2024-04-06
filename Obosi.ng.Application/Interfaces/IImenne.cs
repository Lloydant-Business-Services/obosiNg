using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IImenne
    {
        Task<Imenne> CreateImenne(Imenne imenne);
        Task DeleteImenne(int id);
        Task<List<Imenne>> GetImenne();
        Task<List<Imenne>> GetImenneByUmunna(int UmunnaId);
    }
}
