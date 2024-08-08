using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class UnitViewModel
    {
        private readonly IUnit unit;
        public UnitViewModel(IUnit _unit)
        {
            unit = _unit;
        }
        public UnitViewModel()
        {
                
        }
        public async Task InitializeNewsAsync(string email)
        {
            this.Unit_TypeList = await unit.GetAllUnitTypes(email);
        }
        public async Task GetUnit_TypeList(int Unit_TypeId, string email)
        {
            this.Units = await unit.GetAllUnitsByUnitType(Unit_TypeId, email);
            this.Unit_TypeId = Unit_TypeId;
            this.Unit_Type = await unit.GetUnitType(Unit_TypeId);    
        }

        public List<Unit_Type> Unit_TypeList { get; set; }
        public List<Unit> Units { get; set; }
        public Unit Unit { get; set; }
        public Unit_Type Unit_Type { get; set; }
        public IFormFile Image { get; set; }
        public int Unit_TypeId { get; set; }
    }
}
