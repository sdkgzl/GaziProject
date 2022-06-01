using GaziProject.Models;
using GaziProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace GaziProject.Controllers
{
    public class OgrenciDersController : Controller
    {
        private IOgrenciDersManager _ogrenciDerservice;
        private IOgrenciManager _ogrenciService;
        private IDersManager _dersService;
        public OgrenciDersController(IOgrenciDersManager ogrenciDerService, IOgrenciManager ogrenciService, IDersManager dersService)
        {
            _ogrenciDerservice = ogrenciDerService;
            _ogrenciService = ogrenciService;
            _dersService = dersService;
        }
        public IActionResult Index()
        {
            List<Student> ogrenciler = new();
            ogrenciler = _ogrenciService.GetOgrenciler();
            foreach (var item in ogrenciler)
            {
                item.StudentName = item.StudentName + item.StudentLastname;
            }

            ViewBag.Ogrenciler = ogrenciler;
            ViewBag.Dersler = _dersService.GetDersler();
            ViewBag.OgrenciDersler= _ogrenciDerservice.GetOgrenciDersler();
            return View();
        }

        [HttpPost]
        public IActionResult Index(StudentLecture model)
        {
            StudentLecture bl = new();
            bl = _ogrenciDerservice.Create(model);
            return RedirectToAction(actionName: "Index", controllerName: "OgrenciDers");            
        }

        [HttpPut]
        public IActionResult Update(StudentLecture model)
        {
            StudentLecture bl = new();
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
            List<Student> ogrenciler = new();
            StudentLecture ogrenciDers =new();
            ogrenciler = _ogrenciService.GetOgrenciler();
            foreach (var item in ogrenciler)
            {
                item.StudentName = item.StudentName + item.StudentLastname;
            }

            ViewBag.Ogrenciler = ogrenciler;
            ViewBag.Dersler = _dersService.GetDersler();
            ViewBag.OgrenciDersler = _ogrenciDerservice.GetOgrenciDersler();
            ogrenciDers = _ogrenciDerservice.GetById(id);
            return PartialView(ogrenciDers);
        }

        [HttpPost]
        public IActionResult DetailUpdate(StudentLecture model)
        {
            _ogrenciDerservice.Update(model);
            return RedirectToAction("index");
        }
    }
}
