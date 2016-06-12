
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_1.Models;

namespace ASP_NET_MVC_1.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        
        public EmployeeController()
        {
        }

        public ActionResult Index()
        {
           EmployeeContext employeeContext = new EmployeeContext();
          /// List<Employee> emplist = employeeContext.list;
        //  List<Employee> emplist = employeeContext.list.Where(emp => emp.Gender =="Female").ToList();


         //  List<Employee> emplist = employeeContext.list.Where(emp => emp.Gender == "Female").ToList();
           List<Employee> emplist = employeeContext.list.Where(emp => emp.City=="Mumbai").ToList();
        
            
            return View(emplist);
        }
  
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.list.Single(emp => emp.EmployeeId == id);
           // List<Employee> employees = employeeContext.employees.Where(emp => emp.DeptId == departmentId).ToList();
            return View(employee);
        }
    }
}
