using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_NET_MVC_1.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } 
        public string Gender { get; set; }
        public string City { get; set; }
        //[ForeignKey("id")]
        //[Column("deptid")]
        public int DeptId { get; set; }
    }
}