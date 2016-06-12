#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

using System.Threading;

namespace BackgroundThread
{
  #region Printer helper class
  public class Printer
  {
    public void PrintDocuments()
    {
      // Display Thread info.
      Console.WriteLine("-> {0} is executing PrintDocuments()",
          Thread.CurrentThread.Name);

      // Print out numbers.
      Console.Write("Printing Documents: ");
      for (int i = 0; i < 10; i++)
      {
        Console.Write("{0}, ", i);
        Thread.Sleep(2000);
      }
      Console.WriteLine();
    }
  }
  #endregion

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Background Threads *****\n");

      Printer p = new Printer();
      Thread bgroundThread =
          new Thread(new ThreadStart(p.PrintDocuments));

      // Comment out this line to run thread as foreground.
      bgroundThread.IsBackground = true;
      
      bgroundThread.Start();
      Console.ReadLine();

    
    }
  }
}
