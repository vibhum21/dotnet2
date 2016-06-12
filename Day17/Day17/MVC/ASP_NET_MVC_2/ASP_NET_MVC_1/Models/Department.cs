using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ASP_NET_MVC_1.Models
{
     public class Department
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public List<Employee> Employees { set; get; }
    }
}