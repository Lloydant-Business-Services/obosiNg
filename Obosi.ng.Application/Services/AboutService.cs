using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Obosi.ng.Application.DTO;
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
    public class AboutService : IAboutService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public AboutService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
      
        public async Task<About> GetAboutById(int id)
        {
            var about = await _context.About.FindAsync(id);
            return about;
        }

        public async Task<List<About>> GetAbouts()
        {
            var abouts = await _context.About
                                .Where(a => a.IsActive)
                                .OrderByDescending(a => a.CreatedDate)
                                .ToListAsync();
            return abouts;

        }
        public async Task<List<About>> CreateAbout(About about)
        {
            //Map STO to About entity
            var _about = _mapper.Map<About>(about);

            about.CreatedDate = DateTime.UtcNow;
            about.ModifiedDate = DateTime.UtcNow; 

             await _context.About.AddAsync(about);

             await _context.SaveChangesAsync();

            //he list containing the newly created About entity
            return new List<About> { about };
        }

        public async Task<List<About>> UpdateAbout(About about)
        {
            // Find About entity by its unique properties
            var existingAbout = await _context.About
                .FirstOrDefaultAsync(a => a.Id == about.Id);

            if (existingAbout == null)
            {
                throw new Exception($"About entity with Body '{about.Body}' and IsActive '{about.IsActive}' not found.");
            }

  

            existingAbout.ModifiedDate = DateTime.UtcNow;
            existingAbout.Body = about.Body;

             _context.About.Update(existingAbout);

            await _context.SaveChangesAsync();

            return new List<About> { existingAbout };

        }

        public async Task<List<About>> DeleteAbout(int id)
        {
            var existingAbout = await _context.About.FindAsync(id);

            if (existingAbout == null)
            {
                throw new Exception("Content not Found");
            }
            
            existingAbout.IsActive = false;

            existingAbout.ModifiedDate = DateTime.UtcNow;

            _context.About.Update(existingAbout);
            await _context.SaveChangesAsync();

            return new List<About> { existingAbout };

        }
    }
}
