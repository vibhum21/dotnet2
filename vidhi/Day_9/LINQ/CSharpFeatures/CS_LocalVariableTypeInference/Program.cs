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
            var objEmp = new { EmpNo = 101, EmpName = "Ravi" };

            Console.WriteLine("EmpNo = " + objEmp.EmpNo + " EmpName  = " + objEmp.EmpName);
            Console.ReadLine();  
        }

       
    }
}
