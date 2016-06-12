using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
          //  ViewBag.countries = new List<string>()
            ViewData["countries"]=new List<string>()
                {"India",
                "China",
                "USA",
                "UK",
                "Denmark"
            };

            return View();
        }

    }
}
