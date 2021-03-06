using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()         // index => listeleme işlemi için kullanılır. veriler listelenir.
        {
            return View();
        }

        public ActionResult About()         // hakkında sayfasını döndürür.
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()       // iletişim sayfasını döndürür.
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}