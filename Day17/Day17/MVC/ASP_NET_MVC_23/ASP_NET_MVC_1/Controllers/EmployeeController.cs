using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using ASP_NET_MVC_1.Models;
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
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            
                // Retrieve form data using form collection 
                Employee employee = new Employee();
                employee.ID = 46;
               // employee.d = 2;
               // UpdateModel(employee);
                TryUpdateModel(employee);
    
            if (ModelState.IsValid)
                {

                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.AddEmmployee(employee);
                return RedirectToAction("Index");
                 }
                 else
             {
                 return View();
        
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        { 
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer(); 
            Employee employee = employeeBusinessLayer.Employees.Single(emp=>emp.ID==id); 
            return View(employee);
        }

       /* [HttpPost]
        public ActionResult Edit(Employee employee)
        { 
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.SaveEmmployee(employee); 
                return RedirectToAction("Index"); 
            } 
            return View(employee);
        }
        * */

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        { 
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer(); 
            Employee employee = employeeBusinessLayer.Employees.Single(x => x.ID == id);
           // UpdateModel(employee, new string[] { "ID", "Gender", "City"});
            UpdateModel(employee);
            if (ModelState.IsValid) 
            {
                employeeBusinessLayer.SaveEmmployee(employee); 
                return RedirectToAction("Index"); 
            }
            return View(employee);
        }
        
        public ActionResult Delete(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee employee = employeeBusinessLayer.Employees.Single(x => x.ID == id);
            employeeBusinessLayer.DeleteEmmployee(employee); 
            return RedirectToAction("Index");
        }
    }
}
