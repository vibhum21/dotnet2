using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_1.Models;
using BusinessLayer;
namespace ASP_NET_MVC_1.Controllers
{
    public class EmployeeController : Controller
    {
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
        //   List<Employee> employees = employeeContext.employees.Where(emp => emp.DeptId == departmentId).ToList(); 
           return View(employee);
        }
     
       [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

       /*  [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            Employee employee = new Employee(); 
            // Retrieve form data using form collection 
            employee.ID = 36;
            employee.DeptID = 2;
            employee.Name = formCollection["Name"];
            employee.Gender = formCollection["Gender"]; 
            employee.City = formCollection["City"]; 
           // employee.DateOfBirth = Convert.ToDateTime(formCollection["DateO­fBirth"]); 
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.AddEmmployee(employee);
            return RedirectToAction("Index");
        }*/

        [HttpPost]
        public ActionResult Create(string name, string gender, string city)
        {
            Employee employee = new Employee(); 
            employee.ID = 40;
            employee.DeptID = 15;
            employee.Name = name;
            employee.Gender = gender; 
            employee.City = city; 
           // employee.DateOfBirth = Convert.ToDateTime(formCollection["DateO­fBirth"]); 
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.AddEmmployee(employee);
            return RedirectToAction("Index");
        } 

    }
}
