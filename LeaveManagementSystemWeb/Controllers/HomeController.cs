using LeaveManagementSystemWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeaveManagementSystemWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ErrorViewModel model = new ErrorViewModel();
            if(Activity.Current?.Id != null)
            {
                model.RequestId = Activity.Current?.Id;
            }
            else
            {
                model.RequestId =  HttpContext.TraceIdentifier;
            }
            
            return View(model);
        }
    }
}
