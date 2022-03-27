using CV_ASP.net.Models;
using Microsoft.AspNetCore.Mvc;
using ModelGlobal_DataAccessLayer.Repositories;
using CV_ASP.net.Tools;
using Microsoft.AspNetCore.Authorization;

namespace CV_ASP.net.Controllers
{
    public class CVController : Controller
    {
        private IPersonRepository _pservice;
        private IProfessionRepository _proservice;
        private ISkillRepository _sservice;

        public CVController(IPersonRepository service)
        {
            _pservice = service;
        }

        public CVController(IProfessionRepository service)
        {
            _proservice = service;
        }

        public CVController(ISkillRepository service)
        {
            _sservice = service;
        }

        public IActionResult Index(int Id)
        {
            CVViewModel model = new CVViewModel();

            model.Personal = _pservice.GetById(Id).ToASP();
            model.Skills = _sservice.GetByCV(Id).Select(a => a.ToASP());
            model.Professions = _proservice.GetByCV(Id).Select(a => a.ToASP());

            return View(model);
        }
    }
}
