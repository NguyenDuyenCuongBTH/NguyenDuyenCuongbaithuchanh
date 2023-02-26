using Microsoft.AspNetCore.Mvc;

namespace BTH2002.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult about()
        {
            return View();
        }
    }
}