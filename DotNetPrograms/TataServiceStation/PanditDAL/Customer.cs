using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanditBOLLib;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace PanditDALLib
{
    public class CustomerDAL
    {
        private static string conString = string.Empty;
       
        public static List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            string cmdStr = "SELECT * FROM Customers";
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int customerId = int.Parse(dr["customerId"].ToString());
                    string name = dr["name"].ToString();
                    string address = dr["address"].ToString();
                    string mobile = dr["mobile"].ToString();
                    double creditAmount = double.Parse(dr["creditAmount"].ToString());
                    Customer cust = new Customer();
                    cust.customerId = customerId;
                    cust.name = name;
                    cust.address = address;
                    cust.mobile = mobile;
                    cust.creditAmount = creditAmount;
                    customers.Add(cust);
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
            Customer customer = null;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using(SqlConnection con=new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "SELECT * FROM Customers WHERE CustomerId=@CustomerId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@CustomerId",id));
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {   
                            reader.Read();
                            customer = new Customer()
                            {
                               customerId=id,name=reader["name"].ToString(),address=reader["address"].ToString(),
                               mobile=reader["mobile"].ToString(),creditAmount=double.Parse(reader["creditAmount"].ToString())
                            };
                        }
                    }
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //ADO.NET code 
            return customer;

        }
        public static Customer Get(string name)
        {
            Customer customer = null;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "SELECT * FROM Customers WHERE name=@Name";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Name", name));
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            customer = new Customer()
                            {
                               // customerId = id,
                                name = name,
                                address = reader["address"].ToString(),
                                mobile = reader["mobile"].ToString(),
                                creditAmount = double.Parse(reader["creditAmount"].ToString())
                            };
                        }
                    }
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //ADO.NET code 
            return customer;

        }
       
        public static bool Insert(Customer customer)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "INSERT INTO Customers VALUES(@CustomerId,@name,@address,@mobile,@CreditAmount)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@CustomerId", customer.customerId));
                    cmd.Parameters.Add(new SqlParameter("@name", customer.name));
                    cmd.Parameters.Add(new SqlParameter("@address", customer.address));
                    cmd.Parameters.Add(new SqlParameter("@mobile", customer.mobile));
                    cmd.Parameters.Add(new SqlParameter("@CreditAmount", customer.creditAmount));

                    cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (Exception ex)
            {
                 ex.ToString();
            }

            return status;

        }
        public static bool Update(Customer customer)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "UPDATE Customers SET name=@Name, [address]=@Address, " +
                        "mobile=@Mobile ,creditAmount=@CreditAmount" +
                        " WHERE CustomerId=@CustomerId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@CustomerId", customer.customerId));
                    cmd.Parameters.Add(new SqlParameter("@name", customer.name));
                    cmd.Parameters.Add(new SqlParameter("@address", customer.address));
                    cmd.Parameters.Add(new SqlParameter("@mobile", customer.mobile));
                    cmd.Parameters.Add(new SqlParameter("@CreditAmount", customer.creditAmount));

                    cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return status;
        }
        public static bool Delete(int id)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "DELETE Customers WHERE CustomerId=@CustomerId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@CustomerId",id));
                    cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return status;

        }
    }
}