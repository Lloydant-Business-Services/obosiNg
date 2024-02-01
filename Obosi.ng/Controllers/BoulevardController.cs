using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Presentation.ViewModels;

namespace Obosi.ng.Presentation.Controllers
{
    public class BoulevardController : Controller
    {
        private readonly IBoulevard _boulevard;
        public BoulevardController(IBoulevard boulevard)
        {
            _boulevard = boulevard;
        }
        public async Task<IActionResult> Index()
        {
            BoulevardViewModel model = new(_boulevard);
            await model.InitializeAsync();
            return View(model);
        }
    }
}
