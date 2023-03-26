using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSoftware.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
