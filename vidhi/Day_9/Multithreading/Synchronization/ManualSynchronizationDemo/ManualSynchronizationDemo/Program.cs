using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ManualSynchronizationDemo
{
   class AccountUser
   {
        static int count;
        public AccountUser()
        {
            count++;
           Interlocked.Increment(ref count);
            Console.WriteLine(Thread.CurrentThread.Name+"\t"+count);
        }
        ~AccountUser()
        {
          Interlocked.Decrement(ref count);
        }
   }
    class MainClass
    {
        public static void Main()
        {
            Thread thread1 = new Thread(new ThreadStart(CreateUser));
            Thread thread2 = new Thread(new ThreadStart(CreateUser));
            thread1.Name = "One";
            thread2.Name = "Two";

            thread1.Start();
            thread2.Start();
          
            Console.Read();
        }
        private static void CreateUser()
        {
            AccountUser accUser;
            for (int i = 0; i <10; i++)
            {
                accUser = new AccountUser();
            }
        }
      }
    }
