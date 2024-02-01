using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class CalenderViewModel
    {
        private readonly ICalender calender;
        public CalenderViewModel(ICalender _calender)
        {
           calender = _calender;
        }
        public async Task InitializeNewsAsync()
        {
            this.Calender_Assets = await calender.GetAssets();
        }
        public CalenderViewModel()
        {
                
        }
        public List<Calender_Assets> Calender_Assets { get; set; }
        public Calender_Assets Calender_Asset { get; set; }
        public IFormFile Image { get; set;}
    }
}
