using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class UnitPageViewModel
    {
        public UnitPageViewModel()
        {
                
        }
        public Unit Unit {  get; set; } 
        public List<Executive> Executive { get; set; }
        public List<Member_Unit> Member { get; set; }   
        public List<Picture_Assets> PictureAssets { get; set; }
        public List<Video_Assets> VideoAssets { get; set; }
        public List<Calender_Assets> CalenderAssets { get; set; }
    }
}
