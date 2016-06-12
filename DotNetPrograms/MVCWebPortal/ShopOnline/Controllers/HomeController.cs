using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerceBOL;
using eCommerceDAL;
namespace ShopOnline.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Customer> cust = CustomerDAL.GetAll();
           // ViewData["Customer"] = cust;

            return View(cust);
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}