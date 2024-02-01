using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Presentation.ViewModels
{
    public class BoulevardViewModel
    {
        private readonly IBoulevard _boulevard; 
        public BoulevardViewModel(IBoulevard boulevard)
        {
                _boulevard = boulevard;
        }
        public async Task InitializeAsync()
        {
            builders_Boulevards = await _boulevard.GetBoulevard(1);
        }   
        public List<Builders_Boulevard> builders_Boulevards { get; set; }
        public Builders_Boulevard builders_Boulevard { get; set; }
    }
}
