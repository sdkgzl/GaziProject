using GaziProject.Models;
using GaziProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace GaziProject.Controllers
{
    public class BolumController : Controller
    {
        private IBolumManager _service;
        public BolumController(IBolumManager service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            ViewBag.bolumler = _service.GetBolums();
            return View();
        }
        [HttpPost]
        public IActionResult Index(Department model)
        {
            Department bl = new();
            bl = _service.Create(model);
            if (!String.IsNullOrEmpty(bl.DepartmentCode))
            {
                //return View("Index", Ok());
                return RedirectToAction(actionName: "Index", controllerName: "Bolum");
            }

            return BadRequest();
        }

        [HttpPut]
        public IActionResult Update(Department model)
        {
            Department bl = new();
            bl = _service.Update(model);
            if (!String.IsNullOrEmpty(bl.DepartmentCode))
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
        public IActionResult DetailUpdate(Department model)
        {
            _service.Update(model);            
            return RedirectToAction("index");            
        }
    }
}
