using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Contexts;
using System.Threading;
using System.Runtime.CompilerServices;

namespace SynchronizationContextDemo
{
    [Synchronization()]
    public class SampleSyncronized : ContextBoundObject
    {

        // A method that does some work, and returns the square of the given number.
        public  void Square()
        {
            int i=0;

            Console.Write("The hash of the thread executing ");
            Console.WriteLine("SampleSyncronized.Square is: {0}",
                                 Thread.CurrentThread.GetHashCode());
            i = Thread.CurrentThread.GetHashCode();
           // Thread.CurrentThread.Suspend();
            Thread.Sleep(100);
            Console.WriteLine("Square is {0}", i * i);
        }
    }

  
    class BankAccount
    {
       
        static void Main(string[] args)
        {
            SampleSyncronized obj = new SampleSyncronized();

            Thread t1 = new Thread(new ThreadStart(obj.Square));
            Thread t2 = new Thread(new ThreadStart(obj.Square));
            t1.Start();
            t2.Start();

            Console.ReadLine();

        }
    }
}
