using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ASP_NET_MVC_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //  ViewBag.countries = new List<string>()

            ViewData["countries"] = new List<string>()
                                    {   "India","Singapore","Indonesia",
                                        "China","Taiwan","South Koria","Nepal",
                                        "USA","France","Rassia","Japan",
                                        "UK","UK","Brazil","Germany",
                                        "South Africa","UAE"
                                    };
            return View();
        }
    }
}
