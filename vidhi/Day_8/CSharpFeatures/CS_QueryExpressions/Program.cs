using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_QueryExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[] { "Nitesh", "Akanksha", "Manishankaracharya", "Salil","Bill" , 
                                               "Rohit", "Siddhachakra" ,"Ani","Sumeet","Hemant","Mohit",
                                               "Amol","Rajiv","Kimaya","Santosh","Nilesh","Meera","Manishankar",
                                               "Amitabh","Simth","Kamal","Steve","Rana","Jaiprakash","Narendra",};
            
            var filterNamebyChar = students.Where(n => n.Contains('i'));

            Console.WriteLine("Students Names containing i");

            Console.WriteLine("*********************************************");
            Console.WriteLine("*********************************************");
            Console.WriteLine("*********************************************");


            foreach (var item in filterNamebyChar)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("******************************************************");
            //Console.WriteLine("*******************************************************");

            var NamesOrderedBy = filterNamebyChar.OrderBy(n => n.Length);







            Console.WriteLine("Names containing i in Inreasing Order ");

            foreach (var item in NamesOrderedBy)
            {
                Console.WriteLine(item);
            }


            //Console.WriteLine("");
            //Console.WriteLine("");


            var InUpperCase = NamesOrderedBy.Select(n => n.ToUpper());
            Console.WriteLine("Names containing i in Inreasing Order in Upper Case ");
            foreach (var item in InUpperCase)
            {
                Console.WriteLine(item);
            }

            //var AllTogether = students.Where(n => n.Contains('i'))
            //                                    .OrderBy(n => n.Length)
            //                                    .Select(n => n.ToUpper());

            //Console.WriteLine("Students names containing i in Inreasing Order in Upper Case ");


            //Imperative Query Expressions
            //foreach (var item in AllTogether)
            //{
            //    Console.WriteLine(item);
            //}




            //foreach (string s in students)
            //{
            //    foreach (char c in s)
            //    {
            //        if (c == 'i')
            //        {
            //            Console.WriteLine("String with i " + s);
            //        }
            //    }
            //}
 

            Console.ReadLine();  
        }
    }



}
