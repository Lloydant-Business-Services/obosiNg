
using Obosi.ng.Application.Enums;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class HomePageViewModel
    {
        private readonly INews news;
        private readonly IBlog blog;
        private readonly ICalender calender;
        private readonly IUnit unit;
        private readonly IMedia media;
        private readonly IExecutive executive;
        
        public HomePageViewModel(INews _news, IBlog _blog, ICalender _calender)
        {
            news = _news;
            blog = _blog;  
            calender = _calender;
        }
        public HomePageViewModel(INews _news, IBlog _blog, ICalender _calender, IUnit _unit)
        {
            news = _news;
            blog = _blog;
            calender = _calender;
            unit = _unit;
        }
        public HomePageViewModel(IUnit _unit)
        {
            unit = _unit;
        }
        public HomePageViewModel(IUnit _unit, ICalender _calender, IMedia _media, IExecutive _executive)
        {
            unit = _unit;
            calender = _calender;
            media = _media;
            executive = _executive;
        }
        public HomePageViewModel()
        {
          
        }

        public async Task InitializeNewsAsync()
        {
            this.News = await news.GetHomePageNews();
            this.Blogs = await blog.GetHomePageBlogs();
            this.CalenderAssets = await calender.GetHomePageAssets();
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)UnitTypes.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)UnitTypes.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)UnitTypes.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)UnitTypes.Aka);
          
        }
        public async Task BlogInitailize(int id)
        {
            this.blogItem = await blog.GetBlogsById(id);
            this.Blogs = await blog.GetHomePageBlogs();
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)UnitTypes.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)UnitTypes.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)UnitTypes.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)UnitTypes.Aka);

        }
        public async Task BlogInitailize()
        {
            this.Blogs = await blog.GetBlogs(1);
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)UnitTypes.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)UnitTypes.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)UnitTypes.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)UnitTypes.Aka);

        }
        public async Task NewsInitializeValue(int id)
        {
            this.newsItem = await news.GetNewsById(id);
            this.News = await news.GetHomePageNews();
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)UnitTypes.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)UnitTypes.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)UnitTypes.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)UnitTypes.Aka);

        }
        public async Task NewsInitializeValue()
        {
            this.News = await news.GetNews(1);
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)UnitTypes.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)UnitTypes.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)UnitTypes.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)UnitTypes.Aka);

        }
        public async Task GetAllUmunna()
        {
            this.GetAllUmunnaList = await unit.GetAllUmunna();
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)UnitTypes.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)UnitTypes.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)UnitTypes.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)UnitTypes.Aka);
        }
        public async Task GetUnits(int id)
        {
            this.AllUnits = await unit.GetAllUnitsByUnitType(id);  
            this.Unit_Type = await unit.GetUnitType(id);
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)UnitTypes.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)UnitTypes.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)UnitTypes.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)UnitTypes.Aka);

        }
        public async Task GetUnit(int id)
        {
            this.unitItem = await unit.GetUnit(id);
            this.Picture_Assets = await media.GetPicturesByUnit(id);
            this.Video_Assets = await media.GetVideoByUnit(id);
            this.Executives = await executive.GetExecutivesByUnit(id); 
            this.CalenderAssets = await calender.GetAssetsByUnitId(id);
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)UnitTypes.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)UnitTypes.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)UnitTypes.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)UnitTypes.Aka);
            this.Member_Units = await unit.GetAllMembersByUnitId(id);
        }
        public async Task GetEvent(int id)
        {
            this.unitItem = await unit.GetUnit(id);
            this.Picture_Assets = await media.GetPicturesByUnit(id);
            this.Video_Assets = await media.GetVideoByUnit(id);
            this.Executives = await executive.GetExecutivesByUnit(id);
            this.CalenderAssets = await calender.GetAssetsByUnitId(id);
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)UnitTypes.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)UnitTypes.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)UnitTypes.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)UnitTypes.Aka);
            this.Member_Units = await unit.GetAllMembersByUnitId(id);
            this.Calender_AssetsItem = await calender.GetAssets(id);

        }
        public async Task GetEvents()
        {
           
            this.CalenderAssets = await calender.GetAssets();
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)UnitTypes.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)UnitTypes.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)UnitTypes.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)UnitTypes.Aka);
           

        }
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
        public Calender_Assets Calender_AssetsItem { get; set; }
        
        public List<Unit> AllAka { get; set; }
        public List<Unit> AllUmunna { get; set; }
        public List<Unit> AllImene { get; set; }
        public List<Unit> AllVillages { get; set; }

        public int  AkaId { get; set; }
        public int UmunnaId { get; set; }
        public int ImeneId { get; set; }
        public int VillageId { get; set; }

        public string ErrorMessage { get; set; }
    }
}
