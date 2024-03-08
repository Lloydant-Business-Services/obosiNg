using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class ExecutuveViewModel
    {
        private readonly IExecutive executive;
        private readonly IUnit unit;
        private readonly IUser user;
        public ExecutuveViewModel(IExecutive _executive, IUnit _unit,IUser _user)
        {
            executive = _executive;
            unit = _unit;
            user = _user;
        }
        public ExecutuveViewModel()
        {
                
        }
        public async Task InitializeExecutiveAsync()
        {
            this.Executives = await executive.GetAllExecutives();
            this.Unit = await unit.GetAllUnits();
            this.Users = await user.GetAllUsers();
        }
        public async Task InitializeEditAsync(int id)
        {
            this.ExecutiveObject = await executive.GetExecutivesById(id);
            this.Unit = await unit.GetAllUnits();
            this.Users = await user.GetAllUsers();
        }
        public List<Executive> Executives { get; set; }
        public Executive ExecutiveObject { get; set; }
        public List<Unit> Unit  { get; set; }
        public List<Users> Users { get; set; } 
          
    }
}
