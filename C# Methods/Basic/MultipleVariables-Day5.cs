using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class MultipleVariables
    {
        public void MultipleVariablesExample()
        {
            int x = 3, y = 3, z = 4;  // Declare three variables of the same type, and assign values to them.
            Console.WriteLine(x + y + z);
        }

        public void MultipleVariablesExample2()
        {
            int x, y, z;
            x = y = z = 50; // You can also assign the same value to multiple variables in one line.
            Console.WriteLine(x + y + z);
        }
    }
}
