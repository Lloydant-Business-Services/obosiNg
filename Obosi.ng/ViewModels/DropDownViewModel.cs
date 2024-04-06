using Obosi.ng.Application.Enums;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class DropDownViewModel
    {
        private readonly IVillage village;
        private readonly IAka aka;
        private readonly IUmunna umunna;
        private readonly IImenne imenne;
        private readonly IUnit unit;
        public DropDownViewModel()
        {
            
        }
        public DropDownViewModel(IVillage _village, IAka _aka, IUmunna _umunna, IImenne _imenne, IUnit _unit)
        {
            village = _village; 
            aka = _aka;
            imenne = _imenne;
            umunna = _umunna;
            unit = _unit;   
        }
        public async Task GetVillages()
        { 
            this.Villages = await village.GetVillages();
            this.Units = await unit.GetAllUnitsByUnit_Type((int)Unit_Types.Village);
        }
        public async Task GetAkas(int villageId)
        {   if (villageId == 0) 
            { 
                this.Akas = await aka.GetAka();
            }
            else
            {
                this.Akas = await aka.GetAkaByVillage(villageId);
            }
            this.Units = await unit.GetAllUnitsByUnit_Type((int)Unit_Types.Aka);
            this.Villages = await village.GetVillages();
        }

        public async Task GetUmunnas(int akaId)
        {
            if (akaId == 0) {
                this.Umunnas = await umunna.GetUmunna();
            }
            else
            {
                this.Umunnas = await umunna.GetUmunnaByAka(akaId);
            }
            this.Units = await unit.GetAllUnitsByUnit_Type((int)Unit_Types.Umunna);
            this.Akas = await aka.GetAka();
        }
        public async Task GetImennes(int umunnaId)
        {
            if (umunnaId == 0) { this.Imennes = await imenne.GetImenne(); }
            else
            {
                this.Imennes = await imenne.GetImenneByUmunna(umunnaId);
            }
            this.Units = await unit.GetAllUnitsByUnit_Type((int)Unit_Types.Ime_Nne);
            this.Umunnas = await umunna.GetUmunna();
        }

        public List<Village> Villages { get; set; }
        public Village Village { get; set; }
        public List<Aka> Akas { get; set; }
        public Aka Aka { get; set; }
        public List<Umunna> Umunnas { get; set; }    
        public Umunna Umunna { get; set; }  
        public List<Imenne> Imennes { get; set; }
        public Imenne Imenne { get; set; }    
        public List<Unit> Units { get; set; }
    }
}
