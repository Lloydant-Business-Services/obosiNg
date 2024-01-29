using Obosi.ng.Application.DTO;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class DashBoardViewModel
    {
        private readonly Icalender unit;
        
        public DashBoardViewModel(Icalender _unit)
        {
            unit = _unit;
        }
        public async Task GetDashBoard()
        {
            this.dash = await unit.GetDashBoardDTO();
        }
        public DashBoardDTO dash { get; set; }
    }
}
