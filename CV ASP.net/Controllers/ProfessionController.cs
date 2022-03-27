using CV_ASP.net.Models;
using CV_ASP.net.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelGlobal_DataAccessLayer.Repositories;
using System.Web.Mvc;

namespace CV_ASP.net.Controllers
{
    public class ProfessionController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IProfessionRepository _service;

        public ProfessionController(IProfessionRepository service)
        {
            _service = service;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.JsonResult GetProfessionById(int Id)
        {
            return Json(Mappers.ToASPList((IEnumerable<Profession>)_service.GetByCV(Id)), JsonRequestBehavior.AllowGet);
        }

        [AuthRequired]
        public IActionResult Create()
        {
            ProfessionForm form = new ProfessionForm();
            return View(form);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult Create(ProfessionForm form)
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
    }
}
