using GaziProject.Models;
using GaziProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace GaziProject.Controllers
{
    public class DersController : Controller
    {
        private IDersManager _service;
        public DersController(IDersManager service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            ViewBag.Dersler = _service.GetDersler();
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(Lecture model)
        {
            Lecture bl = new();
            bl = _service.Create(model);
            if (!String.IsNullOrEmpty(bl.LectureCode))
            {
                //return View("Index", Ok());
                return RedirectToAction(actionName: "Index", controllerName: "Ders");
            }

            return BadRequest();
        }

        [HttpPut]
        public IActionResult Update(Lecture model)
        {
            Lecture bl = new();
            bl = _service.Update(model);
            if (!String.IsNullOrEmpty(bl.LectureCode))
            {
                return Ok();
            }

            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var entity = _service.GetById(id);
            _service.Delete(entity);
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Detail(int Id)
        {
            return PartialView(_service.GetById(Id));
        }
        [HttpPost]
        public IActionResult DetailUpdate(Lecture model)
        {
            _service.Update(model);
            return RedirectToAction("index");
        }
    }
}
