using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZXC.Models;

namespace ZXC.Controllers
{
    public class ServerController : Controller
    {
        // GET: Server
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Post(EEE_cLASS eee_class)
        {
            

            return View("Index",eee_class);
        }
    }
}