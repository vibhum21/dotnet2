using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;

namespace ASP_NET_MVC_1.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
      //  public List<Employee> Employees { set; get; }
    }
}