using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerceBOL;

using eCommerceDAL;
namespace SunbeamPuneShoppingWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
             return View();
        }
        [HttpPost]
        public ActionResult Validate(FormCollection formCollection)
        {
            Customer login = new Customer();
            // Retrieve form data using form collection 

            login.EmailId = formCollection["EmailId"];
            login.Password = formCollection["Password"];

            List<Customer> loginlist = CustomerDAL.GetAll();
            bool status = false;
            foreach (Customer c in loginlist)
                if (c.EmailId.Equals(login.EmailId) && c.Password.Equals(login.Password))
                    //return RedirectToAction("Index");
                    status = true;
            if (status == true)
                return RedirectToAction("Index");
            else
                return View();
        }
    [HttpGet]
        public ActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
    public ActionResult ChangePassword(FormCollection formCollection)
    {
        Customer cust = new Customer();
        cust.Password = formCollection["Password"];
        string npassword = formCollection["Password1"];
        string cnfpassword = formCollection["Password2"];
        List<Customer> loginlist = CustomerDAL.GetAll();
        foreach (Customer c in loginlist)
            if (c.Password.Equals(cust.Password))
                if (npassword == cnfpassword)
                    CustomerDAL.Update(c);
            return RedirectToAction("Index");
    }
    }
}