using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Linq.Dynamic;
using System.Windows.Forms;
using NorthwindMapping;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
           string connString = "Server=10.10.10.10;Database=Northwind;uid=sa;pwd=P@ssw0rd123;";  
           
           Northwind db = new Northwind(connString); 
           db.Log = Console.Out;

            var query =
                db.Customers.Where("City == @0 and Orders.Count >= @1", "London", 10).
                OrderBy("CompanyName").
                Select("New(CompanyName as Name, Phone)");

            Console.WriteLine(query);
            Console.ReadLine();
        }
    }
}