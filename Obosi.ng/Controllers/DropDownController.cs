using Microsoft.AspNetCore.Mvc;
using Obosi.ng.Application.Interfaces;
using Obosi.ng.Domain.Entity;
using Obosi.ng.Presentation.ViewModels;
using IImenne = Obosi.ng.Application.Interfaces.IImenne;

namespace Obosi.ng.Presentation.Controllers
{
    public class DropDownController : Controller
    {
        private readonly IVillage village;
        private readonly IAka aka;
        private readonly IUmunna umunna;
        private readonly IImenne imenne;
        private readonly IUnit unit;
        public DropDownController(IVillage _village, IAka _aka, IUmunna _umunna, IImenne _imenne, IUnit _unit)
        {
            village = _village;
            aka = _aka;
            imenne = _imenne;
            umunna = _umunna;
            unit = _unit;
        }
        public async Task<IActionResult> Index()
        {
            DropDownViewModel model = new(village, aka, umunna, imenne, unit);
            await model.GetVillages();
            return View(model);
        }
        public async Task<IActionResult> CreateVillage()
        {
            DropDownViewModel model = new(village, aka, umunna, imenne, unit);
            await model.GetVillages();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateVillage(DropDownViewModel model)
        {
            await village.CreateVillage(model.Village);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> ViewAKa(int villageId)
        {
            DropDownViewModel model = new(village, aka, umunna, imenne, unit);
            await model.GetAkas(villageId);
            model.VillageId = villageId;
            return View(model);
        }
        public async Task<IActionResult> CreateAka(int villageId)
        {
            DropDownViewModel model = new(village, aka, umunna, imenne, unit);
            await model.GetAkas(0);
            model.Village = await village.GetVillageById(villageId);
            model.Aka = new Aka();
            model.Aka.VillageId = villageId;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAka(DropDownViewModel model)
        {
            await aka.CreateAka(model.Aka);
            return RedirectToAction("ViewAka", new { villageId = model.Aka.VillageId });
        }
        public async Task<IActionResult> RemoveAka(int akaId, int villageId)
        {
            await aka.DeleteAka(akaId);
            return RedirectToAction("ViewAka", new { villageId = villageId });
        }
        public async Task<IActionResult> ViewUmunna(int akaId)
        {
            DropDownViewModel model = new(village, aka, umunna, imenne, unit);
            await model.GetUmunnas(akaId);
            model.AkaId = akaId;
            return View(model);
        }
        public async Task<IActionResult> CreateUmunna(int akaId)
        {
            DropDownViewModel model = new(village, aka, umunna, imenne, unit);
            await model.GetUmunnas(0);
            model.Aka = await aka.GetAkaById(akaId);
            model.Umunna = new Umunna();
            model.Umunna.AkaId = akaId;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUmunna(DropDownViewModel model)
        {
            await umunna.CreateUmunna(model.Umunna);
            return RedirectToAction("ViewUmunna", new { akaId = model.Umunna.AkaId });
        }
        public async Task<IActionResult> RemoveUmunna(int umunnaId, int akaId)
        {
            await umunna.DeleteUmunna(umunnaId);
            return RedirectToAction("ViewUmunna", new { akaId = akaId });
        }
        public async Task<IActionResult> ViewImenne(int umunnaId)
        {
            DropDownViewModel model = new(village, aka, umunna, imenne, unit);
            await model.GetImennes(umunnaId);
            model.UmmunnaId = umunnaId;
            return View(model);
        }
        public async Task<IActionResult> CreateImene(int umunnaId)
        {

            DropDownViewModel model = new(village, aka, umunna, imenne, unit);
            model.Imenne = new Imenne();
            model.Umunna = await umunna.GetUmunnaById(umunnaId);
            model.Imenne.UmunnaId = umunnaId;
            await model.GetImennes(0);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateImene(DropDownViewModel model)
        {
            await imenne.CreateImenne(model.Imenne);
            return RedirectToAction("ViewImenne", new { umunnaId = model.Imenne.UmunnaId });
        }
        public async Task<IActionResult> RemoveImene(int imeneId, int umunnaId)
        {
            await imenne.DeleteImenne(imeneId);
            return RedirectToAction("ViewImenne", new { umunnaId = umunnaId });
        }

    }
}
