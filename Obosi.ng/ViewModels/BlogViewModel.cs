using Obosi.ng.Application.DTO;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class BlogViewModel
    {
        private readonly IBlog blog;
        public BlogViewModel(IBlog _blog)
        {
            blog = _blog;
        }
        public async Task InitializeNewsAsync()
        {
            this.Blogs = await blog.GetBlogs();
            this.Categories = await blog.AllCategories();
        }
        public async Task BlogList()
        {
            this.Blogs = await blog.GetBlogs(1);
            this.HomeBlogs = await blog.GetHomePageBlogs();
        }
        public BlogViewModel()
        {
            
        }

        public List<Blogs> Blogs { get; set; }
        public List<Blogs> HomeBlogs { get; set; }
        public Blogs Blog { get; set; }
        public BlogDTO BlogDto { get; set; }
        public Blogs_Update Blogs_Update { get; set; }
        public IFormFile Image { get; set;}
        public List<Category> Categories { get; set; }    

    }
}
