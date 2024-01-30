using Obosi.ng.Application.DTO;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class DashBoardViewModel
    {
        private readonly IUnit unit;
        
        public DashBoardViewModel(IUnit _unit)
        {
            unit = _unit;
        }
        public DashBoardViewModel()
        {

        }
        public async Task GetDashBoard()
        {
            this.dash = await unit.GetDashBoardDTO();
        }
        public DashBoardDTO dash { get; set; }
    }
}
