using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ASP_NET_MVC_1.Models
{
     public class EmployeeContext
    {
        public List<Employee> list = new List<Employee>();

        public EmployeeContext()
        {
            list.Add(new Employee() { EmployeeId = 330, Name = "Rajan Patil", Gender = "Male", City = "Satara" });
            list.Add(new Employee { EmployeeId = 331, Name = "Radhika Patil", Gender = "Female", City = "Satara" });
            list.Add(new Employee { EmployeeId = 332, Name = "Sameer Mane", Gender = "Male", City = "Nashik" });
            list.Add(new Employee { EmployeeId = 333, Name = "Santosh Varma", Gender = "Male", City = "chennai"});
            list.Add(new Employee { EmployeeId = 334, Name = "Manish Nene", Gender = "Male", City = "Hydrabad"});
            list.Add(new Employee { EmployeeId = 335, Name = "Ranjana Patil", Gender = "Female", City = "Pune" });
            list.Add( new Employee { EmployeeId = 336, Name = "Manoj Ogale", Gender = "Male", City = "Kolhapur" });
            list.Add(new Employee { EmployeeId = 337, Name = "Sarika Kale", Gender = "Female", City = "Mumbai" });
            list.Add(new Employee { EmployeeId = 338, Name = "Jeevan Samba", Gender = "Male", City = "Delhi" });
            list.Add(new Employee { EmployeeId = 339, Name = "Manisha Sharma", Gender = "Female", City = "Kolkatta" });
            list.Add( new Employee { EmployeeId = 340, Name = "Rajiv Patil", Gender = "Male", City = "Bangalore" });
            list.Add(new Employee { EmployeeId = 341, Name = "Racvi Thombre", Gender = "Male", City = "Satara"});
            list.Add(new Employee { EmployeeId = 342, Name = "Sameer Kant", Gender = "Male", City = "Nashik"});
            list.Add( new Employee { EmployeeId = 343, Name = "Reena Varma", Gender = "Female", City = "chennai" });
            list.Add( new Employee { EmployeeId = 344, Name = "Manju Nene", Gender = "Female", City = "Hydrabad" });
            list.Add(new Employee { EmployeeId = 345, Name = "Raj Roja", Gender = "Male", City = "Pune" });
            list.Add(new Employee { EmployeeId = 346, Name = "Manoj Ogale", Gender = "Male", City = "Kolhapur"});
            list.Add( new Employee { EmployeeId = 347, Name = "Shubham More", Gender = "Male", City = "Mumbai" });
            list.Add(new Employee { EmployeeId = 348, Name = "Rupali Samba", Gender = "Female", City = "Delhi" });
            list.Add(new Employee { EmployeeId = 349, Name = "Manoj Varma", Gender = "Male", City = "Kolkatta"});
            list.Add(new Employee { EmployeeId = 350, Name = "Pratap Patil", Gender = "Male", City = "Bangalore" });
            list.Add(new Employee { EmployeeId = 351, Name = "Sangita Kolhe", Gender = "Female", City = "Satara" });
            list.Add( new Employee { EmployeeId = 352, Name = "Lochan Manohar", Gender = "Male", City = "Nashik"});
            list.Add(new Employee { EmployeeId = 353, Name = "Meenl Varma", Gender = "Female", City = "chennai" });
            list.Add( new Employee { EmployeeId = 354, Name = "Manish Kumar", Gender = "Male", City = "Hydrabad"});
            list.Add( new Employee { EmployeeId = 355, Name = "Raj Patil", Gender = "Male", City = "Pune" });
            list.Add( new Employee { EmployeeId = 356, Name = "Kumar Ogale", Gender = "Male", City = "Kolhapur" });
            list.Add( new Employee { EmployeeId = 357, Name = "Shubham Kale", Gender = "Male", City = "Mumbai"});
            list.Add(new Employee { EmployeeId = 358, Name = "Jeevan Kumar", Gender = "Male", City = "Delhi"});
            list.Add(new Employee { EmployeeId = 359, Name = "Sham Sutar", Gender = "Male", City = "Kolkatta" });
            list.Add( new Employee { EmployeeId = 360, Name = "Deepak Patil", Gender = "Male", City = "Bangalore"});
        
      
        }
  
        }
}