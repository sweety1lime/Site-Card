using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZXC.Models;

namespace ZXC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Shine()
        {
            return View();
        }
        public ActionResult Reg()
        {
            return View();
        }
        [HandleError(ExceptionType = typeof(DivideByZeroException), View ="DivideError")]
        public ActionResult DivideError()
        {
            int a = 10, b = 0;
            int result = a / b;
            return Content(result.ToString());
        }

    }
}