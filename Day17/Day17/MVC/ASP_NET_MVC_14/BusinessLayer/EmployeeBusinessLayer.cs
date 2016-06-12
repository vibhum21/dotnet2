using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public IEnumerable<Employee> Employees
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;

                List<Employee> employees = new List<Employee>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    SqlCommand cmd = new SqlCommand("select * from Employees", con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee employee = new Employee();
                        employee.ID = Convert.ToInt32(rdr["Id"]);
                        employee.Name = rdr["Name"].ToString();
                        employee.Gender = rdr["Gender"].ToString();
                        employee.City = rdr["City"].ToString();
                        // employee.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);

                        employees.Add(employee);
                    }
                }
                return employees;

            }
        }

        public Employee GetEmployee(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;

            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlcmd = "select * from Employees where Id=" + id;

                SqlCommand cmd = new SqlCommand(sqlcmd, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    employee.ID = Convert.ToInt32(rdr["Id"]);
                    employee.Name = rdr["Name"].ToString();
                    employee.Gender = rdr["Gender"].ToString();
                    employee.City = rdr["City"].ToString();
                    // employee.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);
                }
            }
            return employee;

        }

        public void AddEmmployee(Employee emp)
        {
          string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;
           using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlcmd = "Insert into Employees (Id,Name, Gender, City,DeptId) Values (" + emp.ID + ",'" + emp.Name + "','" + emp.Gender + "','" + emp.City + "'," + emp.DeptID + ")";
                SqlCommand cmd = new SqlCommand(sqlcmd, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                int value = cmd.ExecuteNonQuery();
                con.Close();
            }
           
            /*
            SharePoint Object Model
             */
        }
        
        public void DeleteEmmployee(Employee emp)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlcmd = "Delete from Employees where Id="+ emp.ID;
                SqlCommand cmd = new SqlCommand(sqlcmd, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                int value = cmd.ExecuteNonQuery();
                con.Close();
            }

            /*
            SharePoint Object Model
             */
        }

        public void UpdateEmmployee(Employee emp)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlcmd = "Insert into Employees (Id,Name, Gender, City,DeptId) Values (" + emp.ID + ",'" + emp.Name + "','" + emp.Gender + "','" + emp.City + "'," + emp.DeptID + ")";
                SqlCommand cmd = new SqlCommand(sqlcmd, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                int value = cmd.ExecuteNonQuery();
                con.Close();
            }

          
        }
    }
}

