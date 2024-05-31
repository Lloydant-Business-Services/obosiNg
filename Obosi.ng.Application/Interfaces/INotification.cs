using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface INotification
    {
        Task<Notification> CreateNotification(Notification model);
        Task<List<Notification>> GetAllNotificationsbyUsername(string email);
    }
}
