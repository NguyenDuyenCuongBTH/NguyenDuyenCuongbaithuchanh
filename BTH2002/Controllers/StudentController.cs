using Microsoft.AspNetCore.Mvc;

namespace BTH2002.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(String FullName)
        {
            string strReturn = " Hello " + FullName;
            ViewBag.abc = strReturn;
            return View();
        }

        
    }
}