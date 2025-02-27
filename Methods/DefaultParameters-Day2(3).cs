using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class DefaultParameters_Day2_3
    {
        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        static void Main()
        {
            MyMethod("Sweden");
            MyMethod("India");
            MyMethod();
            MyMethod("USA");
        }

        // Sweden
        // India
        // Norway
        // USA
    }
}
