using GaziProject.Models;
using GaziProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace GaziProject.Controllers
{
    public class OgrenciController : Controller
    {
        private IOgrenciService _service;
        private IBolumService _bolumservice;
        public OgrenciController(IOgrenciService service, IBolumService  bolumService)
        {
            _service = service;
            _bolumservice = bolumService;
        }
        
        public IActionResult Index()
        {
            ViewBag.Ogrenciler = _service.GetOgrenciler();
            ViewBag.Bolumler = _bolumservice.GetBolums();            
            return View();
        }

        [HttpPost]
        public IActionResult Index(Ogrenci model)
        {
            Ogrenci bl = new();
            bl = _service.Create(model);
            if (!String.IsNullOrEmpty(bl.Adi))
            {
                //return View("Index", Ok());
                return RedirectToAction(actionName: "Index", controllerName: "Ogrenci");
            }

            return BadRequest();
        }

        [HttpPut]
        public IActionResult Update(Ogrenci model)
        {
            Ogrenci bl = new();
            bl = _service.Update(model);
            if (!String.IsNullOrEmpty(bl.Adi))
            {
                return Ok();
            }

            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Delete(int ogrenciNo)
        {
            var entity = _service.GetById(ogrenciNo);
            _service.Delete(entity);
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Detail(int ogrenciNo)
        {
            ViewBag.Bolumler = _bolumservice.GetBolums();
            return PartialView(_service.GetById(ogrenciNo));
        }

        [HttpPost]
        public IActionResult DetailUpdate(Ogrenci model)
        {
            _service.Update(model);
            return RedirectToAction("index");
        }
    }
}
