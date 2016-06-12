using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_1.Models;

namespace ASP_NET_MVC_1.Controllers
{
    public class DepartmentController : Controller
    {
      
        public ActionResult Index()
         {
             EmployeeContext employeeContext = new EmployeeContext();
             DepartmentContext departmentContext = new DepartmentContext();
             List<Department> deptList = departmentContext.list;
             return View(deptList);
        }
 }
}
