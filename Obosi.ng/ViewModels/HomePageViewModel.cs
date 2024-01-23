
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class HomePageViewModel
    {
        private readonly INews news;
        private readonly IBlog blog;
        private readonly ICalender calender;
        public HomePageViewModel(INews _news, IBlog _blog, ICalender _calender)
        {
            news = _news;
            blog = _blog;  
            calender = _calender;
        }
        public async Task InitializeNewsAsync()
        {
            this.News = await news.GetHomePageNews();
            this.Blogs = await blog.GetHomePageBlogs();
            this.CalenderAssets = await calender.GetHomePageAssets();
        }
        public List<Unit> AllUnits { get; set; }
        public List<News> News { get; set; } = new List<News>();
        public List<Blogs> Blogs { get; set; } = new List<Blogs>();
        public List<Calender_Assets> CalenderAssets { get; set; } = new List<Calender_Assets>();
    }
}
