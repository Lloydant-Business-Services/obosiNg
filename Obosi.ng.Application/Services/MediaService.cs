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
           return await _dataContext.Picture_Assets.Where(x=>x.UnitId == unitId).Include(x => x.Unit).OrderBy(x=>x.Caption).ToListAsync();
        }

        public async Task<List<Picture_Assets>> GetPicturesByUnit(string email)
        {
            var userRole = await _dataContext.Users.Where(r => r.Email == email).FirstOrDefaultAsync();
            if (userRole.RoleId == (int)Enums.Role.Admin)
            {
                return await _dataContext.Picture_Assets.Include(x => x.Unit).ToListAsync();
            }
            else
            {
                List<Picture_Assets> allAssets = new List<Picture_Assets>();
                var roles = await _dataContext.UnitAdmin.Where(x => x.Users.Email == email).ToListAsync();
                foreach (var role in roles)
                {
                    var assets = await _dataContext.Picture_Assets.Where(x => x.UnitId == role.UnitId)
                        .Include(x => x.Unit.UnitType).ToListAsync();
                    allAssets.AddRange(assets);
                }
                return allAssets;
            }
           
        }

        public async Task<Video_Assets> GetVideo(int id)
        {
            return await _dataContext.Video_Assets.Include(x => x.Unit).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Video_Assets>> GetVideoByUnit(int unitId)
        {
            return await _dataContext.Video_Assets.Where(x => x.UnitId == unitId).OrderBy(x=>x.Caption).ToListAsync();
        }

        public async Task<List<Video_Assets>> GetVideoByUnit(string email)
        {
          
            var userRole = await _dataContext.Users.Where(r => r.Email == email).FirstOrDefaultAsync();
            if (userRole.RoleId == (int)Enums.Role.Admin)
            {
                return await _dataContext.Video_Assets.Include(x => x.Unit).Include(x => x.Unit).ToListAsync();
            }
            else
            {
                List<Video_Assets> allAssets = new List<Video_Assets>();
                var roles = await _dataContext.UnitAdmin.Where(x => x.Users.Email == email).ToListAsync();
                foreach (var role in roles)
                {
                    var assets = await _dataContext.Video_Assets.Where(x => x.UnitId == role.UnitId).Include(x => x.Unit).ToListAsync();
                    allAssets.AddRange(assets);
                }
                return allAssets;
            }
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
