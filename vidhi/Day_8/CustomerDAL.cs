using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using eCommerceBOL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace eCommerceDAL
{
    public class CustomerDAL
    {
        private static string conString = string.Empty;

        static CustomerDAL()
        {
            conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        public static bool Insert(Customer customer)
        {
            bool status = false;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "Proc_Add_Customer";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@FirstName", customer.FirstName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", customer.LastName));
                    cmd.Parameters.Add(new SqlParameter("@Address", customer.Address));
                    cmd.Parameters.Add(new SqlParameter("@Email", customer.EmailId));
                    cmd.Parameters.Add(new SqlParameter("@MobileNo", customer.MobileNo));
                    cmd.Parameters.Add(new SqlParameter("@RegistrationDate", customer.RegistrationDate));
                    cmd.Parameters.Add(new SqlParameter("@Password", customer.Password));
                    cmd.Parameters.Add(new SqlParameter("@Role", customer.Role));

                    cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }
        public static bool Update(Customer customer)
        {
            bool status = false;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "UPDATE Customers SET FirstName=@FirstName, LastName=@LastName, [Address]=@Address, " +
                        "Email=@Email, MobileNo=@MobileNo, RegistrationDate=@RegistrationDate, [Password]=@Password, " +
                        "[Role]=@Role WHERE CustomersId=@CustomersId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@FirstName", customer.FirstName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", customer.LastName));
                    cmd.Parameters.Add(new SqlParameter("@Address", customer.Address));
                    cmd.Parameters.Add(new SqlParameter("@Email", customer.EmailId));
                    cmd.Parameters.Add(new SqlParameter("@MobileNo", customer.MobileNo));
                    cmd.Parameters.Add(new SqlParameter("@RegistrationDate", customer.RegistrationDate));
                    cmd.Parameters.Add(new SqlParameter("@Password", customer.Password));
                    cmd.Parameters.Add(new SqlParameter("@Role", customer.Role));
                    cmd.Parameters.Add(new SqlParameter("@CustomersId", customer.CustomerId));
                    cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }
        public static bool Delete(int customerId)
        {
            bool status = false;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "DELETE FROM Customers WHERE CustomersId=@CustomersId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@CustomersId", customerId));
                    cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }
        public static Customer Get(int customerId)
        {
            Customer customer = null;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "SELECT * FROM Customers WHERE CustomersId=@CustomersId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@CustomersId", customerId));
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader!=null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            customer = new Customer()
                            {
                                CustomerId = customerId, FirstName=reader["FirstName"].ToString(), LastName = reader["LastName"].ToString(),
                                Address = reader["Address"].ToString(), EmailId = reader["Email"].ToString(), MobileNo= reader["MobileNo"].ToString(),
                                Password = reader["Password"].ToString(), RegistrationDate= DateTime.Parse(reader["RegistrationDate"].ToString())
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

            return customer;
        }
        public static List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "SELECT * FROM Customers";
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Customer customer = new Customer()
                                {
                                    CustomerId = int.Parse(reader["CustomersId"].ToString()),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    EmailId = reader["Email"].ToString(),
                                    MobileNo = reader["MobileNo"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    RegistrationDate = DateTime.Parse(reader["RegistrationDate"].ToString())
                                };
                                customers.Add(customer);
                            }
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

            return customers;
        }

    }
}
