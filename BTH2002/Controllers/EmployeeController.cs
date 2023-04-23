using BTH2002.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTH2002.Controllers
{
    public class EmployeeController : Controller
    {
      public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee std)
        {
            string ketqua = std.Ma + "-" + std.FullName + "-" + std.Address;
            ViewBag.message = ketqua;
            return View();
        }  
    }
}