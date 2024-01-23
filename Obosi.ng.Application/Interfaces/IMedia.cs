using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IMedia
    {
        Task<List<Picture_Assets>> GetPicturesByUnit(int unitId);
        Task<List<Video_Assets>> GetVideoByUnit(int unitId);    
    }
}
