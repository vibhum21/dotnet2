using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TATABOLLib;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TATADALLib
{
    public class CredentialDAL
    {
       
        private static string conString = string.Empty;

        public static bool validate(string username,string password)
        {
            bool status = false;
            List<Credential> credentials = new List<Credential>();
            credentials = CredentialDAL.GetAll();
            foreach(var person in credentials)
            {
                if (username.Equals(person.LoginName) && password.Equals(person.Password))
                    status = true;
            }
            return status;
        }
        public static List<Credential> GetAll()
        {
            List<Credential> credentials = new List<Credential>();
            conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            string cmdStr = "SELECT * FROM Credentials";
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int Id = int.Parse(dr["Id"].ToString());
                    string username = dr["LoginName"].ToString();
                    string password = dr["Password"].ToString();
                    Credential cred = new Credential();
                    cred.LoginName = username;
                    cred.Password = password;
                    cred.Id = Id;
                    credentials.Add(cred);
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
            return credentials;
        }
        public static Credential Get(int id)
        {
            Credential credential = null;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "SELECT * FROM Credentials WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Id", id));
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            credential = new Credential()
                            {
                                Id = id,
                                LoginName = reader["LoginName"].ToString(),
                                Password = reader["Password"].ToString(),
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
            return credential;

        }
        public static Credential Get(string name)
        {
            Credential credential = null;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "SELECT * FROM Credentials WHERE LoginName=@Name";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Name", name));
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            credential = new Credential()
                            {
                                //customerId = id,
                                LoginName = name,
                                Password = reader["Password"].ToString(),
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
            return credential;

        }

        public static bool Insert(Credential credential)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "INSERT INTO Credentials VALUES(@Id,@name,@password)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@Id", credential.Id));
                    cmd.Parameters.Add(new SqlParameter("@name", credential.LoginName));
                    cmd.Parameters.Add(new SqlParameter("@password", credential.Password));
                  
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
        public static bool Update(Credential credential)
        {
            bool status = false;
            try
            {
                conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "UPDATE Credentials SET LoginName=@Name, [Password]=@Password, " +
                       " WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@Id", credential.Id));
                    cmd.Parameters.Add(new SqlParameter("@Name", credential.LoginName));
                    cmd.Parameters.Add(new SqlParameter("@Password", credential.Password));
                 
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
                    string query = "DELETE Credentials WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.CommandType = CommandType.;

                    cmd.Parameters.Add(new SqlParameter("@Id", id));
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
