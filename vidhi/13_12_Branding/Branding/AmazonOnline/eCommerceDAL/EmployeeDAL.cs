using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceBOL;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace eCommerceDAL
{
   public class EmployeeDAL
    {
        private static string conString = string.Empty;

        static EmployeeDAL()
        {
            conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\MSNET_150844220202\EmployeeRegistration\Employee\App_Data\eCommerseDB.mdf;Integrated Security=True";
        }
        public IEnumerable<Employee> Employees
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;

                List<Employee> employees = new List<Employee>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("select * from EMPLOYEE", con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee employee = new Employee();
                        employee.FirstName = rdr["FirstName"].ToString();
                        employee.LastName = rdr["LastName"].ToString();
                        employee.EmployeeId = Convert.ToInt32(rdr["EmployeeID"].ToString());
                        employee.Password = rdr["Password"].ToString();
                        employee.EmailId = rdr["EmailID"].ToString();
                        employee.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"].ToString());
                        employee.Department = rdr["Department"].ToString();
                        employee.Address = rdr["Address"].ToString();
                        employee.MobileNumber = rdr["Mobilenumber"].ToString();
                        employee.EmployeePhoto = rdr["Employeephoto"].ToString();

                        employees.Add(employee);
                    }
                }
                return employees;
            }
        }

       public void Insert(Employee employee)
       {
          
          
               conString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;
               using (SqlConnection con = new SqlConnection(conString))
               {
                   string query = "INSERT INTO EMPLOYEE(FirstName,LastName,EmployeeID,Password,EmailID,DateOfBirth,Department,Address,Mobilenumber,Employeephoto) VALUES('" + employee.FirstName + "','" + employee.LastName + "','" + employee.EmployeeId + "','" + employee.Password + "','" + employee.EmailId + "','" + employee.DateOfBirth + "','"+employee.Department+"','"+employee.Address+"','"+employee.MobileNumber+"','"+employee.EmployeePhoto+"')";
                   SqlCommand cmd = new SqlCommand(query, con);
                   cmd.CommandType = CommandType.Text;
                   con.Open();
                   int value = cmd.ExecuteNonQuery();
                   con.Close();                   

                   
                   
               }
           }

    }
}
