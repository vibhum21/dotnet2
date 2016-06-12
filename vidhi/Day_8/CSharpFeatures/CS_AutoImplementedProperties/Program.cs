using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_AutoImplementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
          

     Student objEmp1 = new Student() { RollNo = 101,Name="Shivaji", Marks = 450 };
     Student objEmp2 = new Student() { RollNo = 102, Name = "Sambhaji", Marks=877 };

            int[] arr = new int[] { 1, 2, 3 };
            List<int> iList = new List<int>() 
            {
                1,2,3,4,5
            };

            List<Student> empList = new List<Student>()
                    {
                      new Student(){RollNo=101,Name="Rahul", Marks=340,Age=25},
                      new Student(){RollNo=101,Name="Aishwarya", Marks=400,Age=23},
                      new Student(){RollNo=101,Name="Sourabh", Marks=240,Age=25},
                      new Student(){RollNo=101,Name="Rambhau", Marks=500,Age=24},
                      new Student(){RollNo=101,Name="Tushar", Marks=123,Age=23},
                      new Student(){RollNo=101,Name="Deepali", Marks=453,Age=22},
                      new Student(){RollNo=101,Name="Komal", Marks=540,Age=21},
                    };

            foreach (var per in empList)
            {
                Console.WriteLine(per.Name);
            }

            

            Console.ReadLine();  
        }
    }

    public class Person
    {
        public int AdharID { get; set; }
        public string Name { get; set; }
        public double Age { get;set; }
    }

    public class Student : Person
    {
        public int RollNo { get; set; }
        public double Marks { get; set; }
    }
}
