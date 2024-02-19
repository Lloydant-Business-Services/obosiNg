﻿using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class MediaViewModel
    {

        private readonly IMedia media;
        private readonly IUnit unit;
        public MediaViewModel(IMedia _media)
        {
           media = _media;  
        }
        public MediaViewModel(IMedia _media, IUnit _unit)
        {
           media = _media;
            unit = _unit;
        }
        public async Task InitializVideoAsync()
        {
            this.Video_Assets = await media.GetVideoByUnit();
            this.Units = await unit.GetAllUnits();
        }
        public async Task InitializePicturesAsync()
        {
          this.Picture_Assets = await media.GetPicturesByUnit();
            this.Units = await unit.GetAllUnits();
        }
        public MediaViewModel()
        {

        }
        public List<Picture_Assets> Picture_Assets { get; set; }
        public Picture_Assets Picture_Asset { get; set; }
        public List <Video_Assets> Video_Assets { get; set; }
        public Video_Assets Video_Asset { get; set; }
        public IFormFile Image { get; set; }
        public List<Unit> Units { get; set; }
    }
}
