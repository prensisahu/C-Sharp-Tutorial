using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class MethodParameters
    {
        static void MyMethodExample3(string fname)
        {
            Console.WriteLine(fname);
        }

        static void Main()
        {
            MyMethodExample3("Liam");
            MyMethodExample3("Jenny");
            MyMethodExample3("Anja");
        }

        // Liam Refsnes
        // Jenny Refsnes
        // Anja Refsnes
    }
}
