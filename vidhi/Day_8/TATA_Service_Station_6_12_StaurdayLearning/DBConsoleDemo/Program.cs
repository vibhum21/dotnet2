using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DBConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {   //define connection string
            string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\RaviT\Desktop\TATA_Service_Station_24_10_15\DBConsoleDemo\CRM.mdf;Integrated Security=True;Connect Timeout=30";
                        //Create Connection Object
            SqlConnection con = new SqlConnection();
            con.ConnectionString = constr;
            string cmdStr = "SELECT * FROM customers";
            //Create Command Object
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = cmdStr;
            //associate command with connection
            cmd.Connection = con;
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int cutomerId=int.Parse(dr["id"].ToString());
                    string firstName = dr["firstname"].ToString();
                    string lastName = dr["lastname"].ToString();
                    string email = dr["email"].ToString();
                    string phone = dr["phoneno"].ToString();
                    DateTime bDate = Convert.ToDateTime(dr["birthdate"]);
                    string address = dr["address"].ToString();
                    Console.WriteLine(firstName + " " + lastName + "  " + email + "  " + phone + "  " + address + " " + bDate.ToShortDateString());
                }
               
            }
            catch (OleDbException  e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                con.Close();
            }
           
            Console.ReadLine();

        }
    }
}
