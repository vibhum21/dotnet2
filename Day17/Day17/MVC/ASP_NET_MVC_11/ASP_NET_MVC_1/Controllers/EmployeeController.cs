using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;


namespace ASP_NET_MVC_1.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Index()
        {
             EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
             List<Employee> employees = employeeBusinessLayer.Employees.ToList();
  
                           
            return View(employees);
        }

        public ActionResult Details(int id)
        {
          EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
          Employee employee = employeeBusinessLayer.GetEmployee(id);
          return View(employee);
        }

    }
}
