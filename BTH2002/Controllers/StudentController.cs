using BTH2002.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTH2002.Controllers
{
    public class StudentController : Controller
    {
      public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            string ketqua = std.StudentCode + "-" + std.FullName + "-" + std.Address;
            ViewBag.message = ketqua;
            return View();
        }  
    }
}