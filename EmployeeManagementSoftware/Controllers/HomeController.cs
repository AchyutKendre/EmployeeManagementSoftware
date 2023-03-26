using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSoftware.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
