using LeaveManagementSystemWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystemWeb.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel();
            data.Name = "Student of MVC Mastery";
            data.DateOfBirth = DateTime.Now;
            return View(data);
        }
    }
}
