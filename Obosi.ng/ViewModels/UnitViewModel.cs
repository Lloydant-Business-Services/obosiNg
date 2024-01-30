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
        public async Task InitializeNewsAsync()
        {
            this.UnitTypeList = await unit.GetAllUnitTypes();
        }
        public async Task GetUnitTypeList(int unitTypeId)
        {
            this.Units = await unit.GetAllUnitsByUnitType(unitTypeId);
        }

        public List<Unit_Type> UnitTypeList { get; set; }
        public List<Unit> Units { get; set; }
        public Unit Unit { get; set; }
    }
}
