using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemoFilterapp.Controllers
{

    class CustAuthFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.Controller.ViewBag.AutherizationMessage = "Custom Authorization: Message from OnAuthorization method.";
        }
    }

     public class CustomActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.CustomActionMessage1 = "Custom Action Filter: Message from OnActionExecuting method.";
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.CustomActionMessage2 = "Custom Action Filter: Message from OnActionExecuted method.";
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.CustomActionMessage3 = "Custom Action Filter: Message from OnResultExecuting method.";
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.CustomActionMessage4 = "Custom Action Filter: Message from OnResultExecuted method.";
        }
    }


    public class HomeController : Controller
    {
        // GET: Home

        [WebDemoFilterapp.Controllers.CustomActionFilter]
        public ActionResult Index()
        {
            
            //  ViewBag.countries = new List<string>()
            ViewData["countries"] = new List<string>()
                {"India",
                "China",
                "USA",
                "UK",
                "Denmark"
            };




            return View();
        }



        //OutPutTest Action Method
        
        [OutputCache(Duration = 10)]
        public ActionResult OutPutTest()
        {
            ViewBag.Date = DateTime.Now.ToString("T");
            return View();
        }

    }
}