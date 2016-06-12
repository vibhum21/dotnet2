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
   public class VehicleDAL
    {
        private static string conString = string.Empty;

        public static List<Vehicle> GetAll()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            string cmdStr = "SELECT * FROM Vehicles";
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string vehicleNumber = dr["vehicleNumber"].ToString();
                    int customerId = int.Parse(dr["customerId"].ToString());
                    string company = dr["company"].ToString();
                    string model = dr["model"].ToString();
                    Vehicle veh = new Vehicle();
                    veh.vehicleNumber = vehicleNumber;
                    veh.customerId = customerId;
                    veh.company = company;
                    veh.model = model;
                    vehicles.Add(veh);
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
            return vehicles;
        }
        public static Vehicle Get(int id)
        {
            Vehicle vehicle = null;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "SELECT * FROM Vehicles WHERE CustomerId=@CustomerId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@CustomerId", id));
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            vehicle = new Vehicle()
                            {
                                customerId = id,
                                vehicleNumber = reader["vehicleNumber"].ToString(),
                                company = reader["company"].ToString(),
                                model = reader["model"].ToString(),
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
            return vehicle;
        }
       public static bool Insert(Vehicle vehicle)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "INSERT INTO Vehicles VALUES(@VehicleNumber,@CustomerId,@Company,@Model)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;
                    
                    cmd.Parameters.Add(new SqlParameter("@VehicleNumber", vehicle.vehicleNumber));
                    cmd.Parameters.Add(new SqlParameter("@CustomerId", vehicle.customerId));
                    cmd.Parameters.Add(new SqlParameter("@Company", vehicle.company));
                    cmd.Parameters.Add(new SqlParameter("@Model", vehicle.model));

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
        public static bool Update(Vehicle vehicle)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "UPDATE Vehicles SET company=@Company, [model]=@Model " +
                        " WHERE CustomerId=@CustomerId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@CustomerId", vehicle.customerId));
                    cmd.Parameters.Add(new SqlParameter("@Company", vehicle.company));
                    cmd.Parameters.Add(new SqlParameter("@model", vehicle.model));

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
                    string query = "DELETE Vehicles WHERE CustomerId=@CustomerId";
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
