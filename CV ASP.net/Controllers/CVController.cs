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

        public CVController(IPersonRepository service, IProfessionRepository proservice, ISkillRepository sservice)
        {
            _pservice = service;
            _proservice = proservice;
            _sservice = sservice;
        }

        public IActionResult Index(int id)
        {
            CVViewModel model = new CVViewModel();
            model.Personal = _pservice.GetById(id).ToASP();
            model.Skills = _sservice.GetByCV(id).Select(a => a.ToASP());
            model.Professions = _proservice.GetByCV(id).Select(a => a.ToASP());

            return View(model);
        }
    }
}
