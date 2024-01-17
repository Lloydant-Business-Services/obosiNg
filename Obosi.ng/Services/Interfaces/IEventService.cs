using Obosi.ng.Models.EntityModel;

namespace Obosi.ng.Services.Interfaces
{
    public interface IEventService
    {
        Task<Event> CreateEvent(Event eventObject);
        Task<Event> UpdateEvent(Event eventObject);
        Task<bool> DeleteEvent(Event eventObject);
        Task<Event> GetEventById(int id);
        Task<List<Event>> GetAllEvents();
        Task<List<Event>> GetEventsByDate(DateTime date);
        Task<List<Event>> GetEventsUnit(int unitId);
    }
}
