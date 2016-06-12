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
    public class OilDAL
    {
        private static string conString = string.Empty;

        public static List<Oil> GetAll()
        {
            List<Oil> oils = new List<Oil>();
            conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            string cmdStr = "SELECT * FROM Oils";
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int oilId = int.Parse(dr["OilId"].ToString());
                    
                    string title = dr["Title"].ToString();
                    int quantity = int.Parse(dr["Quantity"].ToString());
                    double price = double.Parse(dr["Price"].ToString());
                   
                    Oil oil = new Oil();
                    oil.OilId = oilId;
                    oil.Title = title;
                    oil.Quantity = quantity;
                    oil.Price = price;
                    
                    oils.Add(oil);
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
            return oils;
        }
        public static Oil Get(int id)
        {
            Oil oil = null;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "SELECT * FROM Oils WHERE OilId=@OilId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@OilId", id));
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            oil = new Oil()
                            {
                                OilId = id,
                               
                                Title = reader["title"].ToString(),
                                Quantity=int.Parse(reader["Quantity"].ToString()),
                                Price = double.Parse(reader["price"].ToString()),
                               
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
            return oil;

        }
       
        public static bool Insert(Oil oil)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "INSERT INTO Oils VALUES(@OilId,@Title,@Quantity,@Price)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@OilId", oil.OilId));
                    cmd.Parameters.Add(new SqlParameter("@Title", oil.Title));
                    cmd.Parameters.Add(new SqlParameter("@Quantity", oil.Quantity));
                    cmd.Parameters.Add(new SqlParameter("@Price", oil.Price));
                    

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
        public static bool Update(Oil oil)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "UPDATE Oils SET Quantity=@Quantity ,Price=@Price" +
                        " WHERE OilId=@OilId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;
                   
                    cmd.Parameters.Add(new SqlParameter("@Title", oil.Title));
                    cmd.Parameters.Add(new SqlParameter("@Quantity", oil.Quantity));
                    cmd.Parameters.Add(new SqlParameter("@Price", oil.Price));
                    cmd.Parameters.Add(new SqlParameter("@OilId", oil.OilId));


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
                    string query = "DELETE Oils WHERE OilId=@OilId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@OilId", id));
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