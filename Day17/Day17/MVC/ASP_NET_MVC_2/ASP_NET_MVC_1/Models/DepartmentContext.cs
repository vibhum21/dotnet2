using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_NET_MVC_1.Models
{
    public class DepartmentContext
    {
       public  List<Department> list = new List<Department>();

        public DepartmentContext()
        {
            List<Department> deparments = list;
            deparments.Add(new Department() 
                       { Id = 12,
                         Name = "Training" ,
                          Employees =new List<Employee> { new  Employee{ EmployeeId = 331, Name = "Radhika Patil", Gender = "Female", City = "Satara" },
                                         new  Employee{ EmployeeId = 332, Name = "Sameer Mane", Gender = "Male", City = "Nashik" },
                                         new  Employee{ EmployeeId = 333, Name = "Santosh Varma", Gender = "Male", City = "chennai" } ,
                                         new  Employee{ EmployeeId = 334, Name = "Manish Nene", Gender = "Male", City = "Hydrabad" } ,
                                         new  Employee{ EmployeeId = 335, Name = "Ranjana Patil", Gender = "Female", City = "Pune" }
                                                             }
                        });
            deparments.Add(new Department()
                        {
                            Id = 13,
                            Name = "Sales",
                            Employees = new List<Employee>{ new  Employee{ EmployeeId = 336, Name = "Manoj Ogale", Gender = "Male", City = "Kolhapur" },
                                         new  Employee{ EmployeeId = 337, Name = "Sarika Kale", Gender = "Fmale", City = "Mumbai" },
                                         new  Employee{ EmployeeId = 338, Name = "Jeevan Samba", Gender = "Male", City = "Delhi" },
                                         new  Employee{ EmployeeId = 339, Name = "Manisha Sharma", Gender = "Female", City = "Kolkatta" },
                                         new  Employee{ EmployeeId = 340, Name = "Rajiv Patil", Gender = "Male", City = "Bangalore" }
                                       }
                        });

            deparments.Add(new Department()
            {
                Id = 14,
                Name = "Accounts",
                Employees = new List<Employee>{ new  Employee{ EmployeeId = 341, Name = "Racvi Thombre", Gender = "Male", City = "Satara" },
                                         new  Employee{ EmployeeId = 342, Name = "Sameer Kant", Gender = "Male", City = "Nashik" },
                                         new  Employee{ EmployeeId = 343, Name = "Reena Varma", Gender = "Female", City = "chennai" } ,
                                         new  Employee{ EmployeeId = 344, Name = "Manju Nene", Gender = "Female", City = "Hydrabad" } ,
                                         new  Employee{ EmployeeId = 345, Name = "Raj Roja", Gender = "Male", City = "Pune" }
                                                             }
            });
            deparments.Add(new Department()
            {
                Id = 15,
                Name = "HumanResource",
                Employees = new List<Employee>{ new  Employee{ EmployeeId = 346, Name = "Manoj Ogale", Gender = "Male", City = "Kolhapur" },
                                         new  Employee{ EmployeeId = 347, Name = "Shubham More", Gender = "Male", City = "Mumbai" },
                                         new  Employee{ EmployeeId = 348, Name = "Rupali Samba", Gender = "Fmale", City = "Delhi" },
                                         new  Employee{ EmployeeId = 349, Name = "Manoj Varma", Gender = "Male", City = "Kolkatta" },
                                         new  Employee{ EmployeeId = 350, Name = "Pratap Patil", Gender = "Male", City = "Bangalore" }
                                       }
            });

            deparments.Add(new Department()
            {
                Id = 16,
                Name = "Compliance",
                Employees = new List<Employee>{ new  Employee{ EmployeeId = 331, Name = "Sangita Kolhe", Gender = "Fmale", City = "Satara" },
                                         new  Employee{ EmployeeId = 332, Name = "Lochan Manohar", Gender = "Male", City = "Nashik" },
                                         new  Employee{ EmployeeId = 333, Name = "Meenl Varma", Gender = "Female", City = "chennai" } ,
                                         new  Employee{ EmployeeId = 334, Name = "Manish Kumar", Gender = "Male", City = "Hydrabad" } ,
                                         new  Employee{ EmployeeId = 335, Name = "Raj Patil", Gender = "Male", City = "Pune" }
                                                             }
            });
            deparments.Add(new Department()
            {
                Id = 17,
                Name = "Sales",
                Employees = new List<Employee>{ new  Employee{ EmployeeId = 336, Name = "Kumar Ogale", Gender = "Male", City = "Kolhapur" },
                                         new  Employee{ EmployeeId = 337, Name = "Shubham Kale", Gender = "Male", City = "Mumbai" },
                                         new  Employee{ EmployeeId = 338, Name = "Jeevan Kumar", Gender = "Male", City = "Delhi" },
                                         new  Employee{ EmployeeId = 339, Name = "Sham Sutar", Gender = "Female", City = "Kolkatta" },
                                         new  Employee{ EmployeeId = 334, Name = "Deepak Patil", Gender = "Male", City = "Bangalore" }
                                       }
            });


          
        }


    }

}