using Obosi.ng.Application.DTO;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class AboutViewModel
    {
        private readonly IAboutService aboutService;
        public AboutViewModel()
        {

        }

        // Constructor
        public AboutViewModel(IAboutService _aboutService)
        {
            aboutService = _aboutService;
        }

        // Method to initialize about sections asynchronously
        public async Task InitializeAboutSectionsAsync()
        {
            // Assuming there's a method in IAboutService interface to retrieve about sections
            this.Abouts = await aboutService.GetAbouts();
        }

        // Method to update about section
        public async Task UpdateAboutSectionAsync(About aboutDto)
        {
            // Assuming there's a method in IAboutService interface to update about section
            await aboutService.UpdateAbout(aboutDto);
        }

       
        public About About { get; set; }
        public IEnumerable<About> Abouts { get; set; }
      //  public AboutDTO AboutDTO { get; set; }
    }
}
