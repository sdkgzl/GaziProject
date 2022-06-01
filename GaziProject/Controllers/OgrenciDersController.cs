using GaziProject.Models;
using GaziProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace GaziProject.Controllers
{
    public class OgrenciDersController : Controller
    {
        private IOgrenciDersService _ogrenciDerservice;
        private IOgrenciService _ogrenciService;
        private IDersService _dersService;
        public OgrenciDersController(IOgrenciDersService ogrenciDerService, IOgrenciService ogrenciService, IDersService dersService)
        {
            _ogrenciDerservice = ogrenciDerService;
            _ogrenciService = ogrenciService;
            _dersService = dersService;
        }
        public IActionResult Index()
        {
            List<Ogrenci> ogrenciler = new();
            ogrenciler = _ogrenciService.GetOgrenciler();
            foreach (var item in ogrenciler)
            {
                item.Adi = item.Adi + item.Soyadi;
            }

            ViewBag.Ogrenciler = ogrenciler;
            ViewBag.Dersler = _dersService.GetDersler();
            ViewBag.OgrenciDersler= _ogrenciDerservice.GetOgrenciDersler();
            return View();
        }

        [HttpPost]
        public IActionResult Index(OgrenciDers model)
        {
            OgrenciDers bl = new();
            bl = _ogrenciDerservice.Create(model);
            return RedirectToAction(actionName: "Index", controllerName: "OgrenciDers");            
        }

        [HttpPut]
        public IActionResult Update(OgrenciDers model)
        {
            OgrenciDers bl = new();
            bl = _ogrenciDerservice.Update(model);
            
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var entity = _ogrenciDerservice.GetById(id);
            _ogrenciDerservice.Delete(entity);
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Detail(int id)
        {
            List<Ogrenci> ogrenciler = new();
            OgrenciDers ogrenciDers =new();
            ogrenciler = _ogrenciService.GetOgrenciler();
            foreach (var item in ogrenciler)
            {
                item.Adi = item.Adi + item.Soyadi;
            }

            ViewBag.Ogrenciler = ogrenciler;
            ViewBag.Dersler = _dersService.GetDersler();
            ViewBag.OgrenciDersler = _ogrenciDerservice.GetOgrenciDersler();
            ogrenciDers = _ogrenciDerservice.GetById(id);
            return PartialView(ogrenciDers);
        }

        [HttpPost]
        public IActionResult DetailUpdate(OgrenciDers model)
        {
            _ogrenciDerservice.Update(model);
            return RedirectToAction("index");
        }
    }
}
