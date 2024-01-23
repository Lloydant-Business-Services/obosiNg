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
        public async Task<List<Picture_Assets>> GetPicturesByUnit(int unitId)
        {
           return await _dataContext.Picture_Assets.Where(x=>x.UnitId == unitId).ToListAsync();
        }

        public async Task<List<Video_Assets>> GetVideoByUnit(int unitId)
        {
            return await _dataContext.Video_Assets.Where(x => x.UnitId == unitId).ToListAsync();
        }
    }
}
