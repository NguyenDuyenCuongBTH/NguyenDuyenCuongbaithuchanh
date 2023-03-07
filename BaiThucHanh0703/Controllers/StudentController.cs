using System.Net;
using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;

namespace BaiThucHanh0703.Controllers
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
        public IActionResult TinhTong()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TinhTong(string Number)
        {
            int so = Convert.ToInt32(Number);
            int tong = 0;
            while(so > 0)
            {
                tong = tong = so%10;
                so = so/10;
            }
            ViewBag.tong = "tong cua cac chu so" + Number + "=" + tong;
            return View();
        }
        public IActionResult GiaiPhuongTrinhBac2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GiaiPhuongTrinhBac2(string hesoA, string hesoB, string hesoC)
        {
        double delta, x1, x2, a=0, b=0, c=0;
        string ketqua;
        if(!String.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
        if(!String.IsNullOrEmpty(hesoB)) b = Convert.ToDouble(hesoB);
        if(!String.IsNullOrEmpty(hesoC)) c = Convert.ToDouble(hesoC);
        if(a==0) ketqua = "khong phai pt bac 2";
        else
        {
            delta = Math.Pow(b,2) - 4*a*c;
            if(delta<0) ketqua = "pt vo nghiem";
            else if(delta==0)
            {
                x1 = -b/(2*a);
                ketqua = "pt co nghiem kep = " + x1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta))/(2*a);
                x2 = (-b - Math.Sqrt(delta))/(2*a);
                ketqua = "pt cos 2 nghiem: x1 =" + x1 + ", x2 = " + x2;
            }
        }
        ViewBag.message = ketqua;
        return View();
        }
        
    }
}