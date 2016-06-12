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
    public class SparePartDAL
    {
        private static string conString = string.Empty;

        public static List<SparePart> GetAll()
        {
            List<SparePart> spareparts = new List<SparePart>();
            conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            string cmdStr = "SELECT SparePartID,Name,Quantity,UnitPrice FROM SpareParts";
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int SparePartId = int.Parse(dr["SparePartID"].ToString());
                    string name = dr["Name"].ToString();
                    int Quantity = int.Parse(dr["Quantity"].ToString());
                    float UnitPrice = float.Parse(dr["UnitPrice"].ToString());
                    SparePart sparepart = new SparePart();
                    sparepart.SparePartId = SparePartId;
                    sparepart.Name = name;
                    sparepart.Quantity = Quantity;
                    sparepart.UnitPrice = UnitPrice;

                    spareparts.Add(sparepart);
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
            return spareparts;
        }
        public static SparePart Get(int id)
        {
            SparePart sparepart = null;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "SELECT SparePartID,Name,Quantity,UnitPrice FROM SpareParts WHERE SparePartID="+id;
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.Parameters.Add(new SqlParameter("@SparePartId", id));
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            sparepart = new SparePart()
                            {
                                SparePartId = int.Parse(reader["SparePartId"].ToString()),
                                 Name = reader["Name"].ToString(),
                                 Quantity = int.Parse(reader["Quantity"].ToString()),
                                 UnitPrice = float.Parse(reader["UnitPrice"].ToString()),
                            };
                        }
                    }
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            //ADO.NET code 
            return sparepart;

        }
        public static SparePart Get(string VehicleNumber)
        {
            SparePart sparepart = new SparePart();
            //ADO.NET code 
            return sparepart;
        }
        public static bool Insert(SparePart sparepart)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "INSERT INTO SpareParts VALUES(@SparePartId,@Name,@Quantity,@UnitPrice)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@SparePartID", sparepart.SparePartId));
                    cmd.Parameters.Add(new SqlParameter("@Name", sparepart.Name));
                    cmd.Parameters.Add(new SqlParameter("@Quantity", sparepart.Quantity));
                    cmd.Parameters.Add(new SqlParameter("@UnitPrice", sparepart.UnitPrice));
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
        public static bool Update(SparePart sparepart)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "UPDATE SpareParts SET Name=@Name, [Quantity]=@Quantity, " +
                        "UnitPrice=@UnitPrice " +
                        " WHERE SparePartId=@SparePartId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;
                    cmd.Parameters.Add(new SqlParameter("@SparePartID", sparepart.SparePartId));
                    cmd.Parameters.Add(new SqlParameter("@Name", sparepart.Name));
                    cmd.Parameters.Add(new SqlParameter("@Quantity", sparepart.Quantity));
                    cmd.Parameters.Add(new SqlParameter("@UnitPrice", sparepart.UnitPrice));

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
                    string query = "DELETE SpareParts WHERE SparePartId=@SparePartId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@SparePartId", id));
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
