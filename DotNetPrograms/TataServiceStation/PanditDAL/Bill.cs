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
    public class BillDAL
    {
        private static string conString = string.Empty;

        public static List<Bill> GetAll()
        {
            List<Bill> bills = new List<Bill>();
            conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            string cmdStr = "SELECT * FROM Bills";
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int billId = int.Parse(dr["BillId"].ToString());
                    DateTime billDate = DateTime.Parse(dr["BillDate"].ToString());
                    double amount = double.Parse(dr["amount"].ToString());
                    double amountPaid = double.Parse(dr["amountPaid"].ToString());
                    int customerId = int.Parse(dr["CustomerId"].ToString());
                    Bill bill = new Bill();
                    bill.BillId = billId;
                    bill.BillDate = billDate;
                    bill.Amount = amount;
                    bill.AmountPaid = amountPaid;
                    bill.CustomerID = customerId;
                    bills.Add(bill);
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
            return bills;
        }
        public static Bill Get(int id)
        {
            Bill bill = null;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "SELECT * FROM Bills WHERE CustomerId=@CustomerId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@CustomerId", id));
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            bill = new Bill()
                            {
                                CustomerID = id,
                                BillId = int.Parse(reader["billId"].ToString()),
                                BillDate = DateTime.Parse(reader["billDate"].ToString()),
                                Amount = double.Parse(reader["amount"].ToString()),
                                AmountPaid = double.Parse(reader["AmountPaid"].ToString())
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
            return bill;

        }
        public static Bill Get(string VehicleNumber)
        {
            Bill bill = new Bill();
            //ADO.NET code 
            return bill;
        }
        public static bool Insert(Bill bill)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "INSERT INTO Bills VALUES(@BillId,@BillDate,@Amount,@AmountPaid,@CustomerId)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@CustomerId", bill.CustomerID));
                    cmd.Parameters.Add(new SqlParameter("@BillId", bill.BillId));
                    cmd.Parameters.Add(new SqlParameter("@BillDate", bill.BillDate));
                    cmd.Parameters.Add(new SqlParameter("@Amount", bill.Amount));
                    cmd.Parameters.Add(new SqlParameter("@AmountPaid", bill.AmountPaid));

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
        public static bool Update(Bill bill)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "UPDATE Bills SET BillId=@BillId, [BillDate]=@BillDate, " +
                        "Amount=@Amount ,AmountPaid=@AmountPaid" +
                        " WHERE CustomerId=@CustomerId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;
                    cmd.Parameters.Add(new SqlParameter("@CustomerId", bill.CustomerID));
                    cmd.Parameters.Add(new SqlParameter("@BillId", bill.BillId));
                    cmd.Parameters.Add(new SqlParameter("@BillDate", bill.BillDate));
                    cmd.Parameters.Add(new SqlParameter("@Amount", bill.Amount));
                    cmd.Parameters.Add(new SqlParameter("@AmountPaid", bill.AmountPaid));
                   

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
                    string query = "DELETE Bills WHERE CustomerId=@CustomerId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@CustomerId", id));
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
