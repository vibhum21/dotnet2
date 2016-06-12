using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DBConsoleTestApplication
{
    public class Employee
    {
     public     string FirstName { get; set; }
      public   string Lastname { get; set; }
      public   string Email { get; set; }
     public    float Salary { get; set; }

     public override string ToString()
     {
         return FirstName + " " + Lastname + " " + Salary;

         //return base.ToString();
     }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //PerformConnectedDataAccess();
            PerformDisConnectedDataAccess();
            Console.ReadLine();
    
        }

        static void  PerformConnectedDataAccess()
        {
            List<Employee> employees = new List<Employee>();
            string conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            string cmdStr = "SELECT * FROM EMPLOYEES";
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            try {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string firstName = dr["firstName"].ToString();
                    string lastName = dr["lastName"].ToString();
                    string email = dr["email"].ToString();
                    DateTime bdate = Convert.ToDateTime(dr["birthDate"]) ;
                    float salary = float.Parse(dr["salary"].ToString());

                    Employee emp = new Employee();
                    emp.FirstName = firstName;
                    emp.Lastname = lastName;
                    emp.Email = email;
                    emp.Salary = salary;
                    employees.Add(emp);
                      }

            }
            catch (SqlException  exp)
            {
                Console.WriteLine(exp.Message);

            }
            finally
            {
                con.Close();
            }


            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);

            }

         }

        static void PerformDisConnectedDataAccess()
        {
            List<Employee> employees = new List<Employee>();
            string conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            string cmdStr = "SELECT * FROM EMPLOYEES";
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds);
            DataTable tbl = ds.Tables[0];
            DataRowCollection  dtr = tbl.Rows;

            foreach (DataRow dr in dtr)
            {
                string firstName = dr["firstName"].ToString();
                string lastName = dr["lastName"].ToString();
                string email = dr["email"].ToString();
                DateTime bdate = Convert.ToDateTime(dr["birthDate"]);
                float salary = float.Parse(dr["salary"].ToString());

                Employee emp = new Employee();
                emp.FirstName = firstName;
                emp.Lastname = lastName;
                emp.Email = email;
                emp.Salary = salary;
                employees.Add(emp);
            }


            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);

            }
 
        }


        //CRUD Operations
      
        //
        //UPDATE SET EMPLOYEES  FANME= ""  WEHERE EMPID=23
        //DELETE FROM EMPLOYEES WHERE empID=45;

        //SELECT *  FROM  EMPLOYESS WHERE 
        //SELECT COUNT(*) FROM EMPLOYEES

        static  void PerformInsertData()
        {

            string conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            string cmdStr = "SELECT count(*)  FROM EMPLOYEES";
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            try
            {
                con.Open();
            }
            catch (SqlException exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                con.Close();
            }
        }


    }
}
