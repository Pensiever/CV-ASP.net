using CV_ASP.net.Models;
using CV_ASP.net.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelGlobal_DataAccessLayer.Repositories;

namespace CV_ASP.net.Controllers
{
    public class ProfessionController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IProfessionRepository _service;
        private IPersonRepository _perservice;

        public ProfessionController(IProfessionRepository service, IPersonRepository perservice)
        {
            _service = service;
            _perservice = perservice;
        }

        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        public IActionResult Create()
        {
            ProfessionForm form = new ProfessionForm();
            form.CVList = _perservice.GetAll().Select(a => a.ToASP());
            return View(form);
        }

        [HttpPost]
        public IActionResult Create(ProfessionForm form)
        {
            form.CVList = _perservice.GetAll().Select(a => a.ToASP());
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
    }
}
