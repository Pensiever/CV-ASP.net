using CV_ASP.net.Models;
using CV_ASP.net.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelGlobal_DataAccessLayer.Repositories;

namespace CV_ASP.net.Controllers
{
    public class PersonController : Controller
    {
        private IPersonRepository _service;

        public PersonController(IPersonRepository service)
        {
            _service = service;
        }
        
        public IActionResult Instance()
        {
            return Content(_service.InstanceID.ToString());
        }

        public ActionResult Index()
        {
            return View();
        }

        [AuthRequired]
        public IActionResult Create()
        {
            PersonForm form = new PersonForm();
            return View(form);
        }

        [HttpPost]
        public IActionResult Create(PersonForm form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            try
            {
                _service.Create(form.FormToDAL());
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(form);
            }

        }

        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(_service.GetById(id).ToFormView());
        }

        [HttpPost]
        public IActionResult Edit(PersonForm f)
        {
            if (!ModelState.IsValid) return View(f);

            _service.Update(f.FormToDAL());

            return RedirectToAction("Index");
        }
    }
}
