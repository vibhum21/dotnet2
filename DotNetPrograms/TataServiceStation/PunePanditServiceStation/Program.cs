using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PanditDALLib;
using PanditBOLLib;
using PanditCLLib;
namespace PunePanditServiceStation
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Vehicle> vehicles=VehicleCL.GetALL();
            //foreach (Vehicle veh in vehicles)
            //    Console.WriteLine(veh);
            //Vehicle vehicle = VehicleCL.Get();
            //Console.WriteLine(vehicle);
            //VehicleCL.Insert();
            //VehicleCL.Update();
            //VehicleCL.Delete();

            //List<Bill> bills = BillCL.GetAll();
            //foreach (Bill bill in bills)
            //    Console.WriteLine(bill);
            //Bill bill = BillCL.Get();
            //Console.WriteLine(bill);
            //BillCL.Insert();
            //BillCL.Update();
            //BillCL.Delete();

            //List<Job> jobs = JobCL.GetAll();
            //foreach (Job job in jobs)
             //   Console.WriteLine(job);
            //Job job = JobCL.Get();
            //Console.WriteLine(job);
            //JobCL.Insert();
            //JobCL.Update();
            //JobCL.Delete();

            //List<SparePart> spareparts = SparePartCL.GetAll();
            //foreach (SparePart sp in spareparts)
            //  Console.WriteLine(sp);
            //SparePart sparepart = SparePartCL.Get();
            //Console.WriteLine(sparepart);
            //SparePartCL.Insert();
            //SparePartCL.Update();
            //SparePartCL.Delete();

            List<Oil> oils = OilCL.GetAll();
            foreach (Oil oil in oils)
                Console.WriteLine(oil);
            //SparePart sparepart = SparePartCL.Get();
            //Console.WriteLine(sparepart);
            //SparePartCL.Insert();
            //SparePartCL.Update();
            //SparePartCL.Delete();
        }
    }
}
//    public class Customer
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public string Email { get; set; }
//        public float Salary { get; set; }
//        public override string ToString()
//        {
//            return FirstName + " " + LastName + " " + Salary;
//            //return base.ToString();
//        }
//    }
//      class Program
//    {
//        static void Main(string[] args)
//        {
//            //PerformConnectedDataAccess();
//            PerformDisConnectedDataAccess();
//            Console.ReadLine();
//        }
//        static void PerformConnectedDataAccess()
//        {
//            List<Customer> customers = new List<Customer>();
//            string conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
//            SqlConnection con = new SqlConnection(conString);
//            string cmdStr = "SELECT * FROM Customers";
//            SqlCommand cmd = new SqlCommand(cmdStr, con);
//            try
//            {
//                con.Open();
//                SqlDataReader dr = cmd.ExecuteReader();
//                while (dr.Read())
//                {
//                    string firstName = dr["firstName"].ToString();
//                    string lastName = dr["lastName"].ToString();
//                    string email = dr["email"].ToString();
//                    DateTime bdate = Convert.ToDateTime(dr["birthDate"]);
//                    float salary = float.Parse(dr["salary"].ToString());

//                    Customer cust = new Customer();
//                    cust.FirstName = firstName;
//                    cust.LastName = lastName;
//                    cust.Email = email;
//                    cust.Salary = salary;
//                    customers.Add(cust);
//                }

//            }
//            catch (SqlException exp)
//            {
//                Console.WriteLine(exp.Message);

//            }
//            finally
//            {
//                con.Close();
//            }
//            foreach (Customer cust in customers)
//            {
//                Console.WriteLine(cust);

//            }
//        }
  
//     static void PerformDisConnectedDataAccess()
//        {
//            List<Customer> customers = new List<Customer>();
//            string conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
//            SqlConnection con = new SqlConnection(conString);
//            string cmdStr = "SELECT * FROM Customers";
//            SqlCommand cmd = new SqlCommand(cmdStr, con);
//            SqlDataAdapter da = new SqlDataAdapter(cmd);
//            DataSet ds=new DataSet();
//            da.Fill(ds);
//            DataTable tbl = ds.Tables[0];
//            DataRowCollection  dtr = tbl.Rows;

//            foreach (DataRow dr in dtr)
//            {
//                string firstName = dr["firstName"].ToString();
//                string lastName = dr["lastName"].ToString();
//                string email = dr["email"].ToString();
//                DateTime bdate = Convert.ToDateTime(dr["birthDate"]);
//                float salary = float.Parse(dr["salary"].ToString());

//                Customer cust = new Customer();
//                cust.FirstName = firstName;
//                cust.LastName = lastName;
//                cust.Email = email;
//                cust.Salary = salary;
//                customers.Add(cust);
//            }


//            foreach (Customer cust in customers)
//            {
//                Console.WriteLine(cust);

//            }
 
//        }


//        //CRUD Operations
      
//        //
//        //UPDATE SET EMPLOYEES  FANME= ""  WEHERE EMPID=23
//        //DELETE FROM EMPLOYEES WHERE empID=45;

//        //SELECT *  FROM  EMPLOYESS WHERE 
//        //SELECT COUNT(*) FROM EMPLOYEES

//        static  void PerformInsertData()
//        {
//            string conString = ConfigurationManager.ConnectionStrings["constrPanditAuto"].ConnectionString;
//            SqlConnection con = new SqlConnection(conString);
//            string cmdStr = "SELECT count(*)  FROM Customers";
//            SqlCommand cmd = new SqlCommand(cmdStr, con);
//            try
//            {
//                con.Open();
//            }
//            catch (SqlException exp)
//            {
//                Console.WriteLine(exp.Message);
//            }
//            finally
//            {
//                con.Close();
//            }
//        }
//    }
//}