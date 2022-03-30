using CV_ASP.net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ModelGlobal_DataAccessLayer.Repositories;

namespace CV_ASP.net.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IPersonRepository _service;
        public HomeController(IPersonRepository service, ILogger<HomeController> logger)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Instance()
        {
            return Content(_service.InstanceID.ToString());
        }

        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}