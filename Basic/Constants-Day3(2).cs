using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Constants
    {
        public void ConstantsExample()
        {
            const int myNum = 3;  // Create a constant and set its value
            Console.WriteLine(myNum);
            // myNum = 20;  // Error! Constants cannot be changed
        }
    }
}
