using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class TernaryOperator

        /* Syntax
         variable = (condition)? expressionTrue :  expressionFalse; */

    {
        public void TernaryOperatorExample()
        {
            // Example 1
            int time = 30;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);


            // Example 2
            int a = 10;
            int b = 20;
            int result1 = (a > b) ? a : b;
            Console.WriteLine(result1);
        }
    }
}
