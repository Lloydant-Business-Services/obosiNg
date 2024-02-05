
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
        public HomePageViewModel(INews _news, IBlog _blog, ICalender _calender)
        {
            news = _news;
            blog = _blog;  
            calender = _calender;
        }
        public HomePageViewModel(IUnit _unit)
        {
            unit = _unit;
        }
        public HomePageViewModel()
        {
          
        }

        public async Task InitializeNewsAsync()
        {
            this.News = await news.GetHomePageNews();
            this.Blogs = await blog.GetHomePageBlogs();
            this.CalenderAssets = await calender.GetHomePageAssets();
        }
        public async Task BlogInitailize(int id)
        {
            this.blogItem = await blog.GetBlogsById(id);
            this.Blogs = await blog.GetHomePageBlogs();
        }
        public async Task NewsInitializeValue(int id)
        {
            this.newsItem = await news.GetNewsById(id);
            this.News = await news.GetHomePageNews();
        }
        public async Task GetAllUmunna()
        {
            this.GetAllUmunnaList = await unit.GetAllUmunna();
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

    }
}
