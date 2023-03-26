using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSoftware.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
