using Obosi.ng.Models.Dto;
using Obosi.ng.Services.Interfaces;

namespace Obosi.ng.Services.Implementation
{
    public class MediaService : IMediaService
    {
        public Task<bool> CreateMedia(IFormFile file, string type)
        {
            throw new NotImplementedException();
        }

        public Task<ViewMediaDto> GetMediaByEventId(int eventId)
        {
            throw new NotImplementedException();
        }

        public Task<ViewMediaDto> GetMediaByUnitId(int unitId)
        {
            throw new NotImplementedException();
        }
    }
}
