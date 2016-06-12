using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstFiltersLib
{
    class CustAuthFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.Controller.ViewBag.AutherizationMessage = "Custom Authorization: Message from OnAuthorization method.";
        }
    }

}
