using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class PermissionViewModel
    {
        private readonly IUser user;
        private readonly IUnit unit;
        public PermissionViewModel(IUser _user, IUnit _unit)
        {
            user = _user;
            unit = _unit;
        }
		

		public PermissionViewModel()
        {
                
        }
        public async Task InitializeAsync()
        {
            this.Users = await user.GetUnitAdmins();
            this.AllUnits = await unit.GetAllUnits();
        }
        public async  Task InitializeUnitAdmins()
        {
            Unit = await unit.GetAdmins();
        }

        public List<Users> Users { get; set; }
        public Users User { get; set; }
        public List<UnitAdmin> Unit { get; set; }    
        public UnitAdmin UnitObject {  get; set; }
        public List<Unit> AllUnits { get; set; }    
    }
}
