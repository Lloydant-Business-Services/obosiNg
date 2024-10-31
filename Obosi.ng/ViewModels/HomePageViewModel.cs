
using Newtonsoft.Json;
using Obosi.ng.Application.Enums;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Application.Services;
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
        private readonly IAboutService about;
        private readonly IBoulevard boulevard;
        
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
        public HomePageViewModel(INews _news, IAboutService _about, IBlog _blog, ICalender _calender, IUnit _unit)
        {
            news = _news;
            blog = _blog;
            calender = _calender;
            unit = _unit;
            about = _about;
        }
        public HomePageViewModel(IUnit _unit)
        {
            unit = _unit;
        }
        public HomePageViewModel(IAboutService _about)
        {
            about = _about;
        }
        public HomePageViewModel(IUnit _unit, ICalender _calender, IMedia _media, IExecutive _executive)
        {
            unit = _unit;
            calender = _calender;
            media = _media;
            executive = _executive; 
        }
		public HomePageViewModel(IUnit _unit, ICalender _calender, IMedia _media, IExecutive _executive,IBoulevard _boulevard)
		{
			unit = _unit;
			calender = _calender;
			media = _media;
			executive = _executive;
            boulevard = _boulevard;
		}
		public HomePageViewModel()
        {
          
        }

        public async Task InitializeNewsAsync()
        {
            this.News = await news.GetHomePageNews();
            this.Blogs = await blog.GetHomePageBlogs();
            this.CalenderAssets = await calender.GetHomePageAssets();
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)Unit_Types.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)Unit_Types.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)Unit_Types.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)Unit_Types.Aka);
          
        }
        public async Task BlogInitailize(int id)
        {
            this.blogItem = await blog.GetBlogsById(id);
            this.Blogs = await blog.GetHomePageBlogs();
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)Unit_Types.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)Unit_Types.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)Unit_Types.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)Unit_Types.Aka);

        }
        public async Task BlogInitailize()
        {
            this.Blogs = await blog.GetBlogs(1);
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)Unit_Types.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)Unit_Types.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)Unit_Types.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)Unit_Types.Aka);

        }
        public async Task NewsInitializeValue(int id)
        {
            this.newsItem = await news.GetNewsById(id);
            this.News = await news.GetHomePageNews();
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)Unit_Types.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)Unit_Types.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)Unit_Types.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)Unit_Types.Aka);

        }
        public async Task NewsInitializeValue()
        {
            this.News = await news.GetNews(1);
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)Unit_Types.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)Unit_Types.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)Unit_Types.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)Unit_Types.Aka);

        }
        public async Task GetAllUmunna()
        {
            this.GetAllUmunnaList = await unit.GetAllUmunna();
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)Unit_Types.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)Unit_Types.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)Unit_Types.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)Unit_Types.Aka);
        }
        public async Task GetUnits(int id)
        {
            this.AllUnits = await unit.GetAllUnitsByUnitType(id);  
            this.Unit_Type = await unit.GetUnitType(id);
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)Unit_Types.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)Unit_Types.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)Unit_Types.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)Unit_Types.Aka);

        }
        public async Task GetUnit(int id)
        {
            this.unitItem = await unit.GetUnit(id);
            this.Picture_Assets = await media.GetPicturesByUnit(id);
            this.Video_Assets = await media.GetVideoByUnit(id);
            this.Executives = await executive.GetExecutivesByUnit(id); 
            this.CalenderAssets = await calender.GetAssetsByUnitId(id);
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)Unit_Types.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)Unit_Types.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)Unit_Types.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)Unit_Types.Aka);
            this.Member_Units = await unit.GetAllMembersByUnitId(id);
        }
        public async Task GetEvent(int id)
        {
            this.unitItem = await unit.GetUnit(id);
            this.Picture_Assets = await media.GetPicturesByUnit(id);
            this.Video_Assets = await media.GetVideoByUnit(id);
            this.Executives = await executive.GetExecutivesByUnit(id);
            this.CalenderAssets = await calender.GetAssetsByUnitId(id);
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)Unit_Types.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)Unit_Types.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)Unit_Types.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)Unit_Types.Aka);
            this.Member_Units = await unit.GetAllMembersByUnitId(id);
            this.Calender_AssetsItem = await calender.GetAssets(id);

        }
        public async Task GetEvents()
        {
           
            this.CalenderAssets = await calender.GetAllAssets();
            this.AllUmunna = await unit.GetAllUnitsByUnitType((int)Unit_Types.Umunna);
            this.AllVillages = await unit.GetAllUnitsByUnitType((int)Unit_Types.Village);
            this.AllImene = await unit.GetAllUnitsByUnitType((int)Unit_Types.Ime_Nne);
            this.AllAka = await unit.GetAllUnitsByUnitType((int)Unit_Types.Aka);
           

        }
		public async Task InitializeAsync(int page)
		{
			builders_Boulevards = await boulevard.GetBoulevard(page);

			this.AllUmunna = await unit.GetAllUnitsByUnitType((int)Unit_Types.Umunna);
			this.AllVillages = await unit.GetAllUnitsByUnitType((int)Unit_Types.Village);
			this.AllImene = await unit.GetAllUnitsByUnitType((int)Unit_Types.Ime_Nne);
			this.AllAka = await unit.GetAllUnitsByUnitType((int)Unit_Types.Aka);
		}
		public async Task GetAbout(int pageId)
        {
            this.AboutContent = await about.GetAbouts(pageId);
            this.HasNextPage = await about.HasNextPage(pageId);
        }
        public List<Obosi.ng.Domain.Entity.About> AboutContent { get; set; }
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
        public int PageId { get; set; }
        public bool HasNextPage { get; set; }

		public List<Builders_Boulevard> builders_Boulevards { get; set; }
		public Builders_Boulevard builders_Boulevard { get; set; }
        public List<Root> root { get; set; }
        public List<BlogTitles> BlogTitlesList { get; set; }
        public int pageNo { get; set; }
        public class About
        {
            public string href { get; set; }
        }

        public class Author
        {
            public bool embeddable { get; set; }
            public string href { get; set; }
        }

        public class Collection
        {
            public string href { get; set; }
        }

        public class Content
        {
            public string rendered { get; set; }
            public bool @protected { get; set; }
        }

        public class Cury
        {
            public string name { get; set; }
            public string href { get; set; }
            public bool templated { get; set; }
        }

        public class Excerpt
        {
            public string rendered { get; set; }
            public bool @protected { get; set; }
        }

        public class Guid
        {
            public string rendered { get; set; }
        }

        public class Links
        {
            public List<Self> self { get; set; }
            public List<Collection> collection { get; set; }
            public List<About> about { get; set; }
            public List<Author> author { get; set; }
            public List<Reply> replies { get; set; }

            [JsonProperty("version-history")]
            public List<VersionHistory> versionhistory { get; set; }

            [JsonProperty("predecessor-version")]
            public List<PredecessorVersion> predecessorversion { get; set; }

            [JsonProperty("wp:attachment")]
            public List<WpAttachment> wpattachment { get; set; }

            [JsonProperty("wp:term")]
            public List<WpTerm> wpterm { get; set; }
            public List<Cury> curies { get; set; }
        }

        public class Meta
        {
            public string footnotes { get; set; }
        }

        public class PredecessorVersion
        {
            public int id { get; set; }
            public string href { get; set; }
        }

        public class Reply
        {
            public bool embeddable { get; set; }
            public string href { get; set; }
        }

        public class Root
        {
            public int id { get; set; }
            public DateTime date { get; set; }
            public DateTime date_gmt { get; set; }
            public Guid guid { get; set; }
            public DateTime modified { get; set; }
            public DateTime modified_gmt { get; set; }
            public string slug { get; set; }
            public string status { get; set; }
            public string type { get; set; }
            public string link { get; set; }
            public Title title { get; set; }
            public Content content { get; set; }
            public Excerpt excerpt { get; set; }
            public int author { get; set; }
            public int featured_media { get; set; }
            public string comment_status { get; set; }
            public string ping_status { get; set; }
            public bool sticky { get; set; }
            public string template { get; set; }
            public string format { get; set; }
            public Meta meta { get; set; }
            public List<int> categories { get; set; }
            public List<object> tags { get; set; }
            public List<string> class_list { get; set; }
            public List<object> blocksy_meta { get; set; }
            public Links _links { get; set; }
        }

        public class Self
        {
            public string href { get; set; }
        }

        public class Title
        {
            public string rendered { get; set; }
        }

        public class VersionHistory
        {
            public int count { get; set; }
            public string href { get; set; }
        }

        public class WpAttachment
        {
            public string href { get; set; }
        }

        public class WpTerm
        {
            public string taxonomy { get; set; }
            public bool embeddable { get; set; }
            public string href { get; set; }
        }

        public class BlogTitles
        {
            public string title { get; set; }
            public string content { get; set; }
            public string link { get; set; }
        }
    }

}
