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
        }

        public List<Blogs> Blogs { get; set; }
    }
}
