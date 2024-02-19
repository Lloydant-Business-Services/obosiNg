using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Data;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Services
{
    public class MediaService : IMedia
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
  
        public MediaService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task CreatePicture(Picture_Assets picture)
        {
            if (picture != null)
            {
              var created = await  _dataContext.Picture_Assets.AddAsync(picture);
              await  _dataContext.SaveChangesAsync();
            }         
        }

        public async Task CreateVideo(Video_Assets video)
        {
            if (video != null)
            {
                var created = await _dataContext.Video_Assets.AddAsync(video);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task DeletePicture(int id)
        {
            if (id > 0)
            {
                var picture =await _dataContext.Picture_Assets.FirstOrDefaultAsync(x => x.Id == id);
                if (picture != null)
                {
                    _dataContext.Picture_Assets.Remove(picture);
                    await _dataContext.SaveChangesAsync();
                }
            }   
        }

        public async Task DeleteVideo(int id)
        {
            if (id > 0)
            {
                var video = await _dataContext.Video_Assets.FirstOrDefaultAsync(x => x.Id == id);
                if (video != null)
                {
                    _dataContext.Video_Assets.Remove(video);
                  await _dataContext.SaveChangesAsync();
                }
            }   
        }

        public async Task<Picture_Assets> GetPicture(int id)
        {
            return await _dataContext.Picture_Assets.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Picture_Assets>> GetPicturesByUnit(int unitId)
        {
           return await _dataContext.Picture_Assets.Where(x=>x.UnitId == unitId).ToListAsync();
        }

        public async Task<List<Picture_Assets>> GetPicturesByUnit()
        {
           return await _dataContext.Picture_Assets.ToListAsync();
        }

        public async Task<Video_Assets> GetVideo(int id)
        {
            return await _dataContext.Video_Assets.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Video_Assets>> GetVideoByUnit(int unitId)
        {
            return await _dataContext.Video_Assets.Where(x => x.UnitId == unitId).ToListAsync();
        }

        public Task<List<Video_Assets>> GetVideoByUnit()
        {
           return _dataContext.Video_Assets.ToListAsync();
        }

        public async Task UpdatePicture(Picture_Assets picture)
        {
           if (picture != null)
            {
                _dataContext.Picture_Assets.Update(picture);
               await _dataContext.SaveChangesAsync();
            }
        }

        public async Task UpdateVideo(Video_Assets video)
        {
          if (video != null)
            {
                _dataContext.Video_Assets.Update(video);
                await  _dataContext.SaveChangesAsync();
            }
          
        }
    }
}
