using CV_ASP.net.Models;
using CV_ASP.net.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelGlobal_DataAccessLayer.Repositories;

namespace CV_ASP.net.Controllers
{
    public class SkillControler : Controller
    {
        private ISkillRepository _service;

        public SkillControler(ISkillRepository service)
        {
            _service = service;
        }

        [AuthRequired]
        public IActionResult Create()
        {
            SkillForm form = new SkillForm();
            return View(form);
        }

        [HttpPost]
        public IActionResult Create(SkillForm form)
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
