using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ASP_NET_MVC_1.Models
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}