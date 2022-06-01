using GaziProject.Models;
using GaziProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace GaziProject.Controllers
{
    public class BolumController : Controller
    {
        private IBolumService _service;
        public BolumController(IBolumService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            ViewBag.bolumler = _service.GetBolums();
            return View();
        }
        [HttpPost]
        public IActionResult Index(Bolum model)
        {
            Bolum bl = new();
            bl = _service.Create(model);
            if (!String.IsNullOrEmpty(bl.BolumKodu))
            {
                //return View("Index", Ok());
                return RedirectToAction(actionName: "Index", controllerName: "Bolum");
            }

            return BadRequest();
        }

        [HttpPut]
        public IActionResult Update(Bolum model)
        {
            Bolum bl = new();
            bl = _service.Update(model);
            if (!String.IsNullOrEmpty(bl.BolumKodu))
            {
                return Ok();
            }

            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Delete(int bolumKodu)
        {
            var entity = _service.GetById(bolumKodu);
            _service.Delete(entity);
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Detail(int bolumKodu)
        {
            return PartialView(_service.GetById(bolumKodu));
        }
        [HttpPost]
        public IActionResult DetailUpdate(Bolum model)
        {
            _service.Update(model);            
            return RedirectToAction("index");            
        }
    }
}
