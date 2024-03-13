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
        Task<List<Picture_Assets>> GetPicturesByUnit();
        Task<List<Video_Assets>> GetVideoByUnit();
        Task<Picture_Assets> GetPicture(int id);
        Task<Video_Assets> GetVideo(int id);
        Task CreatePicture(Picture_Assets picture);
        Task CreateVideo(Video_Assets video);
        Task UpdatePicture(Picture_Assets picture);
        Task UpdateVideo(Video_Assets video);
        Task DeletePicture(int id);
        Task DeleteVideo(int id);
    }
}
