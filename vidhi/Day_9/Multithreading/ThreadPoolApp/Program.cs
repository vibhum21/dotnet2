using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadPoolApp
{
  #region Helper class
  public class Printer
  {
    private object lockToken = new object();

    public void PrintDocuments()
    {
      lock (lockToken)
      {
        // Display Thread info.
        Console.WriteLine("-> {0} is executing PrintDocuments()",
          Thread.CurrentThread.Name);

        // Print out numbers.
        Console.Write("Your Documents: ");
        for (int i = 0; i < 10; i++)
        {
          Console.Write("{0}, ", i);
          Thread.Sleep(1000);
        }
        Console.WriteLine();
      }
    }
  }
  #endregion 

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with the CLR Thread Pool *****\n");

      Console.WriteLine("Main thread started. ThreadID = {0}",
        Thread.CurrentThread.ManagedThreadId); 

      Printer p = new Printer();

      WaitCallback workItem = new WaitCallback(PrintDocuments);

      // Queue the method 10 times
      for (int i = 0; i < 10; i++)
      {
        ThreadPool.QueueUserWorkItem(workItem, p);
      }

      Console.WriteLine("All tasks queued");
      Console.ReadLine();
    }

    static void PrintDocuments(object state)
    {
      Printer task = (Printer)state;
      task.PrintDocuments();
    }
  }
}
