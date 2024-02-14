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
        public async Task InitializeNewsAsync()
        {
            this.UnitTypeList = await unit.GetAllUnitTypes();
        }
        public async Task GetUnitTypeList(int unitTypeId)
        {
            this.Units = await unit.GetAllUnitsByUnitType(unitTypeId);
            this.UnitTypeId = UnitTypeId;
            this.Unit_Type = await unit.GetUnitType(unitTypeId);    
        }

        public List<Unit_Type> UnitTypeList { get; set; }
        public List<Unit> Units { get; set; }
        public Unit Unit { get; set; }
        public Unit_Type Unit_Type { get; set; }
        public IFormFile Image { get; set; }
        public int UnitTypeId { get; set; }
    }
}
