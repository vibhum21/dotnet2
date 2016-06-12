using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPartial
{
    class Books
    {
        private string [] titles= new string [8];
        public Books()
        {
            titles[0] = "Let us C";
            titles[1] = "Let us C++";
            titles[2] = "Let us Java";
            titles[3] = "Inside c#";
            titles[4] = "Inside CLR";
            titles[5] = "Professional ASP.NET";
            titles[6] = "Essential .NET";
            titles[7] = "Office 365";


        }
        public string this [int index]
        {
            get
                {
                 return titles [index];
                }
            set
                {
                 titles [index] =value;
                }
        }
    }
}
