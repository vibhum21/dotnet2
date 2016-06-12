using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceBOL
{
   public class Employee
    {
        //[Required]
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public int EmployeeId { get; set; }
       public string Password { get; set; }
       public string EmailId { get; set; }
     //  [Required]
       public DateTime DateOfBirth { get; set; }
       public string Department { get; set; }
       public string Address { get; set; }
       public string MobileNumber { get; set; }
       public string EmployeePhoto { get; set; }

    }
}
