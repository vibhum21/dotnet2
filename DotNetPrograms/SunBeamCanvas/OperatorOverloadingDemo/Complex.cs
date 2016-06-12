using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo
{
    class Complex
    {
        int real;

        public int Real
        {
            get { return real; }
            set { real = value; }
        }
        int imag;

        public int Imag
        {
            get { return imag; }
            set { imag = value; }
        }

    }
}
