using Obosi.ng.Application.Enums;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;
using System.Globalization;
using System.Reflection.Metadata;

namespace Obosi.ng.Presentation.ViewModels
{
    public class BoulevardViewModel
    {
        private readonly IBoulevard _boulevard;
        private readonly IUnit unit;
        public BoulevardViewModel(IBoulevard boulevard, IUnit _unit)
        {
                _boulevard = boulevard;
                unit = _unit;
        }
        public BoulevardViewModel()
        {
            
        }
        public async Task InitializeAsync()
        {
            builders_Boulevards = await _boulevard.GetBoulevard();

           
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)Unit_Types.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)Unit_Types.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)Unit_Types.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)Unit_Types.Aka);
        }
        public async Task InitializeAsync(int page)
        {
            builders_Boulevards = await _boulevard.GetBoulevard(page);

            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)Unit_Types.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)Unit_Types.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)Unit_Types.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)Unit_Types.Aka);
        }
        public List<Builders_Boulevard> builders_Boulevards { get; set; }
        public Builders_Boulevard builders_Boulevard { get; set; }
        public int pageNo { get; set; }
        public List<Unit> AllUnits { get; set; }
        public List<News> News { get; set; } = new List<News>();
        public List<Blogs> Blogs { get; set; } = new List<Blogs>();
        public List<Calender_Assets> CalenderAssets { get; set; } = new List<Calender_Assets>();
        public List<Unit> GetAllUmunnaList { get; set; } = new List<Unit>();
        public string Username { get; set; }
        public string Password { get; set; }
        public Users user { get; set; }
        public int UnitId { get; set; }
        public bool RememberPassword { get; set; }
        public Blogs blogItem { get; set; }
        public News newsItem { get; set; }
        public Unit_Type Unit_Type { get; set; }
        public Unit unitItem { get; set; }
        public List<Picture_Assets> Picture_Assets { get; set; }
        public List<Video_Assets> Video_Assets { get; set; }
        public List<Member_Unit> Member_Units { get; set; }
        public List<Executive> Executives { get; set; }
        public List<Calender_Assets> Calender_Assets { get; set; }

        public List<Unit> AllAka { get; set; }
        public List<Unit> AllUmunna { get; set; }
        public List<Unit> AllImene { get; set; }
        public List<Unit> AllVillages { get; set; }

        public int AkaId { get; set; }
        public int UmunnaId { get; set; }
        public int ImeneId { get; set; }
        public int VillageId { get; set; }


    }
}
