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
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

      /*  [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            if (ModelState.IsValid) 
            {
                foreach (string key in formCollection.AllKeys)
                { 
                    Response.Write("Key = " + key + " ");
                    Response.Write("Value = " + formCollection[key]); 
                    Response.Write("[br/]");
                } 
            } return View();
        }
       * */


        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            Employee employee = new Employee(); 
            // Retrieve form data using form collection 
            employee.ID = 9434;
            employee.DeptID = 15;
            employee.Name = formCollection["Name"];
            employee.Gender = formCollection["Gender"]; 
            employee.City = formCollection["City"];
            employee.Salary = int.Parse(formCollection["Salary"].ToString()); 
      
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.AddEmmployee(employee);
   
            return RedirectToAction("Index");
        }






    }
}
