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
            List<Department> deparments = new List<Department>();
            deparments.Add(new Department(){ Id=34,Name="Training"});
            deparments.Add(new Department(){ Id=44,Name="Sales"});
            deparments.Add(new Department(){ Id=54,Name="Finance"}); 
            deparments.Add(new Department(){ Id=64,Name="Research"}); 
            deparments.Add(new Department(){ Id=74,Name="Information Technology"});
            return View(deparments); 
        }


        public ActionResult Details(int id)
        {
            //  Department department = employeeContext.departments.Single(dept => dept.Id == id);
            Department department = new Department { Id = id, Name = "Training" };
            return View(department);
         }
    }
}
