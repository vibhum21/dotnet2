using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string asmName = @"E:\SunbeamCanvas\GraphicLib\bin\Debug\GraphicLib.dll";
            Assembly asm = Assembly.LoadFile(asmName);
         
          string fullName = asm.FullName;
          Type [] types=  asm.GetTypes();
          foreach (Type t in types)
          {
              string typeName = t.FullName;
              Console.WriteLine(typeName);
              MethodInfo[] mi = t.GetMethods();
              foreach (MethodInfo m in mi)
              {
                  string methodName = m.Name;
                  Console.WriteLine("Method is :" + methodName);
              }
          }
          Console.ReadLine();
        }
    }
}
