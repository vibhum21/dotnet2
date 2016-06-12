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
        public ActionResult Index()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { EmployeeId = 331, Name = "Rajan Patil", Gender =  "Male", City = "Satara"});
            emplist.Add(new Employee() { EmployeeId = 332, Name = "Sameer Mane", Gender =  "Male",  City = "Nashik" });
            emplist.Add(new Employee() { EmployeeId = 333, Name = "Surabhi Varma", Gender = "Male",  City = "chennai" });
            emplist.Add(new Employee() { EmployeeId = 334, Name = "Chiranjivi Nene", Gender = "Male",  City = "Hydrabad" });
            emplist.Add(new Employee() { EmployeeId = 335, Name = "Raj Patil", Gender = "Male",  City = "Pune" });
            emplist.Add(new Employee() { EmployeeId = 333, Name = "Rajani Patil", Gender = "female",  City = "Kolhapur" });
            emplist.Add(new Employee() { EmployeeId = 333, Name = "Shubham Kale", Gender = "Male",  City = "Mumbai" });
            emplist.Add(new Employee() { EmployeeId = 333, Name = "Pallavi Patil", Gender = "Male",  City = "Delhi" });
            emplist.Add(new Employee() { EmployeeId = 333, Name = "Rajan Sharma", Gender = "Male",  City = "Kolkatta" });
            emplist.Add(new Employee() { EmployeeId = 333, Name = "Omkar Patil", Gender = "Male",  City = "Bangalore" });
            /*Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "John",
                Gender = "Male",
                City = "London"
            };
            return View(employee);*/

           //EmployeeContext employeeContext = new EmployeeContext();
           //List<Employee> emplist = employeeContext.employees.ToList();
           return View(emplist);

        }
        
        
        public ActionResult Details(int id)
        {
            Employee employee = new Employee()
                                { EmployeeId = 101,
                                  Name = "John", 
                                  Gender = "Male", 
                                  City = "London" 
                                };
          

          EmployeeContext employeeContext = new EmployeeContext();
         // Employee employee = employeeContext.employees.Single(emp => emp.EmployeeId ==id);
          //List<Employee> employees = employeeContext.employees.Where(emp => emp.DeptId == departmentId).ToList(); 
           return View(employee);
        }
    }
}
