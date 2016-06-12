using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using WorkshopBLLLib;
using System.Data.SqlClient;
using System.Configuration;

namespace WorkshopDALLib
{
    public class CustomerDAL
    {
        public static List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
           string conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            string cmdStr = "SELECT * FROM EMPLOYEES";
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string firstName = dr["firstName"].ToString();
                    string lastName = dr["lastName"].ToString();
                    string email = dr["email"].ToString();
                    DateTime bdate = Convert.ToDateTime(dr["birthDate"]);
                    float salary = float.Parse(dr["salary"].ToString());

                    Customer cst = new Customer();
                    cst.FirstName = firstName;
                    cst.Lastname = lastName;
                    cst.Email = email;
                    cst.Salary = salary;
                    customers.Add(cst);
                }

            }
            catch (SqlException exp)
            {
                Console.WriteLine(exp.Message);

            }
            finally
            {
                con.Close();
            }



            return customers;

        }
        public static Customer Get(int id)
        {
            Customer cst = new Customer();
            //ADO.NET code 
            return  cst;

        }
        public static Customer Get(string  VechicleNumber)
        {
            Customer cst = new Customer();
            //ADO.NET code 
            return cst;
        }
        public bool  Insert(Customer cst)
        {
            bool status = false;

            //ADO.NET Code

            return status;

        }
        public bool Update(Customer cst)
        {
            bool status = false;

            //ADO.NET Code

            return status;
        }
        public bool Delete(Customer cst)
        {
            bool status = false;

            //ADO.NET Code

            return status;
        }
    }
}
