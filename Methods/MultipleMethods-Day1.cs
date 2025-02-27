using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class MultipleMethods
    {
        static void MyMethodExample2()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main()
        {
            MyMethodExample2();
            MyMethodExample2();
            MyMethodExample2();
        }

        // I just got executed!
        // I just got executed!
        // I just got executed!
    }
}
