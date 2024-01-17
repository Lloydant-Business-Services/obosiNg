using Obosi.ng.Models.EntityModel;
using Obosi.ng.Services.Interfaces;

namespace Obosi.ng.Services.Implementation
{
    public class EventService : IEventService
    {
        public Task<Event> CreateEvent(Event eventObject)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEvent(Event eventObject)
        {
            throw new NotImplementedException();
        }

        public Task<List<Event>> GetAllEvents()
        {
            throw new NotImplementedException();
        }

        public Task<Event> GetEventById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Event>> GetEventsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<List<Event>> GetEventsUnit(int unitId)
        {
            throw new NotImplementedException();
        }

        public Task<Event> UpdateEvent(Event eventObject)
        {
            throw new NotImplementedException();
        }
    }
}
