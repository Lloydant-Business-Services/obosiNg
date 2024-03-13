using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class CalenderViewModel
    {
        private readonly ICalender calender;
        private readonly IUnit unit;
        public CalenderViewModel(ICalender _calender)
        {
            calender = _calender;
        }
        public CalenderViewModel(ICalender _calender, IUnit _unit)
        {
            calender = _calender;
            unit = _unit;
        }
        public async Task InitializeNewsAsync()
        {
            this.Calender_Assets = await calender.GetAssets();
        }
        public async Task InitializeNewsAsyncUnits()
        {
            this.Calender_Assets = await calender.GetAssets();
            this.Units = await unit.GetAllUnits();
        }
        public CalenderViewModel()
        {
                
        }
        public List<Calender_Assets> Calender_Assets { get; set; }
        public Calender_Assets Calender_Asset { get; set; }
        public IFormFile Image { get; set;}
        public List<Unit> Units { get; set; }
    }
}
