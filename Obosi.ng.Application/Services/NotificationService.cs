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
    public class NotificationService : INotification
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public NotificationService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Notification> CreateNotification(Notification model)
        {
            if(model != null)
            {
                model.DateCreated = DateTime.UtcNow;
                var createdNotification = await _context.Notification.AddAsync(model);
                await _context.SaveChangesAsync();
                return createdNotification.Entity;
            }
            return null;
        }

        public async Task<List<Notification>> GetAllNotificationsbyUsername(string email)
        {
            return await _context.Notification.Where(x => x.User.Email == email).Include(x=>x.User).ToListAsync();
        }
    }
}
