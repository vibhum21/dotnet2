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
   public class JobDAL
    {
        private static string conString = string.Empty;

        public static List<Job> GetAll()
        {
            List<Job> jobs = new List<Job>();
            conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            string cmdStr = "SELECT * FROM Jobs";
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int jobId = int.Parse(dr["JobId"].ToString());
                    string jobType = dr["JobType"].ToString();
                    string jobDescription = dr["jobDescription"].ToString();
                    DateTime jobDate = DateTime.Parse(dr["JobDate"].ToString());
                    string vehicleNumber = dr["vehicleNumber"].ToString();
                    double serviceCharge = double.Parse(dr["ServiceCharge"].ToString());
                    int quantity = int.Parse(dr["Quantity"].ToString());
                    int sparePartId = int.Parse(dr["SparePartId"].ToString());
                    Job job = new Job();
                    job.JobId = jobId;
                    job.JobType = jobType;
                    job.JobDescription = jobDescription;
                    job.JobDate = jobDate;
                    job.VehicleNumber = vehicleNumber;
                    job.ServiceCharge = serviceCharge;
                    job.Quantity = quantity;
                    job.SparePartId = sparePartId;
                    jobs.Add(job);
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
            return jobs;
        }
        public static Job Get(int id)
        {
            Job job = null;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "SELECT * FROM Jobs WHERE JobId=@JobId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@JobId", id));
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            job = new Job()
                            {
                                JobId = int.Parse(reader["JobId"].ToString()),
                                JobType = reader["JobType"].ToString(),
                                JobDescription = reader["jobDescription"].ToString(),
                                JobDate=DateTime.Parse(reader["JobDate"].ToString()),
                                VehicleNumber = reader["vehicleNumber"].ToString(),
                                ServiceCharge = double.Parse(reader["ServiceCharge"].ToString()),
                                Quantity=int.Parse(reader["Quantity"].ToString()),
                                SparePartId = int.Parse(reader["SparePartId"].ToString()),
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
            return job;

        }
        public static Job Get(string VehicleNumber)
        {
            Job job = new Job();
            //ADO.NET code 
            return job;
        }
        public static bool Insert(Job job)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "INSERT INTO Jobs VALUES(@JobId,@JobType,@JobDescription,@JobDate,@VehicleNumber,@ServiceCharge,@Quantity,@SparePartID)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@SparePartID", job.SparePartId));
                    cmd.Parameters.Add(new SqlParameter("@JobId", job.JobId));
                    cmd.Parameters.Add(new SqlParameter("@JobType", job.JobType));
                    cmd.Parameters.Add(new SqlParameter("@JobDescription", job.JobDescription));
                    cmd.Parameters.Add(new SqlParameter("@JobDate", job.JobDate));
                    cmd.Parameters.Add(new SqlParameter("@VehicleNumber", job.VehicleNumber));
                    cmd.Parameters.Add(new SqlParameter("@ServiceCharge", job.ServiceCharge));
                    cmd.Parameters.Add(new SqlParameter("@Quantity", job.Quantity));

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
        public static bool Update(Job job)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "UPDATE Jobs SET JobType=@JobType, [JobDescription]=@JobDescription,[JobDate]=@JobDate " +
                        "VehicleNumber=@VehicleNumber ,ServiceCharge=@ServiceCharge,Quantity=@Quantity,SparePartId=@SparePartId" +
                        " WHERE JobId=@JobId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;
                    cmd.Parameters.Add(new SqlParameter("@SparePartID", job.SparePartId));
                    cmd.Parameters.Add(new SqlParameter("@JobId", job.JobId));
                    cmd.Parameters.Add(new SqlParameter("@JobType", job.JobType));
                    cmd.Parameters.Add(new SqlParameter("@JobDescription", job.JobDescription));
                    cmd.Parameters.Add(new SqlParameter("@JobDate", job.JobDate));
                    cmd.Parameters.Add(new SqlParameter("@VehicleNumber", job.VehicleNumber));
                    cmd.Parameters.Add(new SqlParameter("@ServiceCharge", job.ServiceCharge));
                    cmd.Parameters.Add(new SqlParameter("@Quantity", job.Quantity));

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
                    string query = "DELETE Jobs WHERE JobId=@JobId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@JobId", id));
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
