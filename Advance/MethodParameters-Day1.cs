using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance
{
    internal class MethodParameters
    {
        static void MyMethod2(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }

        static void Main()
        {
            MyMethod2("Liam");
            MyMethod2("Jenny");
            MyMethod2("Anja");
        }

        // Liam Refsnes
        // Jenny Refsnes
        // Anja Refsnes
    }
}
