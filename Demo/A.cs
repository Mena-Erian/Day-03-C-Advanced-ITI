using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class A
    {
        private int x;

        class B 
        {
            public B(A a)
            {
                //Console.WriteLine(a.x);
                a.x = 1;
            }
        }
    }
}
