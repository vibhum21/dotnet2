using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_LocalVariableTypeInference
{
    class Program
    {
        static void Main(string[] args)
        {
            var objEmp = new { EmpNo = 101, EmpName = "Ravi", City="Pune" };
            var objProd = new { ProductID = 234, Category = "Book", UnitPrice = 400, InStock = 34 };

            Console.WriteLine("EmpNo = " + objEmp.EmpNo + " City  = " + objEmp.City);

            Type t = objEmp.GetType();
            string typeName = t.Name;
          
            Console.ReadLine();  
        }

       
    }
}
