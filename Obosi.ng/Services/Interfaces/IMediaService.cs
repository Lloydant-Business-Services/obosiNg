using Obosi.ng.Models.Dto;

namespace Obosi.ng.Services.Interfaces
{
    public interface IMediaService
    {
        Task<bool> CreateMedia(IFormFile file, string type);
        Task<ViewMediaDto> GetMediaByEventId(int eventId);
        Task<ViewMediaDto> GetMediaByUnitId(int unitId);
    }
}
