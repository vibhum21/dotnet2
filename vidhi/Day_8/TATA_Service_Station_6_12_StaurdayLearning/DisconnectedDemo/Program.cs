using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedDemo
{
    class Program
    {
        static void Main(string[] args)
        {   string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\RaviT\Desktop\TATA_Service_Station_24_10_15\DBConsoleDemo\CRM.mdf;Integrated Security=True;Connect Timeout=30";
            string cmdStr = "SELECT * FROM customers";
            try
            {   SqlDataAdapter da = new SqlDataAdapter(cmdStr,constr);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["firstname"] + " " + row["lastname"] + "  " + row["email"] );
      
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
